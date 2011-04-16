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
    public partial class tlaCADcliente : Form
    {
        public int id = -1;
        Banco.Cliente listar;
        public int cliente_id = -1;

        public tlaCADcliente()
        {
            InitializeComponent();
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                tlaAddCliente add = new tlaAddCliente();
                add.ShowDialog();
                add.Dispose();
                this.popularTabelaCliente();

            }
            else
            {
                tlaAddClienteDependente add = new tlaAddClienteDependente();
                add.id_Cliente = this.cliente_id;
                add.ShowDialog();
                add.Dispose();
                this.popularTabelaDependentes(this.cliente_id);
            }
            
            
        }

        private void popularTabelaCliente()
        {
            DataSet dados = new DataSet();
            if (listar.conectar())
            {
                listar.buscarClientes().Fill(dados, "CLIENTE");
                this.dataGridCliente1.DataSource = dados;
                this.dataGridCliente1.DataMember = "CLIENTE";
                if (dataGridCliente1.RowCount > 0)
                   dataGridCliente1.Rows[0].Selected = true;
            }
            else
            {
                MessageBox.Show("Banco de dados indisponivel", "Alerta | Knoodou");
            }
        }

        private void popularTabelaDependentes(int cliente_id)
        {
            DataSet dados = new DataSet();
            Banco.Dependente depende = new Banco.Dependente();
            if (depende.conectar())
            {
                depende.buscarDependentes(this.cliente_id).Fill(dados, "DEPENDENTE");
                this.dataGridCliente2.DataSource = dados;
                this.dataGridCliente2.DataMember = "DEPENDENTE";
                if (dataGridCliente2.RowCount > 0)
                    dataGridCliente2.Rows[0].Selected = true;
            }
            else
            {
                MessageBox.Show("Banco de dados indisponivel", "Alerta | Knoodou");
            }
        }

        private void tlaCADcliente_Load(object sender, EventArgs e)
        {
            listar = new Banco.Cliente();
            this.popularTabelaCliente();
        }

        private void dataGridCliente1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                dataGridCliente1.Rows[e.RowIndex].Selected = true;
        }

        private void dataGridCliente2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                dataGridCliente2.Rows[e.RowIndex].Selected = true;
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                if (dataGridCliente1.SelectedRows.Count == 1)
                {
                    tlaAddCliente edit = new tlaAddCliente();
                    edit.id = int.Parse(dataGridCliente1["Col_id", int.Parse(dataGridCliente1.CurrentRow.Index.ToString())].Value.ToString());
                    edit.ShowDialog();
                    edit.Dispose();
                    this.popularTabelaCliente();
                    MessageBox.Show("Atualizado com sucesso", "Alerta | Knoodou");
                }
                else MessageBox.Show("Selecione uma linha", "Alerta | Knoodou");
            }
            else
            {
                if (dataGridCliente2.SelectedRows.Count == 1)
                {
                    tlaAddClienteDependente edit = new tlaAddClienteDependente();
                    edit.id = int.Parse(dataGridCliente2["Col_id2", int.Parse(dataGridCliente2.CurrentRow.Index.ToString())].Value.ToString());
                    edit.ShowDialog();
                    edit.Dispose();
                    this.popularTabelaDependentes(this.cliente_id);
                }
                else MessageBox.Show("Selecione uma linha", "Alerta | Knoodou");
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dataGridCliente1.SelectedRows.Count == 1)
            {
                label1.Text = "Adicione, remova e altere os dependentes do cliente " + dataGridCliente1["NOME", int.Parse(dataGridCliente1.CurrentRow.Index.ToString())].Value;
                this.cliente_id = int.Parse(dataGridCliente1["Col_id", int.Parse(dataGridCliente1.CurrentRow.Index.ToString())].Value.ToString());
                popularTabelaDependentes(this.cliente_id);
            }
            else tabControl1.SelectedIndex = 0;

            if (tabControl1.SelectedIndex == 0) label1.Text = "Adicione, remova e altere os clientes";
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
                if (tabControl1.SelectedIndex == 0)
                {
                    if(dataGridCliente1.SelectedRows.Count == 1)
                    {
                    if (MessageBox.Show(this, "Tem certeza? Ação não pode ser desfeita", "Alerta | Knoodou",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        listar.remover("CLIENTE", int.Parse(dataGridCliente1["Col_id", int.Parse(dataGridCliente1.CurrentRow.Index.ToString())].Value.ToString()));
                    }
                    this.popularTabelaCliente();
                    }
            else MessageBox.Show("Selecione uma linha", "Alerta | Knoodou");

                }
                else
                {
                    if(dataGridCliente2.SelectedRows.Count == 1)
                    {
                    if (MessageBox.Show(this, "Tem certeza? Ação não pode ser desfeita", "Alerta | Knoodou",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        listar.remover("DEPENDENTE", int.Parse(dataGridCliente2["Col_id2", int.Parse(dataGridCliente2.CurrentRow.Index.ToString())].Value.ToString()));
                    }
                    this.popularTabelaDependentes(this.cliente_id);
                    }
                     else MessageBox.Show("Selecione uma linha", "Alerta | Knoodou");

                }
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        }
    }

