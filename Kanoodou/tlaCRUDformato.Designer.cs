namespace Knoodou
{
    partial class tlaCRUDformato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tlaCRUDformato));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubTitulo = new System.Windows.Forms.Label();
            this.dataGridFormato = new System.Windows.Forms.DataGridView();
            this.colunaNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaPrecoLancamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaPrecoNormal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btAdicionar = new System.Windows.Forms.Button();
            this.btRemover = new System.Windows.Forms.Button();
            this.btAtualizar = new System.Windows.Forms.Button();
            this.btPronto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFormato)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(16, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(231, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Contole de Formatos";
            // 
            // lblSubTitulo
            // 
            this.lblSubTitulo.AutoSize = true;
            this.lblSubTitulo.Location = new System.Drawing.Point(38, 34);
            this.lblSubTitulo.Name = "lblSubTitulo";
            this.lblSubTitulo.Size = new System.Drawing.Size(187, 13);
            this.lblSubTitulo.TabIndex = 1;
            this.lblSubTitulo.Text = "Adicione, remova e altere os formatos.";
            // 
            // dataGridFormato
            // 
            this.dataGridFormato.AllowUserToAddRows = false;
            this.dataGridFormato.AllowUserToDeleteRows = false;
            this.dataGridFormato.AllowUserToOrderColumns = true;
            this.dataGridFormato.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridFormato.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridFormato.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridFormato.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridFormato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFormato.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colunaNome,
            this.F_id,
            this.colunaPrecoLancamento,
            this.colunaPrecoNormal});
            this.dataGridFormato.Location = new System.Drawing.Point(51, 67);
            this.dataGridFormato.MaximumSize = new System.Drawing.Size(440, 270);
            this.dataGridFormato.MinimumSize = new System.Drawing.Size(440, 270);
            this.dataGridFormato.MultiSelect = false;
            this.dataGridFormato.Name = "dataGridFormato";
            this.dataGridFormato.ReadOnly = true;
            this.dataGridFormato.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridFormato.RowHeadersVisible = false;
            this.dataGridFormato.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridFormato.Size = new System.Drawing.Size(440, 270);
            this.dataGridFormato.TabIndex = 0;
            this.dataGridFormato.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridFormato_CellClick);
            // 
            // colunaNome
            // 
            this.colunaNome.DataPropertyName = "MIDIA";
            this.colunaNome.HeaderText = "Tipo de midia";
            this.colunaNome.MinimumWidth = 200;
            this.colunaNome.Name = "colunaNome";
            this.colunaNome.ReadOnly = true;
            this.colunaNome.Width = 200;
            // 
            // F_id
            // 
            this.F_id.DataPropertyName = "ID";
            this.F_id.HeaderText = "ID";
            this.F_id.Name = "F_id";
            this.F_id.ReadOnly = true;
            this.F_id.Visible = false;
            // 
            // colunaPrecoLancamento
            // 
            this.colunaPrecoLancamento.DataPropertyName = "preco_lancamento";
            this.colunaPrecoLancamento.HeaderText = "Preço de Lançamento";
            this.colunaPrecoLancamento.MinimumWidth = 135;
            this.colunaPrecoLancamento.Name = "colunaPrecoLancamento";
            this.colunaPrecoLancamento.ReadOnly = true;
            this.colunaPrecoLancamento.Width = 135;
            // 
            // colunaPrecoNormal
            // 
            this.colunaPrecoNormal.DataPropertyName = "preco_normal";
            this.colunaPrecoNormal.HeaderText = "Preço Normal";
            this.colunaPrecoNormal.Name = "colunaPrecoNormal";
            this.colunaPrecoNormal.ReadOnly = true;
            // 
            // btAdicionar
            // 
            this.btAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("btAdicionar.Image")));
            this.btAdicionar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btAdicionar.Location = new System.Drawing.Point(20, 343);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(75, 50);
            this.btAdicionar.TabIndex = 2;
            this.btAdicionar.Text = "Adicionar";
            this.btAdicionar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btAdicionar.UseVisualStyleBackColor = true;
            this.btAdicionar.Click += new System.EventHandler(this.btAdicionar_Click);
            // 
            // btRemover
            // 
            this.btRemover.Image = ((System.Drawing.Image)(resources.GetObject("btRemover.Image")));
            this.btRemover.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btRemover.Location = new System.Drawing.Point(101, 343);
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(75, 50);
            this.btRemover.TabIndex = 3;
            this.btRemover.Text = "Remover";
            this.btRemover.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btRemover.UseVisualStyleBackColor = true;
            this.btRemover.Click += new System.EventHandler(this.btRemover_Click);
            // 
            // btAtualizar
            // 
            this.btAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("btAtualizar.Image")));
            this.btAtualizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btAtualizar.Location = new System.Drawing.Point(182, 343);
            this.btAtualizar.Name = "btAtualizar";
            this.btAtualizar.Size = new System.Drawing.Size(75, 50);
            this.btAtualizar.TabIndex = 4;
            this.btAtualizar.Text = "Atualizar";
            this.btAtualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btAtualizar.UseVisualStyleBackColor = true;
            this.btAtualizar.Click += new System.EventHandler(this.btAtualizar_Click);
            // 
            // btPronto
            // 
            this.btPronto.Location = new System.Drawing.Point(385, 355);
            this.btPronto.Name = "btPronto";
            this.btPronto.Size = new System.Drawing.Size(75, 23);
            this.btPronto.TabIndex = 5;
            this.btPronto.Text = "Pronto!";
            this.btPronto.UseVisualStyleBackColor = true;
            this.btPronto.Click += new System.EventHandler(this.btPronto_Click);
            // 
            // tlaCRUDformato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 405);
            this.Controls.Add(this.btPronto);
            this.Controls.Add(this.btAtualizar);
            this.Controls.Add(this.btRemover);
            this.Controls.Add(this.btAdicionar);
            this.Controls.Add(this.dataGridFormato);
            this.Controls.Add(this.lblSubTitulo);
            this.Controls.Add(this.lblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "tlaCRUDformato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Formatos | Knoodou";
            this.Load += new System.EventHandler(this.tlaCRUDformato_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFormato)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubTitulo;
        private System.Windows.Forms.DataGridView dataGridFormato;
        private System.Windows.Forms.Button btAdicionar;
        private System.Windows.Forms.Button btRemover;
        private System.Windows.Forms.Button btAtualizar;
        private System.Windows.Forms.Button btPronto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaPrecoLancamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaPrecoNormal;
    }
}