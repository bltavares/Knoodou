using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace Knoodou.Banco
{
    class Relatorio : Default
    {

        public string[][] relatorioDiario(string date)
        {
            MySqlCommand comando = this.con.CreateCommand();
            comando.CommandText = @"SELECT count(*) as total, truncate(sum(valor_final),2) as valor
from locacao
where date("+date+") = date(dt_locacao)";
            MySqlDataReader reader = comando.ExecuteReader();

            IList<string[]> retorno = new List<string[]>();

            //Dados valor e locas;
            while (reader.Read())
            {
                string[] add = new string[2];
                add[0] = reader.IsDBNull(0) ? "Nenhum" : reader.GetString(0);
                add[1] = reader.IsDBNull(1) ? "0.00" : String.Format("{0:0.00}", reader.GetDouble(1));
                retorno.Add(add);
            }
            reader.Close();

            comando.CommandText = @"SELECT titulo from FILME join filme_r_locacao on filme.id = filme_r_locacao.filme_id join locacao on locacao.id = filme_r_locacao.locacao_id where date(
"+date+") = date(locacao.dt_locacao) group by titulo order by count(titulo) DESC limit 5";
            
            reader = comando.ExecuteReader();
            IList<string> Tops = new List<string>();

            while (reader.Read())
            {
                Tops.Add(reader.GetString(0));
            }
            reader.Close();
            retorno.Add(Tops.ToArray());
            Tops.Clear();

            comando.CommandText = @"select tipo,count(*) as quantidade from genero join genero_r_filme on genero.id = genero_r_filme.genero_id join filme on filme.id = genero_r_filme.filme_id join filme_r_locacao on filme_r_locacao.filme_id = filme.id join locacao on filme_r_locacao.locacao_id = locacao.id
where date(" +date+") = date(locacao.dt_locacao) group by tipo order by quantidade desc limit 5";

            reader = comando.ExecuteReader();

            while (reader.Read())
            {
                Tops.Add(reader.GetString(0));
            }
            reader.Close();
            retorno.Add(Tops.ToArray());

            Tops.Clear();

            comando.CommandText = @"SELECT midia from FILME join filme_r_locacao on filme.id = filme_r_locacao.filme_id join locacao on locacao.id = filme_r_locacao.locacao_id
join formato on filme.formato_id = formato.id where date(
" + date + ") = date(locacao.dt_locacao) group by midia order by count(midia) DESC limit 5";

            reader = comando.ExecuteReader();

            while (reader.Read())
            {
                Tops.Add(reader.GetString(0));
            }
            reader.Close();
            retorno.Add(Tops.ToArray());


            return retorno.ToArray();
        }


        public string[][] relatorioMensal(int mes)
        {
            MySqlCommand comando = this.con.CreateCommand();
            comando.CommandText = @"SELECT count(*) as total, truncate(sum(valor_final),2) as valor
from locacao
where " + mes + " = month(dt_locacao)";
            MySqlDataReader reader = comando.ExecuteReader();

            IList<string[]> retorno = new List<string[]>();

            //Dados valor e locas;
            while (reader.Read())
            {
                string[] add = new string[2];
                add[0] = reader.IsDBNull(0) ? "Nenhum" : reader.GetString(0);
                add[1] = reader.IsDBNull(1) ? "0.00" : String.Format("{0:0.00}", reader.GetDouble(1));
                retorno.Add(add);
            }
            reader.Close();

            comando.CommandText = @"SELECT titulo from FILME join filme_r_locacao on filme.id = filme_r_locacao.filme_id join locacao on locacao.id = filme_r_locacao.locacao_id 
where " + mes + " = month(locacao.dt_locacao) group by titulo order by count(titulo) DESC limit 5";

            reader = comando.ExecuteReader();
            IList<string> Tops = new List<string>();

            while (reader.Read())
            {
                Tops.Add(reader.GetString(0));
            }
            reader.Close();
            retorno.Add(Tops.ToArray());
            Tops.Clear();

            comando.CommandText = @"select tipo,count(*) as quantidade from genero join genero_r_filme on genero.id = genero_r_filme.genero_id join filme on filme.id = genero_r_filme.filme_id join filme_r_locacao on filme_r_locacao.filme_id = filme.id join locacao on filme_r_locacao.locacao_id = locacao.id
where " + mes + " = month(locacao.dt_locacao) group by tipo order by quantidade desc limit 5";

            reader = comando.ExecuteReader();

            while (reader.Read())
            {
                Tops.Add(reader.GetString(0));
            }
            reader.Close();
            retorno.Add(Tops.ToArray());

            Tops.Clear();

            comando.CommandText = @"SELECT midia from FILME join filme_r_locacao on filme.id = filme_r_locacao.filme_id join locacao on locacao.id = filme_r_locacao.locacao_id
join formato on filme.formato_id = formato.id where " + mes + " = month(locacao.dt_locacao) group by midia order by count(midia) DESC limit 5";

            reader = comando.ExecuteReader();

            while (reader.Read())
            {
                Tops.Add(reader.GetString(0));
            }
            reader.Close();
            retorno.Add(Tops.ToArray());


            return retorno.ToArray();
        }


        public string[][] relatorioAnual(int mes)
        {
            MySqlCommand comando = this.con.CreateCommand();
            comando.CommandText = @"SELECT count(*) as total, truncate(sum(valor_final),2) as valor
from locacao
where " + mes + " = year(dt_locacao)";
            MySqlDataReader reader = comando.ExecuteReader();

            IList<string[]> retorno = new List<string[]>();

            //Dados valor e locas;
            while (reader.Read())
            {
                string[] add = new string[2];
                add[0] = reader.IsDBNull(0) ? "Nenhum" : reader.GetString(0);
                add[1] = reader.IsDBNull(1) ? "0.00" : String.Format("{0:0.00}", reader.GetDouble(1));
                retorno.Add(add);
            }
            reader.Close();

            comando.CommandText = @"SELECT titulo from FILME join filme_r_locacao on filme.id = filme_r_locacao.filme_id join locacao on locacao.id = filme_r_locacao.locacao_id 
where " + mes + " = year(locacao.dt_locacao) group by titulo order by count(titulo) DESC limit 5";

            reader = comando.ExecuteReader();
            IList<string> Tops = new List<string>();

            while (reader.Read())
            {
                Tops.Add(reader.GetString(0));
            }
            reader.Close();
            retorno.Add(Tops.ToArray());
            Tops.Clear();

            comando.CommandText = @"select tipo,count(*) as quantidade from genero join genero_r_filme on genero.id = genero_r_filme.genero_id join filme on filme.id = genero_r_filme.filme_id join filme_r_locacao on filme_r_locacao.filme_id = filme.id join locacao on filme_r_locacao.locacao_id = locacao.id
where " + mes + " = year(locacao.dt_locacao) group by tipo order by quantidade desc limit 5";

            reader = comando.ExecuteReader();

            while (reader.Read())
            {
                Tops.Add(reader.GetString(0));
            }
            reader.Close();
            retorno.Add(Tops.ToArray());

            Tops.Clear();

            comando.CommandText = @"SELECT midia from FILME join filme_r_locacao on filme.id = filme_r_locacao.filme_id join locacao on locacao.id = filme_r_locacao.locacao_id
join formato on filme.formato_id = formato.id where " + mes + " = month(locacao.dt_locacao) group by midia order by count(midia) DESC limit 5";

            reader = comando.ExecuteReader();

            while (reader.Read())
            {
                Tops.Add(reader.GetString(0));
            }
            reader.Close();
            retorno.Add(Tops.ToArray());


            return retorno.ToArray();
        }

        public string[][] inadimplentes()
        {

            MySqlCommand comando = new MySqlCommand(@"SELECT nome,cliente.id FROM cliente join locacao on locacao.cliente_id = cliente.id
where locacao.pago = false or locacao.entregue = false group by cliente.id", this.con);
            MySqlDataReader reader;
            reader = comando.ExecuteReader();
            IList<string[]> retorno = new List<string[]>();
            while (reader.Read())
            {
                string[] sub = { reader.GetString(0), reader.GetString(1) };
                retorno.Add(sub);
            }
            reader.Close();
            return retorno.ToArray();
        }

        public string[] filmesComInadimplente(string id)
        {
            MySqlCommand comando = new MySqlCommand(@"SELECT titulo FROM locacao join filme_r_locacao on locacao.id = filme_r_locacao.locacao_id
join filme on filme_r_locacao.filme_id = filme.id
where locacao.entregue = false AND cliente_id = "+ id, this.con);
            MySqlDataReader reader;
            reader = comando.ExecuteReader();
            IList<string> retorno = new List<string>();
            while (reader.Read())
            {
                retorno.Add(reader.GetString(0));
            }
            reader.Close();
            return retorno.ToArray();
        }
    }
}
