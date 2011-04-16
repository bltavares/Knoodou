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
    public partial class tlaCarrinho : Form
    {
        public DataTable carrinho = new DataTable();

        public tlaCarrinho()
        {
            InitializeComponent();
            carrinho.Columns.Add("id");
            carrinho.Columns.Add("nome");
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tlaCarrinho_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = this.carrinho;
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value);
                tlaPrincipal.nomeFilmes.RemoveAt(tlaPrincipal.filmesParaAlugar.IndexOf(id));
                tlaPrincipal.filmesParaAlugar.Remove(id);
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
