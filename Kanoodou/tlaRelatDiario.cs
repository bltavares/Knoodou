using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.IO;

namespace Knoodou
{
    public partial class tlaRelatDiario : Form
    {

        Banco.Relatorio relat = new Banco.Relatorio();
        string data;
        public string tempo;
        string[][] valores;
        public tlaRelatDiario()
        {
            InitializeComponent();
        }

        private void tlaRelatDiario_Load(object sender, EventArgs e)
        {
            if (relat.conectar())
            {
                
                if (tempo == "dia")
                {
                    data = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString();
                    string[][] valores = relat.relatorioDiario(data);
                    printar(valores);
                }
                else if (tempo == "mês")
                {
                    dateTimePicker1.Format = DateTimePickerFormat.Custom;
                    dateTimePicker1.CustomFormat = "MM";
                    dateTimePicker1.ShowUpDown = true;
                    string[][] valores = relat.relatorioMensal(DateTime.Now.Month);
                    printar(valores);
                }
                else if (tempo == "ano")
                {
                    dateTimePicker1.Format = DateTimePickerFormat.Custom;
                    dateTimePicker1.CustomFormat = "yyyy";
                    dateTimePicker1.ShowUpDown = true;
                    string[][] valores = relat.relatorioMensal(DateTime.Now.Month);
                    printar(valores);
                }
                

            }
            else
            {
                MessageBox.Show("Não foi possivel conectar ao banco de dados", "Alerta | Knoodou");
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintDialog dialogo = new PrintDialog();
            printDocument1.DocumentName = "Knoodou_Relatorio_" + dateTimePicker1.Text.Replace(' ', '_') + "_" + DateTime.Now.ToString().Replace(' ', '_');
            dialogo.Document = printDocument1;
            if (dialogo.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richTextBox1.Text, richTextBox1.Font, Brushes.Black, 50, 50);
        }

        void printar(string[][] valor)
        {
            richTextBox1.Clear();
            if (tempo == "dia")
                richTextBox1.AppendText("Sistema Knoodou - Relatório diário");
            else if (tempo == "mês")
                richTextBox1.AppendText("Sistema Knoodou - Relatório mensal");
            else if (tempo == "ano")
                richTextBox1.AppendText("Sistema Knoodou - Relatório anual");
            richTextBox1.AppendText("\n\n---Resumo para: " + dateTimePicker1.Text);
            richTextBox1.AppendText("\nQuantidade de filmes alugados: " + valor[0][0]);
            richTextBox1.AppendText("\nValor total alugado: R$ " + valor[0][1]);
            int i = 0;
            if (valor[1].Length > 0)
            {
                richTextBox1.AppendText("\n\n---Filmes mais locados no " + tempo + ":");
                foreach (string filme in valor[1])
                {
                    richTextBox1.AppendText("\n- " + (++i) + "º " + filme);
                }
            }
            if (valor[2].Length > 0)
            {
                i = 0;
                richTextBox1.AppendText("\n\n---Generos mais locados no " + tempo + ":");
                foreach (string genero in valor[2])
                {
                    richTextBox1.AppendText("\n- " + (++i) + "º " + genero);
                }
            }
            if (valor[3].Length > 0)
            {
                i = 0;
                richTextBox1.AppendText("\n\n--Midias mais locadas no " + tempo + ":");
                foreach (string midia in valor[3])
                {
                    richTextBox1.AppendText("\n- " + (++i) + "º " + midia);
                }
            }
            richTextBox1.AppendText("\n\nData: " + DateTime.Now);

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (tempo == "dia")
            {
                DateTime d = Convert.ToDateTime(dateTimePicker1.Text);
                data = d.Year.ToString() + d.Month.ToString() + d.Day.ToString().PadLeft(2, '0');
                valores =  relat.relatorioDiario(data);
            }
            else if (tempo == "mês")
            {
                int mes;
                if(int.TryParse(dateTimePicker1.Text,out mes))
                    valores = relat.relatorioMensal(mes);
                else MessageBox.Show("Digite o número do mês", "Alerta | Knoodou");
            }
            else if (tempo == "ano")
            {
                int mes;
                if (int.TryParse(dateTimePicker1.Text, out mes))
                    valores = relat.relatorioAnual(mes);
                else MessageBox.Show("Digite o número do ano", "Alerta | Knoodou");
            }
            printar(valores);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog fd = new SaveFileDialog();
            fd.AddExtension = true;
            fd.OverwritePrompt = true;
            fd.DefaultExt = "txt";
            fd.FileName = "Knoodou_Relatorio_" + dateTimePicker1.Text.Replace(' ', '_') + "_" + DateTime.Now.ToString().Replace(' ', '_');
            fd.Filter = "Arquivo de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
            fd.RestoreDirectory = true;
            fd.Title = "Escolha onde salvar o arquivo";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter fi = new StreamWriter(fd.FileName,false,Encoding.UTF8);
                foreach(string t in richTextBox1.Lines)
                fi.WriteLine(t);
                fi.Close();
                MessageBox.Show("Salvo com sucesso em " + fd.FileName, "Alerta | Knoodou");
            }
        }
    }
}
