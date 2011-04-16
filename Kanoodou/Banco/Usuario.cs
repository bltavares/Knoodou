using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Knoodou.Banco
{
    class Usuario : Default
    {

        public string tipo;
        public string nome;
        public int id;

        public bool autenticar(string login, string senha)
        {
            MySqlCommand comando = this.con.CreateCommand();
            comando.CommandText = "SELECT senha,nome,tipo,id FROM USUARIO where login ='" + login + "' LIMIT 1";
            MySqlDataReader leitor;
            leitor = comando.ExecuteReader();
            if (leitor.Read())
            {
                this.tipo = leitor.GetValue(2).ToString();
                this.nome = leitor.GetValue(1).ToString();
                bool retorno = senha == leitor.GetValue(0).ToString();
                this.id = leitor.GetInt32(3);
                leitor.Close();
                return retorno;
            }
            else return false;
        }

        public void criarUsuario(string nome, string login, string senha, string tipo)
        {
            MySqlCommand comando = this.con.CreateCommand();
            comando.CommandText = string.Format("Insert into USUARIO VALUES (NULL,'{0}','{1}','{2}','{3}')", nome, senha, tipo, login);
            comando.ExecuteNonQuery();
        }


        public void atualizarUsuario(string nome, string login, string senha, string tipo, int id)
        {
            MySqlCommand comando = this.con.CreateCommand();
            comando.CommandText = string.Format("UPDATE USUARIO set nome = '{0}', senha = '{1}', tipo='{2}',login = '{3}' WHERE id = {4}", nome, senha, tipo, login, id);
            comando.ExecuteNonQuery();
        }

        public string[] buscarUmUsuario(int id)
        {
            MySqlCommand comando = this.con.CreateCommand();
            comando.CommandText = "SELECT nome,login,tipo from USUARIO where ID = " + id;
            MySqlDataReader reader;
            reader = comando.ExecuteReader();
            reader.Read();

            string[] retorno = { reader.GetValue(0).ToString(), reader.GetValue(1).ToString(), reader.GetValue(2).ToString() };

            reader.Close();
            return retorno;
        }

        internal bool minimoAdmins()
        {
            MySqlCommand comando = this.con.CreateCommand();
            comando.CommandText = "SELECT count(*) from USUARIO where TIPO = 'Administrador'";
            MySqlDataReader reader;
            reader = comando.ExecuteReader();
            reader.Read();

            bool retorno = (reader.GetInt32(0) > 1);

            reader.Close();
            return retorno;
        }
    }
}
