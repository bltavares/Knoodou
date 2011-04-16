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
    public partial class tlaCRUDfilmes : Form
    {

        Banco.Filmes listar;
        DataSet dados;

        public tlaCRUDfilmes()
        {
            InitializeComponent();
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            tlaAddFilmes add = new tlaAddFilmes();
            add.ShowDialog();
            popularTabela();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                dataGridFilme.Rows[e.RowIndex].Selected = true;
        }

        private void popularTabela()
        {
    
            if (listar.conectar())
            {
                dados.Clear();
                listar.buscarFilmes().Fill(dados,"FILME");
                this.dataGridFilme.DataSource = dados;
                this.dataGridFilme.DataMember = "FILME";
                if (dataGridFilme.RowCount > 0)
                    dataGridFilme.Rows[0].Selected = true;
            }
            else
            {
                MessageBox.Show("Banco de dados indisponivel", "Alerta | Knoodou");
            }
        }

        private void tlaCRUDfilmes_Load(object sender, EventArgs e)
        {
            listar = new Banco.Filmes();
            if (!listar.conectar())
            {
                this.Close();
                MessageBox.Show("Banco de dados indisponivel", "Alerta | Knoodou");
            }
            else
            {
                dados = new DataSet();
                popularTabela();
            }
        }

        private void btRemover_Click(object sender, EventArgs e)
        {

            if (dataGridFilme.SelectedRows.Count == 1)
            {
                if (MessageBox.Show(this, "Tem certeza? Ação não pode ser desfeita", "Alerta | Knoodou",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    listar.remover("FILME", int.Parse(dataGridFilme["ID_filmes", dataGridFilme.CurrentRow.Index].Value.ToString()));
                }
                this.popularTabela();
            }
            else MessageBox.Show("Selecione uma linha", "Alerta | Knoodou");
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            if (dataGridFilme.SelectedRows.Count == 1)
            {
                tlaAddFilmes edit = new tlaAddFilmes();
                edit.id = int.Parse(dataGridFilme["ID_filmes", int.Parse(dataGridFilme.CurrentRow.Index.ToString())].Value.ToString());
                edit.ShowDialog();
                edit.Dispose();
                this.popularTabela();
                MessageBox.Show("Atualizado com sucesso", "Alerta | Knoodou");
            }
            else MessageBox.Show("Selecione uma linha", "Alerta | Knoodou");
        }
    }
}
