using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Knoodou.Banco
{
    class Dependente : Default
    {


        public void criarDependente(string nome,string dt_nasc, string parentesco, string Rg, string Cpf, string Sexo, string email, string Msn, bool bloqueado, int id_Cliente)
        {
            MySqlCommand comando = this.con.CreateCommand();
            comando.CommandText = string.Format("Insert into DEPENDENTE VALUES (NULL,'{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}',{8}, {9} )", nome,dt_nasc, parentesco, Rg, Cpf, Sexo, email, Msn, bloqueado, id_Cliente);
            comando.ExecuteNonQuery();
        }


        public void atualizarDependente(string nome,string dt_nasc, string parentesco, string Rg, string Cpf, string Sexo, string email, string Msn, bool bloqueado, int id)
        {
            MySqlCommand comando = this.con.CreateCommand();
            comando.CommandText = string.Format("UPDATE DEPENDENTE set nome = '{0}',dt_nasc= '{1}', parentesco = '{2}', Rg='{3}',Cpf = '{4}',Sexo = '{5}',email = '{6}',msn = '{7}',bloqueado = {8} WHERE id = {9}", nome,dt_nasc, parentesco, Rg, Cpf, Sexo, email, Msn, bloqueado, id);
            comando.ExecuteNonQuery();
        }

        public string[] buscarUmDependente(int id)
        {
            MySqlCommand comando = this.con.CreateCommand();
            comando.CommandText = "SELECT nome,date_format(dt_nasc, '%d/%m/%Y') as dt_nasc,parentesco,Rg,Cpf,sexo,email,msn,bloqueado from dependente where ID = " + id;
            MySqlDataReader reader;
            reader = comando.ExecuteReader();
            reader.Read();

            string[] retorno = { reader.GetValue(0).ToString(), reader.GetValue(1).ToString(), reader.GetValue(2).ToString(), reader.GetValue(3).ToString(), reader.GetValue(4).ToString(), reader.GetValue(5).ToString(), reader.GetValue(6).ToString(), reader.GetValue(7).ToString(), reader.GetValue(8).ToString() };

            reader.Close();
            return retorno;
        }

        public MySqlDataAdapter buscarDependentes(int cliente_id)
        {
            retorno = new MySqlDataAdapter("SELECT nome,sexo,dt_nasc,id FROM DEPENDENTE WHERE CLIENTE_ID = "+ cliente_id, this.con);
            return retorno;
        }
    }
}
