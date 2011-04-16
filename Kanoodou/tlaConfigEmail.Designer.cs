namespace Knoodou
{
    partial class tlaConfigEmail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tlaConfigEmail));
            this.label1 = new System.Windows.Forms.Label();
            this.inEmail = new System.Windows.Forms.TextBox();
            this.inSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.inPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inServ = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkTLS = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            // 
            // inEmail
            // 
            this.inEmail.Location = new System.Drawing.Point(60, 50);
            this.inEmail.Name = "inEmail";
            this.inEmail.Size = new System.Drawing.Size(260, 20);
            this.inEmail.TabIndex = 1;
            this.inEmail.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // inSenha
            // 
            this.inSenha.Location = new System.Drawing.Point(60, 101);
            this.inSenha.Name = "inSenha";
            this.inSenha.PasswordChar = '*';
            this.inSenha.Size = new System.Drawing.Size(260, 20);
            this.inSenha.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Senha";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(380, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // inPort
            // 
            this.inPort.Location = new System.Drawing.Point(60, 202);
            this.inPort.Name = "inPort";
            this.inPort.Size = new System.Drawing.Size(100, 20);
            this.inPort.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Porta";
            // 
            // inServ
            // 
            this.inServ.Location = new System.Drawing.Point(60, 151);
            this.inServ.Name = "inServ";
            this.inServ.Size = new System.Drawing.Size(100, 20);
            this.inServ.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Servidor SMTP";
            // 
            // chkTLS
            // 
            this.chkTLS.AutoSize = true;
            this.chkTLS.Location = new System.Drawing.Point(223, 182);
            this.chkTLS.Name = "chkTLS";
            this.chkTLS.Size = new System.Drawing.Size(52, 17);
            this.chkTLS.TabIndex = 9;
            this.chkTLS.Text = "TLS?";
            this.chkTLS.UseVisualStyleBackColor = true;
            // 
            // tlaConfigEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 135);
            this.Controls.Add(this.chkTLS);
            this.Controls.Add(this.inPort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inServ);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inSenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inEmail);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "tlaConfigEmail";
            this.ShowInTaskbar = false;
            this.Text = "Configurar email | Knoodou";
            this.Load += new System.EventHandler(this.tlaConfigEmail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inEmail;
        private System.Windows.Forms.TextBox inSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox inPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inServ;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkTLS;
    }
}