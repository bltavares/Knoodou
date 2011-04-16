using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Knoodou
{
    public partial class tlaPrincipal : Form
    {

        public string user;
        public string tipo;
        int cliente = 0;
        public int usuario;
        static public IList<int> filmesParaAlugar = new List<int>();
        static public IList<string> nomeFilmes = new List<string>();
        DataSet dados;
        Banco.Locacao loca = new Banco.Locacao();

        public tlaPrincipal()
        {
            InitializeComponent();
        }

        private void tlaPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void filmesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form tlaCrudUsuarios = new tlaCRUDusuarios();
            tlaCrudUsuarios.ShowDialog();
            goToMain();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sobre sobre = new Sobre();
            sobre.ShowDialog();
            sobre.Dispose();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tlaPrincipal_Load(object sender, EventArgs e)
        {
            if (this.tipo != "Administrador")
            {
                this.btnUsuarios.Visible = false;
                this.usuariosToolStripMenuItem.Visible = false;
                this.generosToolStripMenuItem.Visible = false;

            }
            loca.conectar();

            toolStripStatusLabel1.Text += loca.nomeLocadora() == "" ? user : ("a "+ loca.nomeLocadora() +", "+user);
            toolStripStatusLabel2.Text = "Total locado hoje: R$" + loca.faturamentoDiario();
        }

        private void Usuários_Click(object sender, EventArgs e)
        {

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            tlaCRUDusuarios usuarios = new tlaCRUDusuarios();
            usuarios.ShowDialog();
            goToMain();
        }

        private void btnFilmes_Click(object sender, EventArgs e)
        {
            tlaCRUDfilmes filmes = new tlaCRUDfilmes();
            filmes.ShowDialog();
            goToMain();
        }

        private void generosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tlaCRUDgenero generos = new tlaCRUDgenero();
            generos.ShowDialog();
            goToMain();
        }

        private void btnLocacoes_Click(object sender, EventArgs e)
        {
            if (loca.conectar())
            {
                gboxInicial.Visible = false;
                gboxCliente.Visible = true;
                panel1.Visible = false;
                filmesParaAlugar.Clear();
                nomeFilmes.Clear();
                textBox1.Clear();
                dados = new DataSet();
                loca.buscarClientes().Fill(dados, "CLIENTE");
                dataGridClientes.DataSource = dados;
                dataGridClientes.DataMember = "CLIENTE";
                arrumarTabelaCliente();

            }
            else MessageBox.Show("BD indisponivel");
        }

        private void btnIniciaLocacao_ButtonClick(object sender, EventArgs e)
        {
            if(filmesParaAlugar.Count > 0)
            {
            bool pago = MessageBox.Show("Já está pago?", "Alerta | Knoodou", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
            loca.criarLocacao(this.cliente, this.usuario, Convert.ToDouble(lblValor.Text), pago,filmesParaAlugar.ToArray());
            gboxInicial.Visible = true;
            btnIniciaLocacao.Visible = false;
            toolStripStatusLabel2.Text = "Total locado hoje: R$" + loca.faturamentoDiario();
            gboxFilmes.Visible = false;
            if (MessageBox.Show("Imprimir relatorio?", "Alerta | Knoodou", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                richTextBox1.Text = @"Sistema Knoodou - Locação de filmes

Itens ---
";
                foreach (string filme in nomeFilmes)
                {
                    richTextBox1.AppendText(filme + "\n");
                }
                richTextBox1.AppendText("-----\nValor final: " + lblValor.Text);
                richTextBox1.AppendText("\nLocado por: " + user);
                richTextBox1.AppendText("\n" + DateTime.Now.ToString());
                PrintDialog novo = new PrintDialog();
                novo.Document = printDocument1;
                if (novo.ShowDialog() == DialogResult.OK)
                    printDocument1.Print();
            }
            }
            else MessageBox.Show("Escolha ao menos um filme ou cancele a locação", "Alerta | Knoodou");

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            cliente = Convert.ToInt32(dataGridClientes["id_cli", dataGridClientes.CurrentRow.Index].Value);
            gboxCliente.Visible = false;
            gboxFilmes.Visible = true;
            btnIniciaLocacao.Visible = true;
            textBox2.Clear();
            dados = new DataSet();
            loca.buscarFilmes().Fill(dados, "Filme");
            dataGridFilmes1.DataSource = dados;
            dataGridFilmes1.DataMember = "Filme";
            arrumarTabelaFilme();
            btnIniciaLocacao.Text = "Locando para " + lblNome.Text + " (Finalizar)";
            filmesParaAlugar.Clear();
            nomeFilmes.Clear();
        }

        private void cancelarLocaçãoAtualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gboxFilmes.Visible = false;
            gboxInicial.Visible = true;
            btnIniciaLocacao.Visible = false;
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            try { dados.Tables[0].DefaultView.RowFilter = "nome LIKE '%" + textBox1.Text + "%'"; }
            catch (Exception) { };
            dataGridClientes.DataSource = dados.Tables[0];
            arrumarTabelaCliente();
            if (dataGridClientes.CurrentRow != null) dataGridClientes.CurrentRow.Selected = false;
            panel1.Visible = false;
            PessoaNotFound.Visible = dataGridClientes.Rows.Count < 1;
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {

            if (comboBox1.Text == "titulo") buscaDeFilmes();
            else if (comboBox1.Text == "generos") buscaDeGenero();
            else
            {
                try
                {
                    dados.Tables[0].DefaultView.RowFilter = comboBox1.Text + " LIKE '%" + textBox2.Text + "%'";
                }
                catch (Exception) { }
                dataGridFilmes1.DataSource = dados.Tables[0];
                dataGridFilmes1.Columns["id"].Visible = false;
            }
            arrumarTabelaFilme();
            panelDadoFilme.Visible = false;

        }
        private void btnClientes_Click(object sender, EventArgs e)
        {
            tlaCADcliente clientes = new tlaCADcliente();
            clientes.ShowDialog();
            clientes.Dispose();
            goToMain();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tlaCADcliente clientes = new tlaCADcliente();
            clientes.ShowDialog();
            clientes.Dispose();
            goToMain();
        }

        private void dataGridFilmes1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridFilmes1.Rows[e.RowIndex].Selected = true;
                int filme_id = Convert.ToInt32(dataGridFilmes1["id", e.RowIndex].Value);
                string[] valores = loca.dadosDoFilme(filme_id);

                panelDadoFilme.Visible = true;
                lblTitulo.Text = valores[0];
                lblAno.Text = valores[1];
                lblClass.Text = valores[2];
                lblIMDB.Text = valores[4];
                lblQuantidade.Text = valores[3];
                if (lblQuantidade.Text == "0")
                {
                    lblQuantidade.ForeColor = Color.DarkRed;
                    button2.Enabled = false;
                }
                else
                {
                    lblQuantidade.ForeColor = Color.Black;
                    button2.Enabled = true;
                }
                lblSite.Text = valores[5];
                lblDuracao.Text = valores[6];
                lblCaract.Text = valores[7];

                button2.Text = filmesParaAlugar.Contains(filme_id) ? "Remover este filme" : "Adicionar este filme";
                button2.Focus();
            }
        }

        private void dataGridClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                panel1.Visible = true;
                dataGridClientes.Rows[e.RowIndex].Selected = true;
                string[] valores = loca.dadosDoCliente(Convert.ToInt32(dataGridClientes["id_cli", e.RowIndex].Value));

                lblRg2.Text = valores[0];
                lblTelefone.Text = valores[1];
                lblNome.Text = valores[2];
                lblSexo.Text = valores[3];
                lblIdade.Text = valores[4];

                verificaSePode();
            }
        }

        private void filmesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            tlaCRUDfilmes filmes = new tlaCRUDfilmes();
            filmes.ShowDialog();
            goToMain();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idDoFilme = Convert.ToInt32(dataGridFilmes1["ID", dataGridFilmes1.CurrentRow.Index].Value);
            int idade = Convert.ToInt32(lblIdade.Text);
            if (idade < 10 && lblClass.Text != "Livre")
            {
                MessageBox.Show("Idade do cliente incompatível com a censura do filme","Alerta | Knoodou");
            }
            else if (idade < 12 && lblClass.Text != "Livre" && lblClass.Text != "10 anos")
            {
                MessageBox.Show("Idade do cliente incompatível com a censura do filme", "Alerta | Knoodou");
            }
            else if (idade < 14 && lblClass.Text == "14 anos" && lblClass.Text == "16 anos" && lblClass.Text == "18 anos")
            {
                MessageBox.Show("Idade do cliente incompatível com a censura do filme", "Alerta | Knoodou");
            }
            else if (idade < 16 && lblClass.Text == "16 anos" && lblClass.Text == "18 anos")
            {
                MessageBox.Show("Idade do cliente incompatível com a censura do filme", "Alerta | Knoodou");
            }
            else if (idade < 18 && lblClass.Text == "18 anos")
            {
                MessageBox.Show("Idade do cliente incompatível com a censura do filme", "Alerta | Knoodou");
            }
            else
            {
                if (!filmesParaAlugar.Contains(idDoFilme))
                {
                    nomeFilmes.Add(lblTitulo.Text);
                    filmesParaAlugar.Add(idDoFilme);
                    button2.Text = "Remover este filme";
                }
                else
                {
                    if (MessageBox.Show("Deseja remover o filme da locação atual?", "Alerta | Knoodou", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        nomeFilmes.RemoveAt(filmesParaAlugar.IndexOf(idDoFilme));
                        filmesParaAlugar.Remove(idDoFilme);
                        button2.Text = "Adicionar este filme";
                    }
                }

                lblValor.Text = string.Format("{0:0.00}", loca.valores(filmesParaAlugar.ToArray()));
            }
        }

        private void midiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tlaCRUDformato formato = new tlaCRUDformato();
            formato.ShowDialog();
            goToMain();
        }


        private void bntDevolucaoes_Click(object sender, EventArgs e)
        {
            tlaGERLoca locacao = new tlaGERLoca();
            locacao.cliente_id = Convert.ToInt32(dataGridClientes["id_cli", dataGridClientes.CurrentRow.Index].Value);
            locacao.ShowDialog();
            verificaSePode();

        }

        void verificaSePode()
        {
            if (!loca.autorizado(Convert.ToInt32(dataGridClientes["id_cli", dataGridClientes.CurrentRow.Index].Value)))
            {
                button1.Enabled = false;
                lblAlerta.Visible = true;
            }
            else
            {
                button1.Enabled = true;
                lblAlerta.Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gboxCliente.Visible = false;
            gboxInicial.Visible = true;
        }

        private void gboxInicial_VisibleChanged(object sender, EventArgs e)
        {
            loca.conectar();
            if (gboxInicial.Visible)
            {
                calculaTopFilmes();
                calculaTopGeneros();
            }
        }

        void calculaTopFilmes()
        {
            string[] valores = loca.top5();
            for (int i = 0; i < valores.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        gboxTopFilmes.Visible = true;
                        top1.Visible = true;
                        top1.Text = (i + 1) + "º - " + valores[i];
                        break;
                    case 1:
                        top2.Visible = true;
                        top2.Text = (i + 1) + "º - " + valores[i];
                        break;
                    case 2:
                        top3.Visible = true;
                        top3.Text = (i + 1) + "º - " + valores[i];
                        break;
                    case 3:
                        top4.Visible = true;
                        top4.Text = (i + 1) + "º - " + valores[i];
                        break;
                    case 4:
                        top5.Visible = true;
                        top5.Text = (i + 1) + "º - " + valores[i];
                        break;

                    default:
                        break;
                }
            }
        }

        void calculaTopGeneros()
        {
            string[] valores = loca.topGeneros();
            for (int i = 0; i < valores.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        gboxGeneros.Visible = true;
                        g1.Visible = true;
                        g1.Text = (i + 1) + "º - " + valores[i];
                        break;
                    case 1:
                        g2.Visible = true;
                        g2.Text = (i + 1) + "º - " + valores[i];
                        break;
                    case 2:
                        g3.Visible = true;
                        g3.Text = (i + 1) + "º - " + valores[i];
                        break;
                    case 3:
                        g4.Visible = true;
                        g4.Text = (i + 1) + "º - " + valores[i];
                        break;
                    case 4:
                        g5.Visible = true;
                        g5.Text = (i + 1) + "º - " + valores[i];
                        break;

                    default:
                        break;
                }
            }
        }

        private void gboxFilmes_VisibleChanged(object sender, EventArgs e)
        {
            if (gboxFilmes.Visible)
            {
                lblValor.Text = "0.00";
                calculaSugestao(cliente);
            }
        }

        void calculaSugestao(int id)
        {
            string[] valores = loca.sugestao(id);
            for (int i = 0; i < valores.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        gboxSugestoes.Visible = true;
                        s1.Visible = true;
                        s1.Text = (i + 1) + "º - " + valores[i];
                        break;
                    case 1:
                        s2.Visible = true;
                        s2.Text = (i + 1) + "º - " + valores[i];
                        break;
                    case 2:
                        s3.Visible = true;
                        s3.Text = (i + 1) + "º - " + valores[i];
                        break;
                    default:
                        break;
                }
             }
             
}

        private void g5_Click(object sender, EventArgs e)
        {

        }

        private void configuraçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Configs tlaConfig = new Configs();
            tlaConfig.ShowDialog();
            toolStripStatusLabel1.Text = "Bem vindo ";
            toolStripStatusLabel1.Text += loca.nomeLocadora() == "" ? user : ("a " + loca.nomeLocadora() + ", " + user);
            goToMain();
        }

        private void btCar_Click(object sender, EventArgs e)
        {
            tlaCarrinho carrinho = new tlaCarrinho();
            for(int i = 0; i < filmesParaAlugar.Count;i++)
            {
                string[] lista = {filmesParaAlugar.ElementAt(i).ToString(), nomeFilmes.ElementAt(i)};
                carrinho.carrinho.Rows.Add(lista);
            }
            carrinho.ShowDialog();
            dataGridFilmes1.CurrentRow.Selected = false;
            panelDadoFilme.Visible = false;
            lblValor.Text = string.Format("{0:0.00}", loca.valores(filmesParaAlugar.ToArray()) );
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richTextBox1.Text, richTextBox1.Font, Brushes.Black, 50, 50);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            textBox2.Text = linkLabel1.Text;
        }

        void buscaDeFilmes()
        {
            try
            {
                dados.Tables[0].DefaultView.RowFilter = comboBox1.Text + " LIKE '%" + textBox2.Text + "%'";
            }
            catch (Exception) { };
            dataGridFilmes1.DataSource = dados.Tables[0];
            dataGridFilmes1.Columns["id"].Visible = false;
            if (dataGridFilmes1.Rows.Count == 0)
            {
                lblFilmesNan.Visible = true;
                if (textBox2.Text.Length > 3)
                {
                    string DYM = "";
                    foreach (string busca in textBox2.Text.Split())
                    {
                        DYM = loca.susgestionTitulo(busca);
                        if (DYM != "") break;
                    }
                    if (DYM == "")
                    foreach (string busca in textBox2.Text.Split().Reverse())
                    {
                        DYM = loca.sugestionTituloRecursivo(busca);
                        if (DYM != "") break;
                    }
                    if(DYM == "")
                    foreach (string busca in textBox2.Text.Split().Reverse())
                    {
                        DYM = loca.susgestionTituloAlternado(busca,true);
                        if (DYM != "") break;
                    }
                    if (DYM != "")
                    {
                        linkLabel1.Text = DYM;
                        linkLabel1.Visible = true;
                        lblDYM.Visible = true;
                    }
                    else
                    {
                        linkLabel1.Visible = false;
                        lblDYM.Visible = false;
                    }
                }
            }
            else
            {
                lblFilmesNan.Visible = false;
                linkLabel1.Visible = false;
                lblDYM.Visible = false;
            }
        }

        void buscaDeGenero()
        {
            try
            {
                dados.Tables[0].DefaultView.RowFilter = comboBox1.Text + " LIKE '%" + textBox2.Text + "%'";
            }
            catch (Exception) { };
            dataGridFilmes1.DataSource = dados.Tables[0];
            dataGridFilmes1.Columns["id"].Visible = false;
            if (dataGridFilmes1.Rows.Count == 0)
            {
                lblFilmesNan.Visible = true;
                if (textBox2.Text.Length > 2)
                {
                    string DYM = loca.sugestionGenero(textBox2.Text);
                    if (DYM != "")
                    {
                        linkLabel1.Text = DYM;
                        linkLabel1.Visible = true;
                        lblDYM.Visible = true;
                    }
                    else
                    {
                        linkLabel1.Visible = false;
                        lblDYM.Visible = false;
                    }
                }
            }
            else
            {
                lblFilmesNan.Visible = false;
                linkLabel1.Visible = false;
                lblDYM.Visible = false;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "titulo") buscaDeFilmes();
            else if (comboBox1.Text == "generos") buscaDeGenero();
        }

        private void relatórioDiárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tlaRelatDiario relat = new tlaRelatDiario();
            relat.tempo = "dia";
            relat.ShowDialog();
        }

        private void relatórioMensalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tlaRelatDiario relat = new tlaRelatDiario();
            relat.tempo = "mês";
            relat.ShowDialog();
        }

        private void relatórioAnualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tlaRelatDiario relat = new tlaRelatDiario();
            relat.tempo = "ano";
            relat.ShowDialog();
        }

        void arrumarTabelaCliente()
        {
            dataGridClientes.Columns[3].Visible = false;
            dataGridClientes.Columns[3].Name = "id_cli";
            dataGridClientes.Columns[0].Width = 200;
            dataGridClientes.Columns[0].HeaderText = "Nome";
            dataGridClientes.Columns[1].Width = 200;
            dataGridClientes.Columns[1].HeaderText = "Sexo";
            dataGridClientes.Columns[2].HeaderText = "Data de nascimento";
            dataGridClientes.Columns[2].Width = 200;
            PessoaNotFound.Visible = false;
        }

        void arrumarTabelaFilme()
        {
            dataGridFilmes1.Columns[1].Width = 200;
            dataGridFilmes1.Columns[1].HeaderText = "Título";
            dataGridFilmes1.Columns[2].Width = 100;
            dataGridFilmes1.Columns[2].HeaderText = "Mídia";
            dataGridFilmes1.Columns[3].Width = 100;
            dataGridFilmes1.Columns[3].HeaderText = "Duração";
            dataGridFilmes1.Columns[4].Width = 200;
            dataGridFilmes1.Columns[4].HeaderText = "Gêneros";
        }

        private void dataGridClientes_CurrentCellChanged(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void dataGridFilmes1_CurrentCellChanged(object sender, EventArgs e)
        {
            panelDadoFilme.Visible = false;
        }

        void goToMain()
        {
            gboxCliente.Visible = false;
            gboxFilmes.Visible = false;
            gboxInicial.Visible = true;
            btnIniciaLocacao.Visible = false;
        }

        private void configurarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tlaConfigTwitter tw = new tlaConfigTwitter();
            tw.ShowDialog();
        }

        private void inadimplentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tlaInadimplentes inam = new tlaInadimplentes();
            inam.ShowDialog();
        }

        private void configuraçõesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tlaConfigEmail tla = new tlaConfigEmail();
            tla.ShowDialog();
        }

        private void paraOsMaisAtivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tlaEnviarEmail mail = new tlaEnviarEmail();
            mail.forma = "sugestTop";
            mail.ShowDialog();
        }

        private void paraOsMenosAtivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tlaEnviarEmail mail = new tlaEnviarEmail();
            mail.forma = "sugestLast";
            mail.ShowDialog();
        }

        private void pAraTodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Essa ação pode demorar muito. Deseja continuar?", "Alerta | Knoodou", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                tlaEnviarEmail mail = new tlaEnviarEmail();
                mail.forma = "sugestTodos";
                mail.ShowDialog();
            }
        }

        private void lEmbreteAosInadimplentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Essa ação pode demorar muito. Deseja continuar?", "Alerta | Knoodou", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                tlaEnviarEmail mail = new tlaEnviarEmail();
                mail.forma = "pendentes";
                mail.ShowDialog();
            }
        }

        private void configurarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tlaConfigFacebook fb = new tlaConfigFacebook();
            fb.ShowDialog();
        }

    }
}