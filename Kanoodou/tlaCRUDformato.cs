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
    public partial class tlaCRUDformato : Form
    {

        Banco.Formato listar;

        public tlaCRUDformato()
        {
            InitializeComponent();
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            tlaAddFormato formato = new tlaAddFormato();
            formato.ShowDialog();
            formato.Dispose();
            this.popularTabela();
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            if (dataGridFormato.SelectedRows.Count == 1)
            {
                if (MessageBox.Show(this, "Tem certeza? Ação não pode ser desfeita", "Alerta | Knoodou",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    listar.remover("Formato", int.Parse(dataGridFormato["F_id", int.Parse(dataGridFormato.CurrentRow.Index.ToString())].Value.ToString()));
                    this.popularTabela();
                }
            }
            else MessageBox.Show("Selecione uma linha", "Alerta | Knoodou");
            
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            if (dataGridFormato.SelectedRows.Count == 1)
            {
                tlaAddFormato edit = new tlaAddFormato();
                edit.id = int.Parse(dataGridFormato["F_id", int.Parse(dataGridFormato.CurrentRow.Index.ToString())].Value.ToString());
                edit.ShowDialog();
                edit.Dispose();
                this.popularTabela();
                MessageBox.Show("Atualizado com sucesso", "Alerta | Knoodou");
            }
            else MessageBox.Show("Selecione uma linha", "Alerta | Knoodou");
        }

        private void popularTabela()
        {
            DataSet dados = new DataSet();
            if (listar.conectar())
            {
                listar.buscarFormatos().Fill(dados, "Formato");
                this.dataGridFormato.DataSource = dados;
                this.dataGridFormato.DataMember = "Formato";
                if (dataGridFormato.RowCount > 0)
                    dataGridFormato.Rows[0].Selected = true;
            }
            else
            {
                MessageBox.Show("Banco de dados indisponivel", "Alerta | Knoodou");
            }
        }

        private void tlaCRUDformato_Load(object sender, EventArgs e)
        {
            listar = new Banco.Formato();
            this.popularTabela();
        }

        private void dataGridFormato_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                dataGridFormato.Rows[e.RowIndex].Selected = true;
        }

        private void btPronto_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
