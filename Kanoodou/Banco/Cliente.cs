using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Knoodou.Banco
{
    class Cliente : Default
    {


        public void criarCliente(string cpf, string telefone, string dt_nasc, string rg, string endereco, string nome, string sexo, string celular, string email, string msn)
        {
            MySqlCommand comando = this.con.CreateCommand();
            comando.CommandText = string.Format("Insert into CLIENTE VALUES (NULL,'{0}','{1}','{2}','{3}','{4}','{5}',now(),'{6}','{7}','{8}','{9}')", cpf, telefone, dt_nasc, rg, endereco, nome, sexo, celular, email, msn);
            comando.ExecuteNonQuery();
        }


        public void atualizarCliente(string cpf, string telefone, string dt_nasc, string rg, string endereco, string nome, string sexo, string celular, string email, string msn, int id)
        {
            MySqlCommand comando = this.con.CreateCommand();
            comando.CommandText = string.Format("UPDATE CLIENTE set cpf = '{0}', telefone = '{1}', dt_nasc ='{2}', rg = '{3}',endereco = '{4}',nome = '{5}',sexo = '{6}',celular = '{7}', email = '{8}', msn = '{9}' WHERE id = {10}", cpf, telefone, dt_nasc, rg, endereco, nome, sexo, celular, email, msn, id);
            comando.ExecuteNonQuery();
        }

        public string[] buscarUmCliente(int id)
        {
            MySqlCommand comando = this.con.CreateCommand();
            comando.CommandText = "SELECT cpf,telefone,date_format(dt_nasc, '%d/%m/%Y') as dt_nasc,rg,endereco,nome,sexo,celular,email,msn from Cliente where ID = " + id;
            MySqlDataReader reader;
            reader = comando.ExecuteReader();
            reader.Read();

            string[] retorno = { reader.GetValue(0).ToString(), reader.GetValue(1).ToString(),
            reader.GetValue(2).ToString(), reader.GetValue(3).ToString(), reader.GetValue(4).ToString(),
            reader.GetValue(5).ToString(), reader.GetValue(6).ToString(), reader.GetValue(7).ToString(),
            reader.GetValue(8).ToString(),reader.GetValue(9).ToString() };

            reader.Close();
            return retorno;
        }

        public MySqlDataAdapter buscarClientes()
        {
            retorno = new MySqlDataAdapter("SELECT nome,sexo,date_format(dt_nasc, '%d/%m/%Y') as dt_nasc,date_format(dt_cadastro, '%d/%m/%Y') as dt_cadastro,id FROM CLIENTE", this.con);
            return retorno;
        }
    }
}
