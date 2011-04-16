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
    public partial class tlaCRUDusuarios : Form
    {

        Banco.Usuario listar;

        public tlaCRUDusuarios()
        {
            InitializeComponent();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            if (dataGridUsuarios.Rows.Count > 1 || listar.minimoAdmins())
                if (dataGridUsuarios.SelectedRows.Count == 1)
                {
                    if (MessageBox.Show(this, "Tem certeza? Ação não pode ser desfeita", "Alerta | Knoodou",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        listar.remover("USUARIO", int.Parse(dataGridUsuarios["ID", int.Parse(dataGridUsuarios.CurrentRow.Index.ToString())].Value.ToString()));
                    }
                    this.popularTabela();
                }
                else MessageBox.Show("Selecione uma linha", "Alerta | Knoodou");
            else MessageBox.Show("É preciso ao menos um administrador no sistema", "Alerta | Knoodou");
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            tlaAddUsuario add = new tlaAddUsuario();
            add.ShowDialog();
            add.Dispose();
            this.popularTabela();
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            if (dataGridUsuarios.SelectedRows.Count == 1)
            {
                tlaAddUsuario edit = new tlaAddUsuario();
                edit.id = int.Parse(dataGridUsuarios["ID", int.Parse(dataGridUsuarios.CurrentRow.Index.ToString())].Value.ToString());
                edit.ShowDialog();
                edit.Dispose();
                this.popularTabela();
                MessageBox.Show("Atualizado com sucesso", "Alerta | Knoodou");
            }
            else MessageBox.Show("Selecione uma linha", "Alerta | Knoodou");
        }

        private void tlaCRUDusuarios_Load(object sender, EventArgs e)
        {
            listar = new Banco.Usuario();
            this.popularTabela();
        }

        private void popularTabela()
        {
            DataSet dados = new DataSet();
            if (listar.conectar())
            {
                listar.buscarTudo("USUARIO").Fill(dados, "USUARIO");
                this.dataGridUsuarios.DataSource = dados;
                this.dataGridUsuarios.DataMember = "USUARIO";
                dataGridUsuarios.Rows[0].Selected = true;
            }
            else
            {
                MessageBox.Show("Banco de dados indisponivel", "Alerta | Knoodou");
            }
        }

        private void dataGridUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            dataGridUsuarios.Rows[e.RowIndex].Selected = true;
        }

        private void dataGridUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
