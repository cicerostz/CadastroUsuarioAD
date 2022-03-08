namespace UserAd
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtPrimeiroNome = new System.Windows.Forms.TextBox();
            this.txtNomeCompleto = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtConta = new System.Windows.Forms.TextBox();
            this.txtGrupo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblInformacao = new System.Windows.Forms.Label();
            this.lblConteudo = new System.Windows.Forms.Label();
            this.llCaminhoArquivo = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnDeletarArquivo = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPrimeiroNome
            // 
            this.txtPrimeiroNome.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtPrimeiroNome.Location = new System.Drawing.Point(34, 150);
            this.txtPrimeiroNome.Name = "txtPrimeiroNome";
            this.txtPrimeiroNome.Size = new System.Drawing.Size(102, 20);
            this.txtPrimeiroNome.TabIndex = 0;
            // 
            // txtNomeCompleto
            // 
            this.txtNomeCompleto.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtNomeCompleto.Location = new System.Drawing.Point(337, 150);
            this.txtNomeCompleto.Name = "txtNomeCompleto";
            this.txtNomeCompleto.Size = new System.Drawing.Size(285, 20);
            this.txtNomeCompleto.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtEmail.Location = new System.Drawing.Point(34, 234);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(279, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // txtConta
            // 
            this.txtConta.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtConta.Location = new System.Drawing.Point(337, 234);
            this.txtConta.Name = "txtConta";
            this.txtConta.Size = new System.Drawing.Size(100, 20);
            this.txtConta.TabIndex = 4;
            // 
            // txtGrupo
            // 
            this.txtGrupo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtGrupo.Location = new System.Drawing.Point(480, 234);
            this.txtGrupo.Name = "txtGrupo";
            this.txtGrupo.Size = new System.Drawing.Size(142, 20);
            this.txtGrupo.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Primeiro Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Sobrenome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(334, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Nome Completo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "E-mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(334, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Conta";
            // 
            // lblInformacao
            // 
            this.lblInformacao.AutoSize = true;
            this.lblInformacao.Location = new System.Drawing.Point(31, 416);
            this.lblInformacao.Name = "lblInformacao";
            this.lblInformacao.Size = new System.Drawing.Size(91, 13);
            this.lblInformacao.TabIndex = 8;
            this.lblInformacao.Text = "Arquivo salvo em:";
            // 
            // lblConteudo
            // 
            this.lblConteudo.AutoSize = true;
            this.lblConteudo.Location = new System.Drawing.Point(31, 485);
            this.lblConteudo.Name = "lblConteudo";
            this.lblConteudo.Size = new System.Drawing.Size(84, 13);
            this.lblConteudo.TabIndex = 10;
            this.lblConteudo.Text = "Conteudo salvo:";
            // 
            // llCaminhoArquivo
            // 
            this.llCaminhoArquivo.AutoSize = true;
            this.llCaminhoArquivo.Location = new System.Drawing.Point(31, 455);
            this.llCaminhoArquivo.Name = "llCaminhoArquivo";
            this.llCaminhoArquivo.Size = new System.Drawing.Size(152, 13);
            this.llCaminhoArquivo.TabIndex = 9;
            this.llCaminhoArquivo.TabStop = true;
            this.llCaminhoArquivo.Text = "clique aqui para abrir o arquivo";
            this.llCaminhoArquivo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llCaminhoArquivo_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UserAd.Properties.Resources.brasao;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtSobrenome.Location = new System.Drawing.Point(151, 150);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(162, 20);
            this.txtSobrenome.TabIndex = 1;
            this.txtSobrenome.TextChanged += new System.EventHandler(this.txtSobrenome_TextChanged);
            this.txtSobrenome.Leave += new System.EventHandler(this.txtSobrenome_Leave);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Alef", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
            this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnCadastrar.Location = new System.Drawing.Point(34, 298);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(116, 35);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnDeletarArquivo
            // 
            this.btnDeletarArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletarArquivo.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnDeletarArquivo.Image = ((System.Drawing.Image)(resources.GetObject("btnDeletarArquivo.Image")));
            this.btnDeletarArquivo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeletarArquivo.Location = new System.Drawing.Point(494, 208);
            this.btnDeletarArquivo.Name = "btnDeletarArquivo";
            this.btnDeletarArquivo.Size = new System.Drawing.Size(116, 35);
            this.btnDeletarArquivo.TabIndex = 7;
            this.btnDeletarArquivo.Text = "Deletar Arquivo";
            this.btnDeletarArquivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeletarArquivo.UseVisualStyleBackColor = true;
            this.btnDeletarArquivo.Click += new System.EventHandler(this.btnDeletarArquivo_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(477, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Unidade Organizacional (OU)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeletarArquivo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(719, 282);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CADASTRO USUÁRIOS AD";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(12, 382);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(719, 271);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "INFORMAÇÕES:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(743, 665);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.llCaminhoArquivo);
            this.Controls.Add(this.lblConteudo);
            this.Controls.Add(this.lblInformacao);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtGrupo);
            this.Controls.Add(this.txtConta);
            this.Controls.Add(this.txtNomeCompleto);
            this.Controls.Add(this.txtSobrenome);
            this.Controls.Add(this.txtPrimeiroNome);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadAd versão 1.0";
            this.Leave += new System.EventHandler(this.Form1_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPrimeiroNome;
        private System.Windows.Forms.TextBox txtNomeCompleto;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtConta;
        private System.Windows.Forms.TextBox txtGrupo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblInformacao;
        private System.Windows.Forms.Label lblConteudo;
        private System.Windows.Forms.LinkLabel llCaminhoArquivo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnDeletarArquivo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

