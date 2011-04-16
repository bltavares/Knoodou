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
    public partial class tlaAddFilmes : Form
    {
        Banco.Filmes filmes;
        public int id = -1;
        IList<int> ids = new List<int>();
        IList<int> formatos = new List<int>();

        public tlaAddFilmes()
        {
            InitializeComponent();
        }

        private void tlaAddFilmes_Load(object sender, EventArgs e)
        {
            filmes = new Banco.Filmes();

            if (!filmes.conectar())
            {
                this.Close();
            }
            else
            {
                foreach (string[] formato in filmes.gerarFormatos())
                {
                    comboFormato.Items.Add(formato[0]);
                    formatos.Add(Convert.ToInt32(formato[1]));
                }
                if (id < 0)

                    foreach (string[] genero in filmes.gerarGeneros())
                    {
                        checkedListBox1.Items.Add(genero[0]);
                        ids.Add(Convert.ToInt32(genero[1]));
                    }

                else
                {
                    foreach (string[] genero in filmes.generosDoFilme(this.id))
                    {
                        checkedListBox1.Items.Add(genero[0], genero[2] != "");
                        ids.Add(Convert.ToInt32(genero[1]));
                    }
                    string[] valores = filmes.buscarUmFilme(this.id);
                    inTitulo.Text = valores[0];
                    inAno.Text = valores[1];
                    comboClass.SelectedItem = valores[2];
                    inQuantidade.Text = valores[3];
                    inIMDB.Text = valores[4];
                    inURL.Text = valores[5];
                    inDuracao.Text = valores[6];
                    comboCaract.SelectedText = valores[7];
                    comboFormato.SelectedIndex = formatos.IndexOf(Convert.ToInt32(valores[8]));
                }
                
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            if (inTitulo.Text == "")
            {
                MessageBox.Show("Digite um título", "Alerta | Knoodou");
                inTitulo.Focus();
            }
            else if (inAno.Text.Length != 4)
            {
                MessageBox.Show("Digite o ano de lançamento", "Alerta | Knoodou");
                inAno.Focus();
            }
            else if (comboClass.Text == "")
            {
                MessageBox.Show("Escolha uma classificação", "Alerta | Knoodou");
                comboClass.Focus();

            }
            else if (inDuracao.Text == "")
            {
                MessageBox.Show("Digite a duração do filme");
                inDuracao.Focus();
            }
            else if (checkedListBox1.CheckedItems.Count < 1)
            {
                MessageBox.Show("Escolha ao menos um gênero", "Alerta | Knoodou");
            }
            else if (comboFormato.Text == "")
            {
                MessageBox.Show("Escolha um formato");
                comboFormato.Focus();
            }
            else
            {
                IList<int> listadegeneros = new List<int>();
                foreach (int gen in checkedListBox1.CheckedIndices)
                    listadegeneros.Add(ids[gen]);
                             
                if (this.id < 0)
                {
                    filmes.criarFilme(formatos[comboFormato.SelectedIndex], Convert.ToInt32(inAno.Text), inTitulo.Text,
                        comboClass.Text, Convert.ToInt32(inQuantidade.Text), inIMDB.Text, inURL.Text, Convert.ToInt32(inDuracao.Text),
                        comboCaract.Text, listadegeneros.ToArray<int>() );
                    //Twitter
                    
                    Banco.Config config = new Banco.Config();
                    config.conectar();
                    if (config.twitterToken()[0] != "")
                    {
                        Internet.Twitter tw = new Internet.Twitter();
                        if(inTitulo.Text.Length > 128)
                            tw.novaMensagem("Novo filme: " + inTitulo.Text.Substring(0,125) + "...");
                        else
                            tw.novaMensagem("Novo filme: " + inTitulo.Text);
                    }
                    //facebook
                    if (config.buscarFacebookToken()[0] != "")
                    {
                        Internet.Facebook fb = new Internet.Facebook();
                        fb.postarNoFB("Novo filme: " + inTitulo.Text);
                    }

                }
                else
                {
                    filmes.atualizarFilme(formatos[comboFormato.SelectedIndex], Convert.ToInt32(inAno.Text), inTitulo.Text,
                        comboClass.Text, Convert.ToInt32(inQuantidade.Text), inIMDB.Text, inURL.Text, Convert.ToInt32(inDuracao.Text),
                        comboCaract.Text, listadegeneros.ToArray<int>(), this.id);
                }
                this.Close();
            }
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tlaCRUDgenero generos = new tlaCRUDgenero();
            generos.ShowDialog();

            ids.Clear();
            checkedListBox1.Items.Clear();

            if (id < 0)

                foreach (string[] genero in filmes.gerarGeneros())
                {
                    checkedListBox1.Items.Add(genero[0]);
                    ids.Add(Convert.ToInt32(genero[1]));
                }

            else
                foreach (string[] genero in filmes.generosDoFilme(this.id))
                {
                    checkedListBox1.Items.Add(genero[0], genero[2] != "");
                    ids.Add(Convert.ToInt32(genero[1]));
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tlaCRUDformato midia = new tlaCRUDformato();
            midia.ShowDialog();
            
            formatos.Clear();
            comboFormato.Items.Clear();

            foreach (string[] formato in filmes.gerarFormatos())
            {
                comboFormato.Items.Add(formato[0]);
                formatos.Add(Convert.ToInt32(formato[1]));
            }

        }

        private void inTitulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboCaract_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboClass_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void inQuantidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblQuantidade_Click(object sender, EventArgs e)
        {

        }

        private void lblCaracteristica_Click(object sender, EventArgs e)
        {

        }

        private void inDuracao_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDuracao_Click(object sender, EventArgs e)
        {

        }

        private void inURL_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSite_Click(object sender, EventArgs e)
        {

        }

        private void inIMDB_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblIMDB_Click(object sender, EventArgs e)
        {

        }

        private void lblClasificacao_Click(object sender, EventArgs e)
        {

        }

        private void lblAno_Click(object sender, EventArgs e)
        {

        }

        private void inAno_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}
