namespace Knoodou
{
    partial class tlaLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tlaLogin));
            this.btOk = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.inSenha = new System.Windows.Forms.TextBox();
            this.inUsuario = new System.Windows.Forms.TextBox();
            this.picLoading = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Con = new System.Windows.Forms.Button();
            this.lblSer = new System.Windows.Forms.Label();
            this.inserver = new System.Windows.Forms.TextBox();
            this.inuser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inpass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // btOk
            // 
            this.btOk.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btOk.Location = new System.Drawing.Point(132, 105);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 23);
            this.btOk.TabIndex = 2;
            this.btOk.Text = "Entrar";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancelar.Location = new System.Drawing.Point(218, 105);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 3;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(93, 22);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Usuário:";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(93, 59);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(41, 13);
            this.lblSenha.TabIndex = 3;
            this.lblSenha.Text = "Senha:";
            // 
            // inSenha
            // 
            this.inSenha.Location = new System.Drawing.Point(145, 56);
            this.inSenha.MaxLength = 10;
            this.inSenha.Name = "inSenha";
            this.inSenha.PasswordChar = '*';
            this.inSenha.Size = new System.Drawing.Size(135, 20);
            this.inSenha.TabIndex = 1;
            this.inSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inUsuario_KeyDown);
            // 
            // inUsuario
            // 
            this.inUsuario.Location = new System.Drawing.Point(145, 19);
            this.inUsuario.MaxLength = 10;
            this.inUsuario.Name = "inUsuario";
            this.inUsuario.Size = new System.Drawing.Size(135, 20);
            this.inUsuario.TabIndex = 0;
            this.inUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inUsuario_KeyDown);
            // 
            // picLoading
            // 
            this.picLoading.Image = ((System.Drawing.Image)(resources.GetObject("picLoading.Image")));
            this.picLoading.Location = new System.Drawing.Point(112, 109);
            this.picLoading.Name = "picLoading";
            this.picLoading.Size = new System.Drawing.Size(16, 16);
            this.picLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picLoading.TabIndex = 5;
            this.picLoading.TabStop = false;
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.InitialImage = ((System.Drawing.Image)(resources.GetObject("logo.InitialImage")));
            this.logo.Location = new System.Drawing.Point(18, 31);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(64, 64);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.logo.TabIndex = 6;
            this.logo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(171, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "(min. 6 caracteres)";
            // 
            // Con
            // 
            this.Con.Location = new System.Drawing.Point(12, 105);
            this.Con.Name = "Con";
            this.Con.Size = new System.Drawing.Size(75, 23);
            this.Con.TabIndex = 8;
            this.Con.Text = "Conexão...";
            this.Con.UseVisualStyleBackColor = true;
            this.Con.Click += new System.EventHandler(this.Con_Click);
            // 
            // lblSer
            // 
            this.lblSer.AutoSize = true;
            this.lblSer.Location = new System.Drawing.Point(28, 149);
            this.lblSer.Name = "lblSer";
            this.lblSer.Size = new System.Drawing.Size(46, 13);
            this.lblSer.TabIndex = 9;
            this.lblSer.Text = "Servidor";
            // 
            // inserver
            // 
            this.inserver.Location = new System.Drawing.Point(40, 165);
            this.inserver.MaxLength = 10;
            this.inserver.Name = "inserver";
            this.inserver.Size = new System.Drawing.Size(240, 20);
            this.inserver.TabIndex = 10;
            this.inserver.Text = "localhost";
            // 
            // inuser
            // 
            this.inuser.Location = new System.Drawing.Point(40, 206);
            this.inuser.MaxLength = 10;
            this.inuser.Name = "inuser";
            this.inuser.Size = new System.Drawing.Size(240, 20);
            this.inuser.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Usuário";
            // 
            // inpass
            // 
            this.inpass.Location = new System.Drawing.Point(40, 244);
            this.inpass.MaxLength = 10;
            this.inpass.Name = "inpass";
            this.inpass.PasswordChar = '*';
            this.inpass.Size = new System.Drawing.Size(240, 20);
            this.inpass.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Senha";
            // 
            // tlaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 140);
            this.Controls.Add(this.inpass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inuser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inserver);
            this.Controls.Add(this.lblSer);
            this.Controls.Add(this.Con);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.picLoading);
            this.Controls.Add(this.inUsuario);
            this.Controls.Add(this.inSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "tlaLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login | Knoodou";
            this.Load += new System.EventHandler(this.tlaLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox inSenha;
        private System.Windows.Forms.TextBox inUsuario;
        private System.Windows.Forms.PictureBox picLoading;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Con;
        private System.Windows.Forms.Label lblSer;
        private System.Windows.Forms.TextBox inserver;
        private System.Windows.Forms.TextBox inuser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inpass;
        private System.Windows.Forms.Label label3;
    }
}

