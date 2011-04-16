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
    public partial class tlaAddFormato : Form
    {
        public int id = -1;
        Banco.Formato formato;

        public tlaAddFormato()
        {
            InitializeComponent();
        }

        private void btCriar_Click(object sender, EventArgs e)
        {
            if(inNome.Text.Length == 0 )
            {
                MessageBox.Show("Digite um nome","Alerta | Knoodou");
                inNome.Focus();
            }
            else if (inLanc.Text.Length == 0)
            {
                MessageBox.Show("Digite um preço de lançamento", "Alerta | Knoodou");
                inNormal.Focus();
            }
            else if (inNormal.Text.Length == 0)
            {
                MessageBox.Show("Digite um preço normal", "Alerta | Knoodou");
                inLanc.Focus();
            }
            else
            {
                inLanc.Text = inLanc.Text.Replace(",", ".");
                inNormal.Text = inNormal.Text.Replace(",", ".");


                if (this.id < 0)
                {
                    formato.criarFormato(inNome.Text, inLanc.Text, inNormal.Text);
                }
                else
                {
                    formato.atualizarFormato(inNome.Text, inLanc.Text, inNormal.Text, this.id);
                }
                this.Close();
            }
        }

        private void tlaAddFormato_Load(object sender, EventArgs e)
        {
            formato = new Banco.Formato();
            if (!formato.conectar())
            {
                this.Close();
                MessageBox.Show("Banco de dados indisponivel", "Alerta | Knoodou");
            }
            if (this.id > 0)
            {
                this.Text = "Editar gênero | Knoodou";
                string[] valores = formato.buscarUmFormato(this.id);
                inNome.Text = valores[0];
                inLanc.Text = valores[1];
                inNormal.Text = valores[2];
                btOk.Text = "Atualizar";
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
