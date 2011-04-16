namespace Knoodou
{
    partial class tlaCADcliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tlaCADcliente));
            this.btAtualizar = new System.Windows.Forms.Button();
            this.btRemover = new System.Windows.Forms.Button();
            this.btAdicionar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btOk = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Cliente = new System.Windows.Forms.TabPage();
            this.dataGridCliente1 = new System.Windows.Forms.DataGridView();
            this.NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DT_NASC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DT_CADASTRO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridCliente2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_id2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.Cliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCliente1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCliente2)).BeginInit();
            this.SuspendLayout();
            // 
            // btAtualizar
            // 
            this.btAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("btAtualizar.Image")));
            this.btAtualizar.Location = new System.Drawing.Point(182, 343);
            this.btAtualizar.Name = "btAtualizar";
            this.btAtualizar.Size = new System.Drawing.Size(75, 50);
            this.btAtualizar.TabIndex = 13;
            this.btAtualizar.Text = "Atualizar";
            this.btAtualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btAtualizar.UseVisualStyleBackColor = true;
            this.btAtualizar.Click += new System.EventHandler(this.btAtualizar_Click);
            // 
            // btRemover
            // 
            this.btRemover.Image = ((System.Drawing.Image)(resources.GetObject("btRemover.Image")));
            this.btRemover.Location = new System.Drawing.Point(101, 343);
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(75, 50);
            this.btRemover.TabIndex = 12;
            this.btRemover.Text = "Remover";
            this.btRemover.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btRemover.UseVisualStyleBackColor = true;
            this.btRemover.Click += new System.EventHandler(this.btRemover_Click);
            // 
            // btAdicionar
            // 
            this.btAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("btAdicionar.Image")));
            this.btAdicionar.Location = new System.Drawing.Point(20, 343);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(75, 50);
            this.btAdicionar.TabIndex = 11;
            this.btAdicionar.Text = "Adicionar";
            this.btAdicionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btAdicionar.UseVisualStyleBackColor = true;
            this.btAdicionar.Click += new System.EventHandler(this.btAdicionar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Adicione, remova e altere os clientes.";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(16, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(227, 25);
            this.lblTitulo.TabIndex = 9;
            this.lblTitulo.Text = "Controle de Clientes";
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(385, 355);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 23);
            this.btOk.TabIndex = 8;
            this.btOk.Text = "Pronto!";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Cliente);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(20, 67);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(499, 232);
            this.tabControl1.TabIndex = 14;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // Cliente
            // 
            this.Cliente.Controls.Add(this.dataGridCliente1);
            this.Cliente.Location = new System.Drawing.Point(4, 22);
            this.Cliente.Name = "Cliente";
            this.Cliente.Padding = new System.Windows.Forms.Padding(3);
            this.Cliente.Size = new System.Drawing.Size(491, 206);
            this.Cliente.TabIndex = 0;
            this.Cliente.Text = "Cliente";
            this.Cliente.UseVisualStyleBackColor = true;
            // 
            // dataGridCliente1
            // 
            this.dataGridCliente1.AllowUserToAddRows = false;
            this.dataGridCliente1.AllowUserToDeleteRows = false;
            this.dataGridCliente1.AllowUserToResizeRows = false;
            this.dataGridCliente1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridCliente1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridCliente1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridCliente1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridCliente1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCliente1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NOME,
            this.Col_id,
            this.Sexo,
            this.DT_NASC,
            this.DT_CADASTRO});
            this.dataGridCliente1.Location = new System.Drawing.Point(-4, 0);
            this.dataGridCliente1.MultiSelect = false;
            this.dataGridCliente1.Name = "dataGridCliente1";
            this.dataGridCliente1.ReadOnly = true;
            this.dataGridCliente1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridCliente1.RowHeadersVisible = false;
            this.dataGridCliente1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridCliente1.ShowEditingIcon = false;
            this.dataGridCliente1.Size = new System.Drawing.Size(499, 210);
            this.dataGridCliente1.TabIndex = 1;
            this.dataGridCliente1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCliente1_CellContentClick);
            // 
            // NOME
            // 
            this.NOME.DataPropertyName = "NOME";
            this.NOME.HeaderText = "Nome";
            this.NOME.MinimumWidth = 180;
            this.NOME.Name = "NOME";
            this.NOME.ReadOnly = true;
            this.NOME.Width = 180;
            // 
            // Col_id
            // 
            this.Col_id.DataPropertyName = "ID";
            this.Col_id.HeaderText = "ID";
            this.Col_id.Name = "Col_id";
            this.Col_id.ReadOnly = true;
            this.Col_id.Visible = false;
            // 
            // Sexo
            // 
            this.Sexo.DataPropertyName = "SEXO";
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            this.Sexo.ReadOnly = true;
            this.Sexo.Width = 65;
            // 
            // DT_NASC
            // 
            this.DT_NASC.DataPropertyName = "DT_NASC";
            this.DT_NASC.HeaderText = "Data de nascimento";
            this.DT_NASC.Name = "DT_NASC";
            this.DT_NASC.ReadOnly = true;
            this.DT_NASC.Width = 150;
            // 
            // DT_CADASTRO
            // 
            this.DT_CADASTRO.DataPropertyName = "DT_CADASTRO";
            this.DT_CADASTRO.HeaderText = "Data de cadastro";
            this.DT_CADASTRO.Name = "DT_CADASTRO";
            this.DT_CADASTRO.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridCliente2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(491, 206);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Dependente";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridCliente2
            // 
            this.dataGridCliente2.AllowUserToAddRows = false;
            this.dataGridCliente2.AllowUserToDeleteRows = false;
            this.dataGridCliente2.AllowUserToResizeRows = false;
            this.dataGridCliente2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridCliente2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridCliente2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridCliente2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridCliente2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCliente2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.Col_id2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataGridCliente2.Location = new System.Drawing.Point(-2, 2);
            this.dataGridCliente2.MultiSelect = false;
            this.dataGridCliente2.Name = "dataGridCliente2";
            this.dataGridCliente2.ReadOnly = true;
            this.dataGridCliente2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridCliente2.RowHeadersVisible = false;
            this.dataGridCliente2.ShowEditingIcon = false;
            this.dataGridCliente2.Size = new System.Drawing.Size(495, 203);
            this.dataGridCliente2.TabIndex = 2;
            this.dataGridCliente2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCliente2_CellContentClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NOME";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 280;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 280;
            // 
            // Col_id2
            // 
            this.Col_id2.DataPropertyName = "ID";
            this.Col_id2.HeaderText = "ID";
            this.Col_id2.Name = "Col_id2";
            this.Col_id2.ReadOnly = true;
            this.Col_id2.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "SEXO";
            this.dataGridViewTextBoxColumn4.HeaderText = "Sexo";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 65;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DT_NASC";
            this.dataGridViewTextBoxColumn5.HeaderText = "Data de nascimento";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // tlaCADcliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 405);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btAtualizar);
            this.Controls.Add(this.btRemover);
            this.Controls.Add(this.btAdicionar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btOk);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "tlaCADcliente";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de clientes | Knoodou";
            this.Load += new System.EventHandler(this.tlaCADcliente_Load);
            this.tabControl1.ResumeLayout(false);
            this.Cliente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCliente1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCliente2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAtualizar;
        private System.Windows.Forms.Button btRemover;
        private System.Windows.Forms.Button btAdicionar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Cliente;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridCliente1;
        private System.Windows.Forms.DataGridView dataGridCliente2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DT_NASC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DT_CADASTRO;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_id2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;

        public System.Windows.Forms.DataGridViewCellEventHandler dataGridCliente2_CellContentClick_1 { get; set; }
    }
}