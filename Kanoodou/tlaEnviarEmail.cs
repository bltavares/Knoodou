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
    public partial class tlaEnviarEmail : Form
    {

        public string forma = "";
        Banco.Email db = new Banco.Email();
        Internet.Mail mailer = new Internet.Mail();

        public tlaEnviarEmail()
        {
            InitializeComponent();
        }

        private void tlaEnviarEmail_Shown(object sender, EventArgs e)
        {
            if (db.conectar())
            {

                Application.DoEvents();
                Cursor.Current = Cursors.WaitCursor;

                if (forma == "sugestTop")
                {
                    string[][] valores = db.maisAtivos();
                    foreach (string[] cliente in valores)
                    {
                        string[] sugestao = db.buscarPreferencias(cliente[0]);
                        string msg = string.Format(@"Olá {0},
estamos enviando um email para sugerir novos filmes para você.
{1}
{2}
{3}

Venha nos visitar.", cliente[1], sugestao[0], sugestao[1], sugestao[2]);

                        mailer.enviarEmail(cliente[2], "Temos sugestões para você", msg);
                    }
                }
                else if (forma == "sugestLast")
                {
                    string[][] valores = db.menosAtivos();
                    foreach (string[] cliente in valores)
                    {
                        string[] sugestao = db.buscarPreferencias(cliente[0]);
                        string msg = string.Format(@"Olá {0},
estamos enviando um email para sugerir novos filmes para você.
{1}
{2}
{3}

Venha nos visitar.", cliente[1], sugestao[0], sugestao[1], sugestao[2]);

                        mailer.enviarEmail(cliente[2], "Temos sugestões para você", msg);
                    }
                }

                else if (forma == "sugestTodos")
                {
                    string[][] valores = db.todos();
                    foreach (string[] cliente in valores)
                    {
                        string[] sugestao = db.buscarPreferencias(cliente[0]);
                        string msg = string.Format(@"Olá {0},
estamos enviando um email para sugerir novos filmes para você.
{1}
{2}
{3}

Venha nos visitar.", cliente[1], sugestao[0], sugestao[1], sugestao[2]);

                        mailer.enviarEmail(cliente[2], "Temos sugestões para você", msg);
                    }
                }

                else if (forma == "pendentes")
                {
                    string[][] valores = db.pendentes();
                    foreach (string[] cliente in valores)
                    {
                        string msg = string.Format(@"Olá {0},
estamos enviando um email para lembrar que você possui algumas pendencias na locadora.
Venha nos visitar.", cliente[1]);

                        mailer.enviarEmail(cliente[2], "Lembrete da locadora", msg);
                    }
                }

                MessageBox.Show("Enviado com sucesso", "Alerta | knoodou");

            }

            Close();
        }
    }
}
