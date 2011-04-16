using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace Knoodou.Banco
{
    class Locacao : Default
    {
        public MySqlDataAdapter buscarClientes()
        {
            retorno = new MySqlDataAdapter("SELECT nome,sexo,date_format(dt_nasc, '%d/%m/%Y') as dt_nasc,id FROM CLIENTE", this.con);
            return retorno;
        }

        public string[] dadosDoCliente(int id)
        {
            MySqlCommand comando = this.con.CreateCommand();
            comando.CommandText = "SELECT substr(rg,5) as rg,telefone,nome,sexo,DATE_FORMAT(NOW(), '%Y') - DATE_FORMAT(dt_nasc, '%Y') - (DATE_FORMAT(NOW(), '00-%m-%d') < DATE_FORMAT(dt_nasc, '00-%m-%d')) AS age from Cliente where ID = " + id;
            MySqlDataReader reader;
            reader = comando.ExecuteReader();
            reader.Read();

            string[] retorno = { reader.GetValue(0).ToString(), reader.GetValue(1).ToString(),
            reader.GetValue(2).ToString(), reader.GetValue(3).ToString(), reader.GetValue(4).ToString() };

            reader.Close();
            return retorno;
        }

        public MySqlDataAdapter buscarFilmes()
        {
            retorno = new MySqlDataAdapter("SELECT filme.id,titulo, midia, duracao,group_concat(genero.tipo) as generos FROM filme join FORMATO on filme.formato_id = formato.id join GENERO_R_FILME on FILME.ID = GENERO_R_FILME.FILME_ID join GENERO on genero_r_filme.GENERO_ID = GENERO.ID group by titulo,formato_id order by titulo ASC", this.con);
            return retorno;
        }

        public string[] dadosDoFilme(int id)
        {
            MySqlCommand comando = this.con.CreateCommand();
            comando.CommandText = "SELECT titulo,ano,classificacao,(quantidade - (SELECT count(*) from locacao join filme_r_locacao on locacao.id = filme_r_locacao.locacao_id join filme on filme.id = filme_r_locacao.Filme_id where entregue = 0 AND filme.id = "+ id + ")) as quantidade,imdb,site,duracao,caracteristica from FILME where ID = " + id;
            MySqlDataReader reader;
            reader = comando.ExecuteReader();
            reader.Read();

            string[] retorno = { reader.GetValue(0).ToString(), reader.GetValue(1).ToString(), reader.GetValue(2).ToString()
                                   , reader.GetValue(3).ToString() , reader.GetValue(4).ToString() , reader.GetValue(5).ToString()
                                , reader.GetValue(6).ToString() , reader.GetValue(7).ToString()};

            reader.Close();
            return retorno;
        }

	    public string[] top5()
        {
            MySqlCommand comando = this.con.CreateCommand();
            comando.CommandText = "SELECT titulo from FILME join filme_r_locacao on filme.id = filme_r_locacao.filme_id join locacao on locacao.id = filme_r_locacao.locacao_id group by titulo order by count(titulo) DESC limit 5";
            MySqlDataReader reader;
            reader = comando.ExecuteReader();
            IList<string>retorno = new List<string>();
            while (reader.Read())
            {
                retorno.Add(reader.GetValue(0).ToString());
            }

            reader.Close();
            return retorno.ToArray<string>();
        }

        public string[] topGeneros() 
        {
            MySqlCommand comando = this.con.CreateCommand();
            comando.CommandText = "select tipo,count(*) as quantidade from genero join genero_r_filme on genero.id = genero_r_filme.genero_id join filme on filme.id = genero_r_filme.filme_id join filme_r_locacao on filme_r_locacao.filme_id = filme.id join locacao on filme_r_locacao.locacao_id = locacao.id group by tipo order by quantidade desc limit 5";
            MySqlDataReader reader;
            reader = comando.ExecuteReader();
            IList<string> retorno = new List<string>();
            while (reader.Read())
            {
                retorno.Add(reader.GetValue(0).ToString());
            }

            reader.Close();
            return retorno.ToArray<string>();
        }

        public bool[] pendencias(int id)
        {
            MySqlCommand comando = this.con.CreateCommand();
            comando.CommandText = "SELECT entregue, pago from LOCACAO  where id = " + id; 
            MySqlDataReader reader;
            reader = comando.ExecuteReader();
            reader.Read();
                bool[] retorno = {reader.GetBoolean("entregue"), reader.GetBoolean("pago")};

            reader.Close();
            return retorno;
        }

        public bool autorizado(int id)
        {
            MySqlCommand comando = this.con.CreateCommand();
            comando.CommandText = string.Format("SELECT (SELECT count(*) from locacao where pago = 0 and cliente_id = {0}),  (SELECT count(*) from locacao where entregue = 0 and cliente_id = {0}) from LOCACAO group by id", id,id);
            MySqlDataReader reader;
            reader = comando.ExecuteReader();
            if (reader.Read())
            {
                string[] retorno = { reader.GetValue(0).ToString(), reader.GetValue(1).ToString() };

                reader.Close();
                return (retorno[0] == "0" && retorno[1] == "0");
            }
            else { reader.Close(); return true; }
        }

        public double valores(int[] ids)
        {
            MySqlCommand comando = this.con.CreateCommand();
            MySqlDataReader reader;
            double soma = 0;

            foreach (int id in ids)
            {
                comando.CommandText = string.Format("SELECT round(IF (date_add(dt_cadastro, INTERVAL (SELECT valor from configuracoes where chave='tempo_lancamento' limit 1) DAY) > now(), (SELECT preco_lancamento from formato join filme on formato.id = filme.formato_id where filme.id = {0}), (SELECT preco_normal from formato join filme on filme.formato_id = formato.id where filme.id = {1}) ),2) as valor from Filme where id = {2}",id,id,id);
                reader = comando.ExecuteReader();
                reader.Read();
                soma += reader.GetDouble(0);
                reader.Close();
            }
            return soma;
        }

        public MySqlDataAdapter buscarLocacoes(int cliente)
        {
            retorno = new MySqlDataAdapter("SELECT dt_locacao,locacao.id from locacao join cliente on cliente.id = locacao.cliente_id where cliente.id = " + cliente + " order by dt_locacao DESC", this.con);
            return retorno;
        }

        public string[] dadosLocacao(int id)
        {
            MySqlCommand comando = this.con.CreateCommand();
            comando.CommandText = "SELECT valor_final,dt_entrega,usuario.nome, dt_locacao,datediff(dt_entrega,now()) as diferenca from LOCACAO join usuario on usuario.id = locacao.usuario_id  where locacao.id = " + id;
            MySqlDataReader reader;
            reader = comando.ExecuteReader();
            reader.Read();
            string[] retorno = { string.Format("{0:0.00}",reader.GetDouble(0)), reader.GetString(1), reader.GetString(2),
                               reader.GetString(3), reader.GetString(4) };

            reader.Close();
            return retorno;
        }

        public void atualizarLocacao(bool entregue, bool pago,int id)
        {
            MySqlCommand comando = this.con.CreateCommand();
            comando.CommandText = string.Format("UPDATE LOCACAO set entregue = {0}, pago = {1}, dt_entregue = now() WHERE id = {2}", Convert.ToInt16(entregue), Convert.ToInt16(pago), id);
            comando.ExecuteNonQuery();
        }

        public void criarLocacao(int cliente_id, int usuario_id, double valor_final, bool pago, int[] ids)
        {
            MySqlCommand comando = this.con.CreateCommand();
            comando.CommandText = string.Format("Insert into LOCACAO VALUES (NULL,{0},{1},now(),{2},date_add(now(), INTERVAL 2 DAY),false,{3},null );select LAST_INSERT_ID();",cliente_id,usuario_id,valor_final.ToString().Replace(',','.'),pago);
            MySqlDataReader reader;
            reader = comando.ExecuteReader();
            reader.Read();
            int ultimaLocacao = reader.GetInt32(0);
            reader.Close();

            foreach (int id in ids)
            {
                comando.CommandText = string.Format("Insert into FILME_R_LOCACAO VALUES ( {0},{1} )",id,ultimaLocacao );
                comando.ExecuteNonQuery();
            }
        }

        public string faturamentoDiario()
        {
            MySqlCommand comando = this.con.CreateCommand();
            comando.CommandText = "SELECT round(SUM(valor_final),2) from locacao where date(now()) = date(dt_locacao)";
            MySqlDataReader reader;
            reader = comando.ExecuteReader();
            string retorno;
            reader.Read();
            retorno = (!reader.IsDBNull(0) && reader.GetDouble(0) != 0.0  )? string.Format("{0:0.00}",reader.GetDouble(0)) : "0.00";
            reader.Close();
            return retorno;
        }

        public string[] sugestao(int id)
        {
            MySqlCommand comando = this.con.CreateCommand();
            comando.CommandText = string.Format(@"SELECT titulo from filme 
join genero_r_filme on genero_r_filme.filme_id = filme.id
join genero on genero.id = genero_r_filme.genero_id
where genero.id = (select genero.id from genero
join genero_r_filme on genero.id = genero_r_filme.genero_id
 join filme on filme.id = genero_r_filme.filme_id
  join filme_r_locacao on filme_r_locacao.filme_id = filme.id join
   locacao on filme_r_locacao.locacao_id = locacao.id 
where locacao.cliente_id = {0} group by genero.id order by count(*) DESC limit 1) and filme.titulo not in
(
SELECT filme.titulo from filme join filme_r_locacao on filme_r_locacao.filme_id = filme.id
join locacao on locacao.id = filme_r_locacao.locacao_id where cliente_id = {1} group by titulo
)
group by titulo,tipo order by filme.dt_cadastro DESC
", id,id);
            MySqlDataReader reader;
            reader = comando.ExecuteReader();
            IList<string> retorno = new List<string>();
            while (reader.Read())
                retorno.Add(reader.GetString(0));
            reader.Close();
            return retorno.ToArray();
        }

        public string nomeLocadora()
        {
            MySqlCommand comando = this.con.CreateCommand();
            MySqlDataReader reader;
            comando.CommandText = "SELECT valor from configuracoes where chave = 'nome_locadora'";
            reader = comando.ExecuteReader();
            reader.Read();
            string retorno = reader.IsDBNull(0) ? "" : reader.GetString(0);
            reader.Close();
            return retorno;
        }

        public string sugestionTituloRecursivo(string consulta)
        {
            if (consulta.Length <= 2) return "";
            MySqlCommand comando = this.con.CreateCommand();
            MySqlDataReader reader;
            comando.CommandText = "SELECT titulo from Filme where titulo like '%"+consulta+"%'";
            reader = comando.ExecuteReader();
            string retorno = "";
            if(reader.Read())
                retorno = reader.IsDBNull(0) ? "" : reader.GetString(0);
            reader.Close();
            return retorno == "" ? sugestionTituloRecursivo(consulta.Substring(0,consulta.Length-1)) : retorno;
        }

        public string susgestionTitulo(string consulta)
        {
            if (consulta.Length <= 2) return "";
            MySqlCommand comando = this.con.CreateCommand();
            MySqlDataReader reader;
            comando.CommandText = "SELECT titulo from Filme where titulo like '%" + consulta + "%'";
            reader = comando.ExecuteReader();
            string retorno = "";
            if(reader.Read())
              retorno = reader.IsDBNull(0) ? "" : reader.GetString(0);
            reader.Close();
            return retorno;
        }
        public string susgestionTituloAlternado(string consulta,bool final)
        {
            if (consulta.Length <= 2) return "";
            MySqlCommand comando = this.con.CreateCommand();
            MySqlDataReader reader;
            comando.CommandText = "SELECT titulo from Filme where titulo like '%" + consulta + "%'";
            reader = comando.ExecuteReader();
            string retorno = "";
            if (reader.Read())
                retorno = reader.IsDBNull(0) ? "" : reader.GetString(0);
            reader.Close();
            if (retorno == "")
            {
                if (final) return susgestionTituloAlternado(consulta.Substring(0, consulta.Length - 1), !final);
                else return susgestionTituloAlternado(consulta.Substring(1), !final);
            }
            return retorno;
        }

        public string sugestionGenero(string consulta)
        {
            if (consulta.Length <= 2) return "";
            MySqlCommand comando = this.con.CreateCommand();
            MySqlDataReader reader;
            comando.CommandText = "SELECT tipo from GENERO where tipo like '%" + consulta + "%'";
            reader = comando.ExecuteReader();
            string retorno = "";
            if (reader.Read())
                retorno = reader.IsDBNull(0) ? "" : reader.GetString(0);
            reader.Close();
            return retorno == "" ? sugestionGenero(consulta.Substring(0, consulta.Length - 1)) : retorno;
        }
    }
}
