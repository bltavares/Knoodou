namespace Knoodou
{
    partial class tlaAddFormato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tlaAddFormato));
            this.lblNome = new System.Windows.Forms.Label();
            this.lblPrecoLancamento = new System.Windows.Forms.Label();
            this.lblPrecoNormal = new System.Windows.Forms.Label();
            this.inNome = new System.Windows.Forms.TextBox();
            this.btOk = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.inLanc = new System.Windows.Forms.MaskedTextBox();
            this.inNormal = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(40, 18);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(86, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "*Nome da mídia:";
            // 
            // lblPrecoLancamento
            // 
            this.lblPrecoLancamento.AutoSize = true;
            this.lblPrecoLancamento.Location = new System.Drawing.Point(40, 67);
            this.lblPrecoLancamento.Name = "lblPrecoLancamento";
            this.lblPrecoLancamento.Size = new System.Drawing.Size(119, 13);
            this.lblPrecoLancamento.TabIndex = 1;
            this.lblPrecoLancamento.Text = "*Preço de Lançamento:";
            // 
            // lblPrecoNormal
            // 
            this.lblPrecoNormal.AutoSize = true;
            this.lblPrecoNormal.Location = new System.Drawing.Point(40, 114);
            this.lblPrecoNormal.Name = "lblPrecoNormal";
            this.lblPrecoNormal.Size = new System.Drawing.Size(78, 13);
            this.lblPrecoNormal.TabIndex = 2;
            this.lblPrecoNormal.Text = "*Preço Normal:";
            // 
            // inNome
            // 
            this.inNome.Location = new System.Drawing.Point(59, 34);
            this.inNome.MaxLength = 30;
            this.inNome.Name = "inNome";
            this.inNome.Size = new System.Drawing.Size(139, 20);
            this.inNome.TabIndex = 0;
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(34, 165);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 23);
            this.btOk.TabIndex = 3;
            this.btOk.Text = "Criar";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btCriar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(150, 165);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 4;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // inLanc
            // 
            this.inLanc.Location = new System.Drawing.Point(59, 84);
            this.inLanc.Name = "inLanc";
            this.inLanc.Size = new System.Drawing.Size(139, 20);
            this.inLanc.TabIndex = 1;
            // 
            // inNormal
            // 
            this.inNormal.Location = new System.Drawing.Point(59, 130);
            this.inNormal.Name = "inNormal";
            this.inNormal.Size = new System.Drawing.Size(139, 20);
            this.inNormal.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(204, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 36);
            this.label4.TabIndex = 65;
            this.label4.Text = "* Campos marcados com asterisco são obrigatórios";
            // 
            // tlaAddFormato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 215);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inNormal);
            this.Controls.Add(this.inLanc);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.inNome);
            this.Controls.Add(this.lblPrecoNormal);
            this.Controls.Add(this.lblPrecoLancamento);
            this.Controls.Add(this.lblNome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "tlaAddFormato";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Formato | Knoodou";
            this.Load += new System.EventHandler(this.tlaAddFormato_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblPrecoLancamento;
        private System.Windows.Forms.Label lblPrecoNormal;
        private System.Windows.Forms.TextBox inNome;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.MaskedTextBox inLanc;
        private System.Windows.Forms.MaskedTextBox inNormal;
        private System.Windows.Forms.Label label4;
    }
}