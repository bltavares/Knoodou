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
    public partial class tlaAddGenero : Form
    {

        public int id = -1;
        Banco.Genero genero;

        public tlaAddGenero()
        {
            InitializeComponent();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            if (inGenero.Text.Length < 3)
            {
                MessageBox.Show("Preencha um gênero", "Alerta | Knoodou");
                inGenero.Focus();
            }

            else
            {
                if (this.id > 0)
                {
                    genero.atualizarGenero(inGenero.Text, this.id);
                }
                else
                {
                    genero.criarGenero(inGenero.Text);
                }
                this.Close();
            }
        }

        private void tlaAddGenero_Load(object sender, EventArgs e)
        {
            genero = new Banco.Genero();

            if (!genero.conectar())
            {
                this.Close();
                MessageBox.Show("Banco de dados indisponivel", "Alerta | Knoodou");
            }
            if (this.id > 0)
            {
                this.Text = "Editar gênero | Knoodou";
                inGenero.Text = genero.buscarUmGenero(this.id);
                btOk.Text = "Atualizar";
            }
        }
    }
}
