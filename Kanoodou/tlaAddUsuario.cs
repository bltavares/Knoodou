using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Knoodou
{
    public partial class tlaAddUsuario : Form
    {
        public int id = -1;
        Banco.Usuario usuario;

        public tlaAddUsuario()
        {
            InitializeComponent();
        }

        private void tlaAddUsuario_Load(object sender, EventArgs e)
        {

            this.usuario = new Banco.Usuario();
            if (!usuario.conectar())
            {
                this.Close();
                MessageBox.Show("Banco de dados indisponivel", "Alerta | Knoodou");
            }

            if (id >= 0)
            {
                btOk.Text = "Atualizar";
                this.Text = "Editar usuário | Knoodou";
                string[] infos = usuario.buscarUmUsuario(id);
                inNome.Text = infos[0];
                inUsuario.Text = infos[1];
                radioAdministrador.Checked = infos[2] == "Administrador";
            }

        }

        private void btOk_Click(object sender, EventArgs e)
        {
            if (inNome.Text.Length == 0)
            {
                MessageBox.Show("Digite um nome", "Alerta | Knoodou");
                inNome.Focus();
            }
            else if (inUsuario.Text.Length == 0)
	        {
                MessageBox.Show("Digite um usuário", "Alerta | Knoodou");
                inUsuario.Focus();		 
	        }
            else if (inUsuario.Text == inNome.Text)
            {
                MessageBox.Show("Nome e usuário não podem ser o mesmo", "Alerta | Knoodou");
                inUsuario.Focus();
            }
            else if (inSenha.Text.Length == 0)
            {
                MessageBox.Show("Digite uma senha", "Alerta | Knoodou");
                inSenha.Focus();
            }
            else if (inSenha.Text.Length < 6)
            {
                MessageBox.Show("Senha muito curta", "Alerta | Knoodou");
                inSenha.Focus();
            }
            else if (inConfsenha.Text != inSenha.Text)
            {
                MessageBox.Show("A senha não foi confirmada! Tente outra vez!");
                inConfsenha.Focus();
            }

            else
            {

                string tipo = radioAdministrador.Checked ? "Administrador" : "Normal";

                if (this.id < 0)
                {
                    //cria um novo
                    usuario.criarUsuario(inNome.Text, inUsuario.Text, inSenha.Text, tipo);
                }
                else
                {
                    usuario.atualizarUsuario(inNome.Text, inUsuario.Text, inSenha.Text, tipo,this.id);
                }

                this.Close();
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void inSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void inConfsenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void inNome_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
