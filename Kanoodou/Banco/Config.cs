using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace Knoodou.Banco
{
    class Config : Default
    {
        public string[][] listarConfigs()
        {
            MySqlCommand comando = this.con.CreateCommand();
            comando.CommandText = "SELECT valor,chave from configuracoes";
            MySqlDataReader reader;
            reader = comando.ExecuteReader();

            IList<string[]> retorno = new List<string[]>();

            while(reader.Read())
            {
                string[] subs = {reader.GetString(0),reader.GetString(1)};
                retorno.Add(subs);
            }
            reader.Close();
            return retorno.ToArray();
        }

        public void atualizarConfigs(string data, string nome)
        {
            MySqlCommand comando = this.con.CreateCommand();
            comando.CommandText = "UPDATE configuracoes set valor = '"+ data+"' where chave = 'tempo_lancamento' ";
            comando.ExecuteNonQuery();
            comando.CommandText = "UPDATE configuracoes set valor = '" + nome + "' where chave = 'nome_locadora' ";
            comando.ExecuteNonQuery();
        }

        public void salvarTwitter(string token,string secret)
        {
            MySqlCommand comando = this.con.CreateCommand();
            comando.CommandText = "UPDATE configuracoes set valor = '" + token + "' where chave = 'twitter_accesstoken' ";
            comando.ExecuteNonQuery();
            comando.CommandText = "UPDATE configuracoes set valor = '" + secret + "' where chave = 'twitter_accesssecret' ";
            comando.ExecuteNonQuery();
        }

        public string[] twitterToken()
        {
            MySqlCommand comando = this.con.CreateCommand();
            comando.CommandText = "SELECT valor,chave from configuracoes where chave = 'twitter_accesstoken' or chave = 'twitter_accesssecret'";
            MySqlDataReader reader;
            reader = comando.ExecuteReader();
            string[] retorno = new string[2];
            int i = 0;
             while (reader.Read())
            {
                retorno[i++] = reader.IsDBNull(0) ? "" : reader.GetString(0);
            }
            reader.Close();
            return retorno;
        }

        public void salvarEmail(string email, string senha, string servidor, string porta, string tls)
        {
            string serial = email + ";" + senha + ";" + servidor + ";" + porta + ";" + tls;
            
            MySqlCommand comando = this.con.CreateCommand();
            comando.CommandText = "UPDATE configuracoes SET valor = '" + serial + "' WHERE chave = 'email_config'";
            comando.ExecuteNonQuery();
        }

        public string[] buscarEmail()
        {
            MySqlCommand comando = this.con.CreateCommand();
            comando.CommandText = "SELECT valor from configuracoes where chave = 'email_config'";
            MySqlDataReader reader;
            reader = comando.ExecuteReader();
            reader.Read();
            string retorno = reader.IsDBNull(0) ? ";;" : reader.GetString(0);
            reader.Close();
            return retorno.Split(';');
        }

        public void salvarFacebookConfig(string acesstoken,string limit)
        {
            MySqlCommand comando = this.con.CreateCommand();
            comando.CommandText = "UPDATE configuracoes SET valor = '" + toBase64(acesstoken) + "' WHERE chave = 'facebook_accesstoken'";
            comando.ExecuteNonQuery();
            comando.CommandText = "UPDATE configuracoes SET valor = '" + limit + "' WHERE chave = 'facebook_limit'";
            comando.ExecuteNonQuery();
        }

        public string[] buscarFacebookToken()
        {
            MySqlCommand comando = this.con.CreateCommand();
            comando.CommandText = "SELECT valor from configuracoes where chave = 'facebook_accesstoken'";
            MySqlDataReader reader;
            reader = comando.ExecuteReader();
            string[] retorno = new string[2];
            reader.Read();
            retorno[0] = reader.IsDBNull(0) ? "" : fromBase64(reader.GetString(0));
            reader.Close();

            comando.CommandText = "SELECT valor from configuracoes where chave = 'facebook_limit'";
            reader = comando.ExecuteReader();
            reader.Read();
            retorno[1] = reader.IsDBNull(0) ? "" : reader.GetString(0);
            reader.Close();
            return retorno;
        }


        public string toBase64(string entrada)
        {
            byte[] bytearr = System.Text.Encoding.UTF8.GetBytes(entrada);
            return Convert.ToBase64String(bytearr);
        }

        public string fromBase64(string entrada)
        {
           byte[] bytearr =  Convert.FromBase64String(entrada);
           return System.Text.Encoding.UTF8.GetString(bytearr);
        }
    }
}
