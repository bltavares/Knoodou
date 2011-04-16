using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Knoodou
{
    public partial class tlaConfigEmail : Form
    {
        int speed = 20;
        Banco.Config conf = new Banco.Config();

        public tlaConfigEmail()
        {
            InitializeComponent();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            Regex re = new Regex("@gmail.com");
            if (re.Match(inEmail.Text).Success)
            {
                while (this.Height > 180)
                {
                    this.Height -= speed;
                    Application.DoEvents();
                }
                inServ.Text = "smtp.gmail.com";
                inPort.Text = "587";
                chkTLS.Checked = true;

            }
            else
            {
                while (this.Height < 280)
                {
                    this.Height += speed;
                    Application.DoEvents();
                }
                inServ.Text = "";
                inPort.Text = "";
                chkTLS.Checked = false;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int z;
            if (inEmail.Text == "")
            {
                MessageBox.Show("Preencha um email", "Alerta | Knoodou");
                inEmail.Focus();
            }
            else if (inSenha.Text == "")
            {
                MessageBox.Show("Preencha a senha do email", "Alerta | Knoodou");
                inSenha.Focus();
            }
            else if (inServ.Text == "")
            {
                MessageBox.Show("Preecha o servidor SMTP", "Alerta | Knoodou");
                inServ.Focus();
            }
            else if (inPort.Text == "")
            {
                MessageBox.Show("Preencha a porta", "Alerta| knoodou");
                inSenha.Focus();
            }
            else if (!int.TryParse(inPort.Text, out z))
            {
                MessageBox.Show("Digite apenas digitos na porta", "Alerta | knoodou");
                inSenha.Focus();
            }
            else
            {
                
                string tsl = chkTLS.Checked? "TLS" : "sem-tls";
                conf.salvarEmail(inEmail.Text, inSenha.Text, inServ.Text, inPort.Text, tsl);
                MessageBox.Show("Salvo com sucesso", "Alerta | knoodou");
                this.Close();

            }
            

        }

        private void tlaConfigEmail_Load(object sender, EventArgs e)
        {
            if (conf.conectar())
            {
                string[] valores = conf.buscarEmail();
                if(valores[0] != "")
                {
                    inEmail.Text = valores[0];
                    inSenha.Text = valores[1];
                    inServ.Text = valores[2];
                    inPort.Text = valores[3];
                    chkTLS.Checked = valores[4] == "TLS";
                }
            }
            else
            {
                MessageBox.Show("Banco de dados indisponível", "Alerta | Knoodou");
                this.Close();
            }
        }
    }
}
