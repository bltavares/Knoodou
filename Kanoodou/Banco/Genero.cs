using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Knoodou.Banco
{
    class Genero : Default
    {

        public void criarGenero(string tipo)
        {
            MySqlCommand comando = this.con.CreateCommand();
            comando.CommandText = string.Format("Insert into GENERO VALUES (NULL,'{0}')", tipo);
            comando.ExecuteNonQuery();
        }


        public void atualizarGenero(string tipo, int id)
        {
            MySqlCommand comando = this.con.CreateCommand();
            comando.CommandText = string.Format("UPDATE GENERO set TIPO = '{0}' WHERE id = {1}", tipo, id);
            comando.ExecuteNonQuery();
        }

        public string buscarUmGenero(int id)
        {
            MySqlCommand comando = this.con.CreateCommand();
            comando.CommandText = "SELECT tipo from GENERO where ID = " + id;
            MySqlDataReader reader;
            reader = comando.ExecuteReader();
            reader.Read();

            string retorno = reader.GetValue(0).ToString();

            reader.Close();
            return retorno;
        }
    }
}
