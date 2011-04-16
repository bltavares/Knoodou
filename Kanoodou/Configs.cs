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
    public partial class Configs : Form
    {
        Banco.Config config = new Banco.Config();

        public Configs()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int valorOut;
            if (maskedTextBox1.Text == "")
            {
                MessageBox.Show("Preencha o valor de dias", "Alerta | Knoodou");
                maskedTextBox1.Focus();
            }
            else if (!int.TryParse(maskedTextBox1.Text, out valorOut))
            {
                MessageBox.Show("Preencha apenas digitos", "Alerta | Knoodou");
                maskedTextBox1.Focus();
            }
            else
            {
                config.atualizarConfigs(maskedTextBox1.Text, textBox1.Text);
                MessageBox.Show("Configurações atualizadas com sucesso", "Alerta | Knoodou");
                this.Close();
            }
            
            
        }

        private void Configs_Load(object sender, EventArgs e)
        {
            if (config.conectar())
            {
                string[][] valores = config.listarConfigs();
                textBox1.Text = valores[1][0];
                maskedTextBox1.Text = valores[0][0];
            }
            else
            {
                MessageBox.Show("Banco de dados indisponivel", "Alerta | Knoodou");
                this.Close();
            }
        }
    }
}
