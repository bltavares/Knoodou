using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace Knoodou.Banco
{
    class Email : Default
    {
        public string[][] maisAtivos()
        {
            MySqlCommand comando = this.con.CreateCommand();
            comando.CommandText = @"SELECT cliente.id,nome,email from cliente
left join locacao on cliente.id = locacao.cliente_id
where email <> ''
group by cliente.id order by count(locacao.id) DESC limit 10";
            MySqlDataReader reader = comando.ExecuteReader();

            IList<string[]> retorno = new List<string[]>();
            while (reader.Read())
            {
                string[] dados = new string[3];
                dados[0] = reader.GetString(0);
                dados[1] = reader.GetString(1);
                dados[2] = reader.GetString(2);
                retorno.Add(dados);
            }
            reader.Close();
            return retorno.ToArray();
        }

        public string[][] menosAtivos()
        {
            MySqlCommand comando = this.con.CreateCommand();
            comando.CommandText = @"SELECT cliente.id,nome,email from cliente
left join locacao on cliente.id = locacao.cliente_id
where email <> ''
group by cliente.id order by count(locacao.id) ASC limit 10";
            MySqlDataReader reader = comando.ExecuteReader();

            IList<string[]> retorno = new List<string[]>();
            while (reader.Read())
            {
                string[] dados = new string[3];
                dados[0] = reader.GetString(0);
                dados[1] = reader.GetString(1);
                dados[2] = reader.GetString(2);
                retorno.Add(dados);
            }
            reader.Close();
            return retorno.ToArray();
        }

        public string[][] pendentes()
        {
            MySqlCommand comando = this.con.CreateCommand();
            comando.CommandText = @"SELECT cliente.id,nome,email FROM cliente join locacao on locacao.cliente_id = cliente.id
where (locacao.pago = false or locacao.entregue = false) and email <> '' group by cliente.id";
            MySqlDataReader reader = comando.ExecuteReader();

            IList<string[]> retorno = new List<string[]>();
            while (reader.Read())
            {
                string[] dados = new string[3];
                dados[0] = reader.GetString(0);
                dados[1] = reader.GetString(1);
                dados[2] = reader.GetString(2);
                retorno.Add(dados);
            }
            reader.Close();
            return retorno.ToArray();
        }

        public string[][] todos()
        {
            MySqlCommand comando = this.con.CreateCommand();
            comando.CommandText = @"SELECT cliente.id,nome,email from cliente
where email <> '' ";
            MySqlDataReader reader = comando.ExecuteReader();

            IList<string[]> retorno = new List<string[]>();
            while (reader.Read())
            {
                string[] dados = new string[3];
                dados[0] = reader.GetString(0);
                dados[1] = reader.GetString(1);
                dados[2] = reader.GetString(2);
                retorno.Add(dados);
            }
            reader.Close();
            return retorno.ToArray();
        }

        public string[] buscarPreferencias(string id)
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
", id, id);
            MySqlDataReader reader;
            reader = comando.ExecuteReader();
            IList<string> retorno = new List<string>();
            while (reader.Read())
                retorno.Add(reader.GetString(0));
            reader.Close();
            return retorno.ToArray();
        }

    }
}
