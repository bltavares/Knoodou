using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace Knoodou.Banco
{
    class Filmes : Default
    {

        public string[] buscarUmFilme(int id)
        {
            MySqlCommand comando = this.con.CreateCommand();
            comando.CommandText = "SELECT titulo,ano,classificacao,quantidade,imdb,site,duracao,caracteristica,formato_id from FILME where ID = " + id;
            MySqlDataReader reader;
            reader = comando.ExecuteReader();
            reader.Read();

            string[] retorno = { reader.GetValue(0).ToString(), reader.GetValue(1).ToString(), reader.GetValue(2).ToString()
                                   , reader.GetValue(3).ToString() , reader.GetValue(4).ToString() , reader.GetValue(5).ToString()
                                , reader.GetValue(6).ToString() , reader.GetValue(7).ToString() , reader.GetValue(8).ToString()};

            reader.Close();
            return retorno;
        }

        public string[][] generosDoFilme(int id)
        {
            IList<string[]> lista = new List<string[]>();
            MySqlCommand comando = this.con.CreateCommand();
                comando.CommandText = "SELECT tipo,genero.id,group_concat(filme.titulo) from GENERO left join GENERO_R_FILME on GENERO.ID = GENERO_R_FILME.GENERO_ID left  join FILME on genero_r_filme.FILME_ID = FILME.ID and FILME.ID = " + id + " group by tipo";
            MySqlDataReader reader;
            reader = comando.ExecuteReader();
            while (reader.Read())
            {           
                string[] valores = { reader.GetValue(0).ToString(), reader.GetValue(1).ToString(), reader.GetValue(2).ToString() };
                lista.Add( valores );
            }

            reader.Close();
            return lista.ToArray();
        }

        public string[][] gerarGeneros()
        {
            IList<string[]> lista = new List<string[]>();
            MySqlCommand comando = this.con.CreateCommand();
            comando.CommandText = "SELECT tipo,id from GENERO";
            MySqlDataReader reader;
            reader = comando.ExecuteReader();
            while (reader.Read())
            {
                string[] valores = { reader.GetValue(0).ToString(), reader.GetValue(1).ToString() };
                lista.Add(valores);
            }

            reader.Close();
            return lista.ToArray();
        }

        public string[][] gerarFormatos()
        {
            IList<string[]> lista = new List<string[]>();
            MySqlCommand comando = this.con.CreateCommand();
            comando.CommandText = "SELECT midia,id from FORMATO";
            MySqlDataReader reader;
            reader = comando.ExecuteReader();
            while (reader.Read())
            {
                    string[] valores = { reader.GetValue(0).ToString(), reader.GetValue(1).ToString() };
                    lista.Add(valores);
            }

            reader.Close();
            return lista.ToArray();
        }

        public MySqlDataAdapter buscarFilmes()
        {
            retorno = new MySqlDataAdapter("SELECT filme.id,titulo, midia, duracao, classificacao FROM filme join FORMATO on filme.formato_id = formato.id order by titulo ASC", this.con);
            return retorno;
        }

        public void criarFilme(int formato_id, int ano, string titulo, string classificacao, int quantidade, string imdb, string url, int duracao, string caracteristica, int[] generos)
        {
            MySqlCommand comando = this.con.CreateCommand();
            comando.CommandText = string.Format("Insert into FILME VALUES (NULL,{0},{1},NOW(),'{2}','{3}',{4},'{5}','{6}',{7},'{8}');select LAST_INSERT_ID();", formato_id, ano, titulo, classificacao, quantidade, imdb, url, duracao, caracteristica);
            MySqlDataReader reader;
            reader = comando.ExecuteReader();
            reader.Read();
            int ultimoFilme = Convert.ToInt32(reader.GetValue(0).ToString());
            reader.Close();

            foreach (int genero in generos)
            {
                comando.CommandText = string.Format("Insert into GENERO_R_FILME VALUES({0},{1})", genero, ultimoFilme);
                comando.ExecuteNonQuery();
            }

        }

        public void atualizarFilme(int formato_id, int ano, string titulo, string classificacao, int quantidade, string imdb, string url, int duracao, string caracteristica, int[] generos, int id)
        {
            MySqlCommand comando = this.con.CreateCommand();
            comando.CommandText = string.Format("UPDATE FILME set formato_id = {0}, ano = {1},titulo = '{2}',classificacao = '{3}',quantidade = {4}, imdb = '{5}', site = '{6}', duracao = {7},caracteristica = '{8}' where id = {9} ;DELETE FROM GENERO_R_FILME where filme_id = {10} ;", formato_id, ano, titulo, classificacao, quantidade, imdb, url, duracao, caracteristica,id,id);
            comando.ExecuteNonQuery();
            foreach (int genero in generos)
            {
                comando.CommandText = string.Format("Insert into GENERO_R_FILME VALUES({0},{1})", genero,id);
                comando.ExecuteNonQuery();
            }

        }
    }
}