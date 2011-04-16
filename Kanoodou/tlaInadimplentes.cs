using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Knoodou
{
    public partial class tlaInadimplentes : Form
    {
        public tlaInadimplentes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog fd = new SaveFileDialog();
            fd.AddExtension = true;
            fd.OverwritePrompt = true;
            fd.DefaultExt = "txt";
            fd.FileName = "Knoodou_Relatorio_" + DateTime.Now.ToString().Replace(' ','_');
            fd.Filter = "Arquivo de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
            fd.RestoreDirectory = true;
            fd.Title = "Escolha onde salvar o arquivo";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter fi = new StreamWriter(fd.FileName, false, Encoding.UTF8);
                foreach (string t in richTextBox1.Lines)
                    fi.WriteLine(t);
                fi.Close();
                MessageBox.Show("Salvo com sucesso em " + fd.FileName, "Alerta | Knoodou");
            }
        }

        private void tlaInadimplentes_Load(object sender, EventArgs e)
        {
            Banco.Relatorio relat = new Banco.Relatorio();
            if (relat.conectar())
            {
                foreach(string[] cliente in relat.inadimplentes())
                {
                    richTextBox1.AppendText("\n\n"+cliente[0]);
                    foreach (string filme in relat.filmesComInadimplente(cliente[1]))
                        richTextBox1.AppendText("\nFilme: " + filme);
                }
                richTextBox1.AppendText("\n\nData: " + DateTime.Now.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PrintDialog dialogo = new PrintDialog();
            printDocument1.DocumentName = "Knoodou_Relatorio_" + DateTime.Now.ToString().Replace(' ', '_');
            dialogo.Document = printDocument1;
            if (dialogo.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richTextBox1.Text,richTextBox1.Font,Brushes.Black, 50, 50);
        }
    }
}
