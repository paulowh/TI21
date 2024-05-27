namespace quiz_p
{
    partial class frmCadastrarPergunta
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastrarPergunta));
            this.rtxPergunta = new System.Windows.Forms.RichTextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.rbAlternativaCorretaA = new System.Windows.Forms.RadioButton();
            this.txbAlternativaA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbAlternativaB = new System.Windows.Forms.TextBox();
            this.rbAlternativaCorretaB = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txbAlternativaC = new System.Windows.Forms.TextBox();
            this.rbAlternativaCorretaC = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txbAlternativaD = new System.Windows.Forms.TextBox();
            this.rbAlternativaCorretaD = new System.Windows.Forms.RadioButton();
            this.btnJogar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtxPergunta
            // 
            this.rtxPergunta.Location = new System.Drawing.Point(12, 42);
            this.rtxPergunta.Name = "rtxPergunta";
            this.rtxPergunta.Size = new System.Drawing.Size(484, 175);
            this.rtxPergunta.TabIndex = 0;
            this.rtxPergunta.Text = "";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(13, 405);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(105, 33);
            this.btnCadastrar.TabIndex = 1;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // rbAlternativaCorretaA
            // 
            this.rbAlternativaCorretaA.AutoSize = true;
            this.rbAlternativaCorretaA.Location = new System.Drawing.Point(475, 239);
            this.rbAlternativaCorretaA.Name = "rbAlternativaCorretaA";
            this.rbAlternativaCorretaA.Size = new System.Drawing.Size(21, 20);
            this.rbAlternativaCorretaA.TabIndex = 2;
            this.rbAlternativaCorretaA.TabStop = true;
            this.rbAlternativaCorretaA.UseVisualStyleBackColor = true;
            // 
            // txbAlternativaA
            // 
            this.txbAlternativaA.Location = new System.Drawing.Point(43, 233);
            this.txbAlternativaA.Name = "txbAlternativaA";
            this.txbAlternativaA.Size = new System.Drawing.Size(426, 26);
            this.txbAlternativaA.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "a)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "b)";
            // 
            // txbAlternativaB
            // 
            this.txbAlternativaB.Location = new System.Drawing.Point(43, 265);
            this.txbAlternativaB.Name = "txbAlternativaB";
            this.txbAlternativaB.Size = new System.Drawing.Size(426, 26);
            this.txbAlternativaB.TabIndex = 6;
            // 
            // rbAlternativaCorretaB
            // 
            this.rbAlternativaCorretaB.AutoSize = true;
            this.rbAlternativaCorretaB.Location = new System.Drawing.Point(475, 271);
            this.rbAlternativaCorretaB.Name = "rbAlternativaCorretaB";
            this.rbAlternativaCorretaB.Size = new System.Drawing.Size(21, 20);
            this.rbAlternativaCorretaB.TabIndex = 5;
            this.rbAlternativaCorretaB.TabStop = true;
            this.rbAlternativaCorretaB.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "c)";
            // 
            // txbAlternativaC
            // 
            this.txbAlternativaC.Location = new System.Drawing.Point(43, 297);
            this.txbAlternativaC.Name = "txbAlternativaC";
            this.txbAlternativaC.Size = new System.Drawing.Size(426, 26);
            this.txbAlternativaC.TabIndex = 9;
            // 
            // rbAlternativaCorretaC
            // 
            this.rbAlternativaCorretaC.AutoSize = true;
            this.rbAlternativaCorretaC.Location = new System.Drawing.Point(475, 303);
            this.rbAlternativaCorretaC.Name = "rbAlternativaCorretaC";
            this.rbAlternativaCorretaC.Size = new System.Drawing.Size(21, 20);
            this.rbAlternativaCorretaC.TabIndex = 8;
            this.rbAlternativaCorretaC.TabStop = true;
            this.rbAlternativaCorretaC.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "d)";
            // 
            // txbAlternativaD
            // 
            this.txbAlternativaD.Location = new System.Drawing.Point(43, 329);
            this.txbAlternativaD.Name = "txbAlternativaD";
            this.txbAlternativaD.Size = new System.Drawing.Size(426, 26);
            this.txbAlternativaD.TabIndex = 12;
            // 
            // rbAlternativaCorretaD
            // 
            this.rbAlternativaCorretaD.AutoSize = true;
            this.rbAlternativaCorretaD.Location = new System.Drawing.Point(475, 335);
            this.rbAlternativaCorretaD.Name = "rbAlternativaCorretaD";
            this.rbAlternativaCorretaD.Size = new System.Drawing.Size(21, 20);
            this.rbAlternativaCorretaD.TabIndex = 11;
            this.rbAlternativaCorretaD.TabStop = true;
            this.rbAlternativaCorretaD.UseVisualStyleBackColor = true;
            // 
            // btnJogar
            // 
            this.btnJogar.Location = new System.Drawing.Point(124, 405);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(105, 33);
            this.btnJogar.TabIndex = 14;
            this.btnJogar.Text = "Jogar";
            this.btnJogar.UseVisualStyleBackColor = true;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // frmCadastrarPergunta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 450);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbAlternativaD);
            this.Controls.Add(this.rbAlternativaCorretaD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbAlternativaC);
            this.Controls.Add(this.rbAlternativaCorretaC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbAlternativaB);
            this.Controls.Add(this.rbAlternativaCorretaB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbAlternativaA);
            this.Controls.Add(this.rbAlternativaCorretaA);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.rtxPergunta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadastrarPergunta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Perguntas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxPergunta;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.RadioButton rbAlternativaCorretaA;
        private System.Windows.Forms.TextBox txbAlternativaA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbAlternativaB;
        private System.Windows.Forms.RadioButton rbAlternativaCorretaB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbAlternativaC;
        private System.Windows.Forms.RadioButton rbAlternativaCorretaC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbAlternativaD;
        private System.Windows.Forms.RadioButton rbAlternativaCorretaD;
        private System.Windows.Forms.Button btnJogar;
    }
}

