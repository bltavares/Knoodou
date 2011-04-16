namespace Knoodou
{
    partial class tlaAddFilmes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tlaAddFilmes));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.inTitulo = new System.Windows.Forms.TextBox();
            this.lblAno = new System.Windows.Forms.Label();
            this.lblClasificacao = new System.Windows.Forms.Label();
            this.inIMDB = new System.Windows.Forms.TextBox();
            this.lblIMDB = new System.Windows.Forms.Label();
            this.inURL = new System.Windows.Forms.TextBox();
            this.lblSite = new System.Windows.Forms.Label();
            this.inDuracao = new System.Windows.Forms.TextBox();
            this.lblDuracao = new System.Windows.Forms.Label();
            this.lblCaracteristica = new System.Windows.Forms.Label();
            this.inQuantidade = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.comboClass = new System.Windows.Forms.ComboBox();
            this.comboCaract = new System.Windows.Forms.ComboBox();
            this.btOk = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.groupGeneros = new System.Windows.Forms.GroupBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.comboFormato = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inAno = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupGeneros.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(59, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(37, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "*Titulo";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // inTitulo
            // 
            this.inTitulo.Location = new System.Drawing.Point(74, 36);
            this.inTitulo.Name = "inTitulo";
            this.inTitulo.Size = new System.Drawing.Size(164, 20);
            this.inTitulo.TabIndex = 0;
            this.inTitulo.TextChanged += new System.EventHandler(this.inTitulo_TextChanged);
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Location = new System.Drawing.Point(59, 66);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(99, 13);
            this.lblAno.TabIndex = 2;
            this.lblAno.Text = "Ano de lancamento";
            this.lblAno.Click += new System.EventHandler(this.lblAno_Click);
            // 
            // lblClasificacao
            // 
            this.lblClasificacao.AutoSize = true;
            this.lblClasificacao.Location = new System.Drawing.Point(59, 110);
            this.lblClasificacao.Name = "lblClasificacao";
            this.lblClasificacao.Size = new System.Drawing.Size(73, 13);
            this.lblClasificacao.TabIndex = 4;
            this.lblClasificacao.Text = "*Classificacao";
            this.lblClasificacao.Click += new System.EventHandler(this.lblClasificacao_Click);
            // 
            // inIMDB
            // 
            this.inIMDB.Location = new System.Drawing.Point(74, 207);
            this.inIMDB.Name = "inIMDB";
            this.inIMDB.Size = new System.Drawing.Size(164, 20);
            this.inIMDB.TabIndex = 5;
            this.inIMDB.TextChanged += new System.EventHandler(this.inIMDB_TextChanged);
            // 
            // lblIMDB
            // 
            this.lblIMDB.AutoSize = true;
            this.lblIMDB.Location = new System.Drawing.Point(59, 191);
            this.lblIMDB.Name = "lblIMDB";
            this.lblIMDB.Size = new System.Drawing.Size(80, 13);
            this.lblIMDB.TabIndex = 6;
            this.lblIMDB.Text = "Codigo do imdb";
            this.lblIMDB.Click += new System.EventHandler(this.lblIMDB_Click);
            // 
            // inURL
            // 
            this.inURL.Location = new System.Drawing.Point(74, 245);
            this.inURL.Name = "inURL";
            this.inURL.Size = new System.Drawing.Size(164, 20);
            this.inURL.TabIndex = 6;
            this.inURL.TextChanged += new System.EventHandler(this.inURL_TextChanged);
            // 
            // lblSite
            // 
            this.lblSite.AutoSize = true;
            this.lblSite.Location = new System.Drawing.Point(59, 229);
            this.lblSite.Name = "lblSite";
            this.lblSite.Size = new System.Drawing.Size(76, 13);
            this.lblSite.TabIndex = 8;
            this.lblSite.Text = "Endereco web";
            this.lblSite.Click += new System.EventHandler(this.lblSite_Click);
            // 
            // inDuracao
            // 
            this.inDuracao.Location = new System.Drawing.Point(74, 282);
            this.inDuracao.Name = "inDuracao";
            this.inDuracao.Size = new System.Drawing.Size(164, 20);
            this.inDuracao.TabIndex = 7;
            this.inDuracao.TextChanged += new System.EventHandler(this.inDuracao_TextChanged);
            // 
            // lblDuracao
            // 
            this.lblDuracao.AutoSize = true;
            this.lblDuracao.Location = new System.Drawing.Point(59, 266);
            this.lblDuracao.Name = "lblDuracao";
            this.lblDuracao.Size = new System.Drawing.Size(114, 13);
            this.lblDuracao.TabIndex = 10;
            this.lblDuracao.Text = "*Duracao (em minutos)";
            this.lblDuracao.Click += new System.EventHandler(this.lblDuracao_Click);
            // 
            // lblCaracteristica
            // 
            this.lblCaracteristica.AutoSize = true;
            this.lblCaracteristica.Location = new System.Drawing.Point(59, 307);
            this.lblCaracteristica.Name = "lblCaracteristica";
            this.lblCaracteristica.Size = new System.Drawing.Size(75, 13);
            this.lblCaracteristica.TabIndex = 12;
            this.lblCaracteristica.Text = "*Caracteristica";
            this.lblCaracteristica.Click += new System.EventHandler(this.lblCaracteristica_Click);
            // 
            // inQuantidade
            // 
            this.inQuantidade.Location = new System.Drawing.Point(74, 165);
            this.inQuantidade.Name = "inQuantidade";
            this.inQuantidade.Size = new System.Drawing.Size(164, 20);
            this.inQuantidade.TabIndex = 4;
            this.inQuantidade.TextChanged += new System.EventHandler(this.inQuantidade_TextChanged);
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(59, 149);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(66, 13);
            this.lblQuantidade.TabIndex = 14;
            this.lblQuantidade.Text = "*Quantidade";
            this.lblQuantidade.Click += new System.EventHandler(this.lblQuantidade_Click);
            // 
            // comboClass
            // 
            this.comboClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboClass.FormattingEnabled = true;
            this.comboClass.Items.AddRange(new object[] {
            "Livre",
            "10 anos",
            "12 anos",
            "14 anos",
            "16 anos",
            "18 anos"});
            this.comboClass.Location = new System.Drawing.Point(74, 127);
            this.comboClass.Name = "comboClass";
            this.comboClass.Size = new System.Drawing.Size(164, 21);
            this.comboClass.TabIndex = 3;
            this.comboClass.SelectedIndexChanged += new System.EventHandler(this.comboClass_SelectedIndexChanged);
            // 
            // comboCaract
            // 
            this.comboCaract.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCaract.FormattingEnabled = true;
            this.comboCaract.Items.AddRange(new object[] {
            "S/N",
            "Sangue",
            "Violência",
            "Sexo"});
            this.comboCaract.Location = new System.Drawing.Point(74, 323);
            this.comboCaract.Name = "comboCaract";
            this.comboCaract.Size = new System.Drawing.Size(164, 21);
            this.comboCaract.TabIndex = 8;
            this.comboCaract.SelectedIndexChanged += new System.EventHandler(this.comboCaract_SelectedIndexChanged);
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(325, 404);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 23);
            this.btOk.TabIndex = 10;
            this.btOk.Text = "Criar";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(429, 404);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 11;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // groupGeneros
            // 
            this.groupGeneros.Controls.Add(this.checkedListBox1);
            this.groupGeneros.Location = new System.Drawing.Point(298, 20);
            this.groupGeneros.Name = "groupGeneros";
            this.groupGeneros.Size = new System.Drawing.Size(228, 335);
            this.groupGeneros.TabIndex = 20;
            this.groupGeneros.TabStop = false;
            this.groupGeneros.Text = "Gêneros";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.SystemColors.Control;
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(6, 13);
            this.checkedListBox1.MultiColumn = true;
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(216, 315);
            this.checkedListBox1.TabIndex = 0;
            this.checkedListBox1.ThreeDCheckBoxes = true;
            // 
            // comboFormato
            // 
            this.comboFormato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFormato.FormattingEnabled = true;
            this.comboFormato.Location = new System.Drawing.Point(74, 363);
            this.comboFormato.Name = "comboFormato";
            this.comboFormato.Size = new System.Drawing.Size(164, 21);
            this.comboFormato.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Mídia";
            // 
            // inAno
            // 
            this.inAno.Location = new System.Drawing.Point(74, 83);
            this.inAno.Mask = "0000";
            this.inAno.Name = "inAno";
            this.inAno.Size = new System.Drawing.Size(164, 20);
            this.inAno.TabIndex = 2;
            this.inAno.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.inAno_MaskInputRejected);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(298, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Ger. Gêneros";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(423, 361);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 23);
            this.button2.TabIndex = 25;
            this.button2.Text = "Ger. Midias";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 404);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 36);
            this.label4.TabIndex = 65;
            this.label4.Text = "* Campos marcados com asterisco são obrigatórios";
            // 
            // tlaAddFilmes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 452);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inAno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboFormato);
            this.Controls.Add(this.groupGeneros);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.comboCaract);
            this.Controls.Add(this.comboClass);
            this.Controls.Add(this.inQuantidade);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.lblCaracteristica);
            this.Controls.Add(this.inDuracao);
            this.Controls.Add(this.lblDuracao);
            this.Controls.Add(this.inURL);
            this.Controls.Add(this.lblSite);
            this.Controls.Add(this.inIMDB);
            this.Controls.Add(this.lblIMDB);
            this.Controls.Add(this.lblClasificacao);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.inTitulo);
            this.Controls.Add(this.lblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "tlaAddFilmes";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de filmes | Knoodou";
            this.Load += new System.EventHandler(this.tlaAddFilmes_Load);
            this.groupGeneros.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox inTitulo;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.Label lblClasificacao;
        private System.Windows.Forms.TextBox inIMDB;
        private System.Windows.Forms.Label lblIMDB;
        private System.Windows.Forms.TextBox inURL;
        private System.Windows.Forms.Label lblSite;
        private System.Windows.Forms.TextBox inDuracao;
        private System.Windows.Forms.Label lblDuracao;
        private System.Windows.Forms.Label lblCaracteristica;
        private System.Windows.Forms.TextBox inQuantidade;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.ComboBox comboClass;
        private System.Windows.Forms.ComboBox comboCaract;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.GroupBox groupGeneros;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ComboBox comboFormato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox inAno;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
    }
}