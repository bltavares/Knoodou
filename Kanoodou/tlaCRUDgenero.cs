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
    public partial class tlaCRUDgenero : Form
    {
        Banco.Genero listar;

        public tlaCRUDgenero()
        {
            InitializeComponent();
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            tlaAddGenero add = new tlaAddGenero();
            add.ShowDialog();
            add.Dispose();
            this.popularTabela();
        
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            if (dataGridGeneros.SelectedRows.Count == 1)
            {
                if (MessageBox.Show(this, "Tem certeza? Ação não pode ser desfeita", "Alerta | Knoodou",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    listar.remover("GENERO", int.Parse(dataGridGeneros["ID", int.Parse(dataGridGeneros.CurrentRow.Index.ToString())].Value.ToString()));
                }
                this.popularTabela();
            }
            else MessageBox.Show("Selecione uma linha");
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            if (dataGridGeneros.SelectedRows.Count == 1)
            {
                tlaAddGenero edit = new tlaAddGenero();
                edit.id = int.Parse(dataGridGeneros["ID", int.Parse(dataGridGeneros.CurrentRow.Index.ToString())].Value.ToString());
                edit.ShowDialog();
                edit.Dispose();
                this.popularTabela();
                MessageBox.Show("Atualizado com sucesso", "Alerta | Knoodou");
            }
            else MessageBox.Show("Selecione uma linha", "Alerta | Knoodou");
        }

        private void tlaCRUDgenero_Load(object sender, EventArgs e)
        {
            listar = new Banco.Genero();
            this.popularTabela();
        }

        private void popularTabela()
        {
            DataSet dados = new DataSet();
            if (listar.conectar())
            {
                listar.buscarTudo("GENERO").Fill(dados, "GENERO");
                this.dataGridGeneros.DataSource = dados;
                this.dataGridGeneros.DataMember = "GENERO";
                if(dataGridGeneros.RowCount > 0)
                    dataGridGeneros.Rows[0].Selected = true;
            }
            else
            {
                MessageBox.Show("Banco de dados indisponivel", "Alerta | Knoodou");
            }
        }

        private void dataGridGeneros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                dataGridGeneros.Rows[e.RowIndex].Selected = true;
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
