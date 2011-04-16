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
    public partial class tlaGERLoca : Form
    {

        public int cliente_id;
        int loca_id;
        Banco.Locacao loca = new Banco.Locacao();


        public tlaGERLoca()
        {
            InitializeComponent();
        }

        private void tlaGERLoca_Load(object sender, EventArgs e)
        {
            if (loca.conectar())
            {
                DataSet dados = new DataSet();
                loca.buscarLocacoes(cliente_id).Fill(dados, "LOCACAO");
                dataGridView1.DataSource = dados;
                dataGridView1.DataMember = "LOCACAO";
                dataGridView1.Rows[0].Selected = false;
            }
        }

        void popularDados(int id)
        {
            string[] valores = loca.dadosLocacao(id);
                lblValorFinal.Text = "R$ " + valores[0];
                lblDataEntrega.Text = valores[1];
                lblLocador.Text = valores[2];
            lblDataLoca.Text = valores[3];
            lblDifer.Text = valores[4];
            bool[] checks = loca.pendencias(id);
            checkBox1.Checked = checks[0];
            checkBox2.Checked = checks[1];
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                groupBox1.Visible = true;
                dataGridView1.Rows[e.RowIndex].Selected = true;
                loca_id = Convert.ToInt32(dataGridView1["ID_loc",dataGridView1.CurrentRow.Index].Value);
                popularDados(loca_id);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loca.atualizarLocacao(checkBox1.Checked, checkBox2.Checked, loca_id);
            MessageBox.Show("Atualizado estado da locação", "Alerta | Knoodou");
        }

        private void lblValorFinal_Click(object sender, EventArgs e)
        {

        }
    }
}
