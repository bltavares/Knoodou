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
    public partial class tlaLogin : Form
    {
        bool alternative = false;
    
        public tlaLogin()
        {
            InitializeComponent();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            if (inUsuario.Text.Length > 0)
            {
                if (inSenha.Text.Length > 5)
                {
                    //Logar
                    picLoading.Visible = true;
                    btOk.Enabled = false;

                    if (alternative)
                    {
                        Banco.Default.host = inserver.Text;
                        Banco.Default.usuario = inuser.Text;
                        Banco.Default.senha = inpass.Text;
                    }

                    Banco.Usuario usuarioAuth = new Banco.Usuario();
                    if (usuarioAuth.conectar())
                    {
                        if (usuarioAuth.autenticar(inUsuario.Text, inSenha.Text))
                        {
                            tlaPrincipal tlaPrincipal = new tlaPrincipal();
                            this.Hide();
                            tlaPrincipal.user = usuarioAuth.nome;
                            tlaPrincipal.tipo = usuarioAuth.tipo;
                            tlaPrincipal.usuario = usuarioAuth.id;
                            tlaPrincipal.Show();
                        }
                        else
                        {
                            MessageBox.Show("Não autorizado", "Alerta | Knoodou");
                            btOk.Enabled = true;
                            picLoading.Visible = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Banco da dados indisponível", "Alerta | Knoodou");
                        btOk.Enabled = true;
                        picLoading.Visible = false;
                    }
                }
                else MessageBox.Show("Senha com tamanho inválido", "Alerta | Knoodou");
            }
            else MessageBox.Show("Digite um usuario", "Alerta | Knoodou");
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tlaLogin_Load(object sender, EventArgs e)
        {
            picLoading.Visible = false;
        }

        private void inUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btOk.PerformClick();
        }

        private void Con_Click(object sender, EventArgs e)
        {
            alternative = !alternative;
            if (alternative)
            {
                this.Height = 310;
                Con.Text = "Padrão";
            }
            else
            {
                this.Height = 172;
                Con.Text = "Conexão...";
                Banco.Default.host = "localhost";
                Banco.Default.usuario = "root";
                Banco.Default.senha = "root";
            }

        }
    }
}
