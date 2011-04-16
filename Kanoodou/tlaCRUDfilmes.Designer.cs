namespace Knoodou
{
    partial class tlaCRUDfilmes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tlaCRUDfilmes));
            this.btAtualizar = new System.Windows.Forms.Button();
            this.btRemover = new System.Windows.Forms.Button();
            this.btAdicionar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btOk = new System.Windows.Forms.Button();
            this.dataGridFilme = new System.Windows.Forms.DataGridView();
            this.TITULO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Formato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLASSIFICACAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DURACAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_filmes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFilme)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(173, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Adicione, remova e altere os filmes.";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(16, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(210, 25);
            this.lblTitulo.TabIndex = 9;
            this.lblTitulo.Text = "Controle de Filmes";
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
            // dataGridFilme
            // 
            this.dataGridFilme.AllowUserToAddRows = false;
            this.dataGridFilme.AllowUserToDeleteRows = false;
            this.dataGridFilme.AllowUserToOrderColumns = true;
            this.dataGridFilme.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridFilme.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridFilme.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridFilme.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridFilme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFilme.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TITULO,
            this.Formato,
            this.CLASSIFICACAO,
            this.DURACAO,
            this.ID_filmes});
            this.dataGridFilme.Location = new System.Drawing.Point(51, 67);
            this.dataGridFilme.MaximumSize = new System.Drawing.Size(440, 270);
            this.dataGridFilme.MinimumSize = new System.Drawing.Size(440, 270);
            this.dataGridFilme.MultiSelect = false;
            this.dataGridFilme.Name = "dataGridFilme";
            this.dataGridFilme.ReadOnly = true;
            this.dataGridFilme.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridFilme.RowHeadersVisible = false;
            this.dataGridFilme.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridFilme.Size = new System.Drawing.Size(440, 270);
            this.dataGridFilme.TabIndex = 14;
            this.dataGridFilme.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridUsuarios_CellClick);
            // 
            // TITULO
            // 
            this.TITULO.DataPropertyName = "TITULO";
            this.TITULO.HeaderText = "Titulo";
            this.TITULO.MaxInputLength = 100;
            this.TITULO.MinimumWidth = 180;
            this.TITULO.Name = "TITULO";
            this.TITULO.ReadOnly = true;
            this.TITULO.Width = 180;
            // 
            // Formato
            // 
            this.Formato.DataPropertyName = "MIDIA";
            this.Formato.HeaderText = "Formato";
            this.Formato.MaxInputLength = 10;
            this.Formato.MinimumWidth = 100;
            this.Formato.Name = "Formato";
            this.Formato.ReadOnly = true;
            // 
            // CLASSIFICACAO
            // 
            this.CLASSIFICACAO.DataPropertyName = "CLASSIFICACAO";
            this.CLASSIFICACAO.HeaderText = "Classificação";
            this.CLASSIFICACAO.MinimumWidth = 80;
            this.CLASSIFICACAO.Name = "CLASSIFICACAO";
            this.CLASSIFICACAO.ReadOnly = true;
            this.CLASSIFICACAO.Width = 80;
            // 
            // DURACAO
            // 
            this.DURACAO.DataPropertyName = "DURACAO";
            this.DURACAO.HeaderText = "Duração";
            this.DURACAO.MinimumWidth = 50;
            this.DURACAO.Name = "DURACAO";
            this.DURACAO.ReadOnly = true;
            this.DURACAO.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DURACAO.Width = 80;
            // 
            // ID_filmes
            // 
            this.ID_filmes.DataPropertyName = "ID";
            this.ID_filmes.HeaderText = "id";
            this.ID_filmes.Name = "ID_filmes";
            this.ID_filmes.ReadOnly = true;
            this.ID_filmes.Visible = false;
            // 
            // tlaCRUDfilmes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 405);
            this.Controls.Add(this.dataGridFilme);
            this.Controls.Add(this.btAtualizar);
            this.Controls.Add(this.btRemover);
            this.Controls.Add(this.btAdicionar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btOk);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "tlaCRUDfilmes";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Filmes | Knoodou";
            this.Load += new System.EventHandler(this.tlaCRUDfilmes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFilme)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridFilme;
        private System.Windows.Forms.DataGridViewTextBoxColumn TITULO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Formato;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLASSIFICACAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DURACAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_filmes;

    }
}