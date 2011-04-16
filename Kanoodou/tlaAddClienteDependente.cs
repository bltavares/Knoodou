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
    public partial class tlaAddClienteDependente : Form
    {
        public int id = -1;
        Banco.Dependente cliente;
        public int id_Cliente = -1;


        public tlaAddClienteDependente()
        {
            InitializeComponent();
        }

        private void tlaAddClienteDependente_Load(object sender, EventArgs e)
        {
            cliente = new Banco.Dependente();

            if (!cliente.conectar())
            {
                this.Close();
                MessageBox.Show("Banco de dados indisponivel", "Alerta | Knoodou");
            }
            if (this.id > 0)
            {
                string[] valores = cliente.buscarUmDependente(this.id);
                inNome.Text = valores[0];
                dateNASC.Text = valores[1];
                inParentesco.Text = valores[2];
                inRg.Text = valores[3];
                inCpf.Text = valores[4];
                if (valores[5] == "m") radioButton1.Checked = true; else radioButton2.Checked = true;
                inEmail.Text = valores[6];
                inMsn.Text = valores[7];
                bloqueado.Checked = valores[8] != "False";
                this.Text = "Editar cliente | Knoodou";
                btOk.Text = "Atualizar";
            }
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            if (inNome.Text.Length == 0)
            {
                MessageBox.Show("Digite um nome", "Alerta | Knoodou");
                inNome.Focus();
            }
            else if (inParentesco.Text.Length == 0)
            {
                MessageBox.Show("Digite digite o grau de parentesco", "Alerta | Knoodou");
                inParentesco.Focus();
            }
            else if (!radioButton1.Checked && !radioButton2.Checked)
            {
                MessageBox.Show("Escolha um sexo", "Alerta | Knoodou");
            }
            else
            {
                string sex = radioButton1.Checked ? "m" : "f";
                string[] nasc = dateNASC.Text.Split('/');
                string dt_nasc = nasc[2] + nasc[1] + nasc[0];
                if (this.id < 0)
                {
                    //cria um novo
                    cliente.criarDependente(inNome.Text,dt_nasc, inParentesco.Text, inRg.Text, inCpf.Text, sex, inEmail.Text, inMsn.Text, bloqueado.Checked, this.id_Cliente );
                }
                else
                {
                   cliente.atualizarDependente(inNome.Text,dt_nasc, inParentesco.Text, inRg.Text, inCpf.Text, sex, inEmail.Text, inMsn.Text, bloqueado.Checked, this.id );
                }

                this.Close();
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
