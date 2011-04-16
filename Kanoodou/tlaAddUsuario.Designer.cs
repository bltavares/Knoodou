namespace Knoodou
{
    partial class tlaAddUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tlaAddUsuario));
            this.btOk = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioAdministrador = new System.Windows.Forms.RadioButton();
            this.radioNormal = new System.Windows.Forms.RadioButton();
            this.inNome = new System.Windows.Forms.TextBox();
            this.inUsuario = new System.Windows.Forms.TextBox();
            this.inSenha = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblConfsenha = new System.Windows.Forms.Label();
            this.inConfsenha = new System.Windows.Forms.TextBox();
            this.picUsuarioadd = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuarioadd)).BeginInit();
            this.SuspendLayout();
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(113, 280);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 23);
            this.btOk.TabIndex = 6;
            this.btOk.Text = "Criar";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(214, 280);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 7;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(110, 17);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(39, 13);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "*Nome";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(110, 69);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(47, 13);
            this.lblSenha.TabIndex = 3;
            this.lblSenha.Text = "*Usuário";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "*Senha";
            // 
            // radioAdministrador
            // 
            this.radioAdministrador.AutoSize = true;
            this.radioAdministrador.Location = new System.Drawing.Point(123, 247);
            this.radioAdministrador.Name = "radioAdministrador";
            this.radioAdministrador.Size = new System.Drawing.Size(88, 17);
            this.radioAdministrador.TabIndex = 4;
            this.radioAdministrador.Text = "Administrador";
            this.radioAdministrador.UseVisualStyleBackColor = true;
            // 
            // radioNormal
            // 
            this.radioNormal.AutoSize = true;
            this.radioNormal.Checked = true;
            this.radioNormal.Location = new System.Drawing.Point(221, 247);
            this.radioNormal.Name = "radioNormal";
            this.radioNormal.Size = new System.Drawing.Size(58, 17);
            this.radioNormal.TabIndex = 5;
            this.radioNormal.TabStop = true;
            this.radioNormal.Text = "Normal";
            this.radioNormal.UseVisualStyleBackColor = true;
            // 
            // inNome
            // 
            this.inNome.Location = new System.Drawing.Point(123, 33);
            this.inNome.MaxLength = 100;
            this.inNome.Name = "inNome";
            this.inNome.Size = new System.Drawing.Size(156, 20);
            this.inNome.TabIndex = 0;
            this.inNome.TextChanged += new System.EventHandler(this.inNome_TextChanged);
            // 
            // inUsuario
            // 
            this.inUsuario.Location = new System.Drawing.Point(123, 85);
            this.inUsuario.MaxLength = 10;
            this.inUsuario.Name = "inUsuario";
            this.inUsuario.Size = new System.Drawing.Size(156, 20);
            this.inUsuario.TabIndex = 1;
            // 
            // inSenha
            // 
            this.inSenha.Location = new System.Drawing.Point(123, 133);
            this.inSenha.MaxLength = 12;
            this.inSenha.Name = "inSenha";
            this.inSenha.PasswordChar = '*';
            this.inSenha.Size = new System.Drawing.Size(156, 20);
            this.inSenha.TabIndex = 2;
            this.inSenha.TextChanged += new System.EventHandler(this.inSenha_TextChanged);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(110, 221);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(83, 13);
            this.lblTipo.TabIndex = 10;
            this.lblTipo.Text = "Tipo do usuário:";
            // 
            // lblConfsenha
            // 
            this.lblConfsenha.AutoSize = true;
            this.lblConfsenha.Location = new System.Drawing.Point(110, 166);
            this.lblConfsenha.Name = "lblConfsenha";
            this.lblConfsenha.Size = new System.Drawing.Size(87, 13);
            this.lblConfsenha.TabIndex = 11;
            this.lblConfsenha.Text = "*Confirmar senha";
            // 
            // inConfsenha
            // 
            this.inConfsenha.Location = new System.Drawing.Point(123, 182);
            this.inConfsenha.Name = "inConfsenha";
            this.inConfsenha.PasswordChar = '*';
            this.inConfsenha.Size = new System.Drawing.Size(156, 20);
            this.inConfsenha.TabIndex = 3;
            this.inConfsenha.TextChanged += new System.EventHandler(this.inConfsenha_TextChanged);
            // 
            // picUsuarioadd
            // 
            this.picUsuarioadd.Image = ((System.Drawing.Image)(resources.GetObject("picUsuarioadd.Image")));
            this.picUsuarioadd.InitialImage = null;
            this.picUsuarioadd.Location = new System.Drawing.Point(9, 10);
            this.picUsuarioadd.Name = "picUsuarioadd";
            this.picUsuarioadd.Size = new System.Drawing.Size(95, 143);
            this.picUsuarioadd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUsuarioadd.TabIndex = 13;
            this.picUsuarioadd.TabStop = false;
            this.picUsuarioadd.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 56);
            this.label4.TabIndex = 66;
            this.label4.Text = "* Campos marcados com asterisco são obrigatórios";
            // 
            // tlaAddUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 325);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.picUsuarioadd);
            this.Controls.Add(this.inConfsenha);
            this.Controls.Add(this.lblConfsenha);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.inSenha);
            this.Controls.Add(this.inUsuario);
            this.Controls.Add(this.inNome);
            this.Controls.Add(this.radioNormal);
            this.Controls.Add(this.radioAdministrador);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btOk);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "tlaAddUsuario";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar usuário | Knoodou";
            this.Load += new System.EventHandler(this.tlaAddUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picUsuarioadd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioAdministrador;
        private System.Windows.Forms.RadioButton radioNormal;
        private System.Windows.Forms.TextBox inNome;
        private System.Windows.Forms.TextBox inUsuario;
        private System.Windows.Forms.TextBox inSenha;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblConfsenha;
        private System.Windows.Forms.TextBox inConfsenha;
        private System.Windows.Forms.PictureBox picUsuarioadd;
        private System.Windows.Forms.Label label4;
    }
}