using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Knoodou.Banco
{
    class Formato : Default
    {

        public void criarFormato(string midia, string lancamento, string normal)
        {
            MySqlCommand comando = this.con.CreateCommand();
            comando.CommandText = string.Format("Insert into FORMATO VALUES (NULL,'{0}','{1}','{2}')", midia, lancamento, normal);
            comando.ExecuteNonQuery();
        }


        public void atualizarFormato(string midia, string lancamento, string normal, int id)
        {
            MySqlCommand comando = this.con.CreateCommand();
            comando.CommandText = string.Format("UPDATE FORMATO set MIDIA = '{0}', preco_normal = '{1}', preco_lancamento = '{2}' WHERE id = {3}", midia, normal, lancamento, id);
            comando.ExecuteNonQuery();
        }

        public string[] buscarUmFormato(int id)
        {
            MySqlCommand comando = this.con.CreateCommand();
            comando.CommandText = "SELECT midia,preco_lancamento,preco_normal from FORMATO where ID = " + id;
            MySqlDataReader reader;
            reader = comando.ExecuteReader();
            reader.Read();

            string[] retorno = { reader.GetValue(0).ToString(), string.Format("{0:0.00}", reader.GetDouble(1)), string.Format("{0:0.00}", reader.GetDouble(2)) };

            reader.Close();
            return retorno;
        }

        public MySqlDataAdapter buscarFormatos()
        {
            MySqlDataAdapter retorno = new MySqlDataAdapter("SELECT id,midia,truncate(preco_lancamento,2) as preco_lancamento,truncate(preco_normal,2) as preco_normal from formato", this.con);
            return retorno;
        }
    }
}
