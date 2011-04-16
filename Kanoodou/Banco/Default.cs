using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Knoodou.Banco
{
    class Default
    {
        protected MySqlConnection con;
        protected MySqlDataAdapter retorno;
        
        string ConectionString;

        public static string host = "localhost";
        public static string usuario = "root";
        public static string senha = "root";
        public static string banco = "knoodou_estudo";

        void criarCS()
        {
            
            MySqlConnectionStringBuilder c = new MySqlConnectionStringBuilder();
            c.Server = host;
            c.UserID = usuario;
            c.Password = senha;
            c.Database = banco;
            c.PersistSecurityInfo = true;
            this.ConectionString = c.ConnectionString;
        }

        public bool conectar()
        {
            this.criarCS();
            con = new MySqlConnection(this.ConectionString);
            try { con.Open(); }
            catch (Exception) { return false; };

            if (con.State == System.Data.ConnectionState.Open)
            {
                return true;
            }
                return false;
        }

        //Buscar todos
        public MySqlDataAdapter buscarTudo(string tabela)
        {
            retorno = new MySqlDataAdapter("SELECT * FROM " + tabela, this.con);
            return retorno;
        }

        public void atualizar(string tabela,string valores, int id)
        {
            MySqlCommand comando = new MySqlCommand( "UPDATE " + tabela + "SET" + valores + "WHERE id=" + id ,con );
            comando.ExecuteNonQuery();
        }

        public void remover(string tabela, int id)
        {
            MySqlCommand comando = new MySqlCommand("DELETE from " + tabela + " WHERE id=" + id, con);
            comando.ExecuteNonQuery();
        }

        ~Default() 
        {
            if(this.con.State == System.Data.ConnectionState.Open)
            this.con.Close();
        }

    }
}
