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
    public partial class tlaAddCliente : Form
    {
        public int id = -1;
        Banco.Cliente cliente;

        public tlaAddCliente()
        {
            InitializeComponent();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            if (inNome.Text.Length == 0)
            {
                MessageBox.Show("Digite um nome", "Alerta | Knoodou");
                inNome.Focus();
            }
            else if (inRg.Text.Length == 0)
            {
                MessageBox.Show("Rg Invalido", "Alerta | Knoodou");
                inRg.Focus();
            }
            else if (inCpf.Text.Length == 0)
            {
                MessageBox.Show("Cpf Invalido", "Alerta | Knoodou");
                inCpf.Focus();
            }
            else if (!radioButton1.Checked && !radioButton2.Checked)
            {
                MessageBox.Show("Escolha um sexo", "Alerta | Knoodou");
            }
            else if (inTelefone.Text.Length == 0)
            {
                MessageBox.Show("Digite um telefone", "Alerta | Knoodou");
                inTelefone.Focus();
            }
            else
            {
                string sex = radioButton1.Checked ? "m" : "f";
                string[] nasc = dateNASC.Text.Split('/');
                string dt_nasc = nasc[2] + nasc[1] + nasc[0];
                if (this.id < 0)
                {
                    
                    //cria um novo
                    cliente.criarCliente(inCpf.Text, inTelefone.Text, dt_nasc , inRg.Text, inEndereco.Text, inNome.Text, sex, inCelular.Text, inEmail.Text, inMsn.Text);
                }
                else
                {
                    cliente.atualizarCliente(inCpf.Text, inTelefone.Text,dt_nasc, inRg.Text, inEndereco.Text, inNome.Text, sex, inCelular.Text, inEmail.Text, inMsn.Text, this.id);
                }

                this.Close();
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tlaAddCliente_Load(object sender, EventArgs e)
        {
            cliente = new Banco.Cliente();
            if (!cliente.conectar())
            {
                this.Close();
                MessageBox.Show("Banco de dados indisponivel", "Alerta | Knoodou");
            }
            if (this.id > 0)
            {
                string[] valores = cliente.buscarUmCliente(this.id);
                inCpf.Text = valores[0];
                inTelefone.Text = valores[1];
                dateNASC.Text = valores[2];
                inRg.Text = valores[3];
                inEndereco.Text = valores[4];
                inNome.Text = valores[5];
                if (valores[6] == "m") radioButton1.Checked = true; else radioButton2.Checked = true;
                inCelular.Text = valores[7];
                inEmail.Text = valores[8];
                inMsn.Text = valores[9];
                this.Text = "Editar cliente | Knoodou";
                btOk.Text = "Atualizar";
            }
        }


    }
}
