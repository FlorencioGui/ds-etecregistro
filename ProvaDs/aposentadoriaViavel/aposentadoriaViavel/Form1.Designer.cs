namespace aposentadoriaViavel
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_nascimento = new System.Windows.Forms.TextBox();
            this.txt_anoIngresso = new System.Windows.Forms.TextBox();
            this.txt_anosdevida = new System.Windows.Forms.TextBox();
            this.txt_anosTrabalhando = new System.Windows.Forms.TextBox();
            this.txt_aposentadoria = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn = new System.Windows.Forms.Button();
            this.txt_anoAtual = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_anoAtual);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_anoIngresso);
            this.groupBox1.Controls.Add(this.txt_nascimento);
            this.groupBox1.Location = new System.Drawing.Point(12, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 201);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Digite:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.a);
            this.groupBox2.Controls.Add(this.txt_aposentadoria);
            this.groupBox2.Controls.Add(this.txt_anosTrabalhando);
            this.groupBox2.Controls.Add(this.txt_anosdevida);
            this.groupBox2.Location = new System.Drawing.Point(537, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(235, 209);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultados";
            // 
            // txt_nascimento
            // 
            this.txt_nascimento.Location = new System.Drawing.Point(6, 59);
            this.txt_nascimento.Name = "txt_nascimento";
            this.txt_nascimento.Size = new System.Drawing.Size(100, 26);
            this.txt_nascimento.TabIndex = 0;
            // 
            // txt_anoIngresso
            // 
            this.txt_anoIngresso.Location = new System.Drawing.Point(6, 114);
            this.txt_anoIngresso.Name = "txt_anoIngresso";
            this.txt_anoIngresso.Size = new System.Drawing.Size(100, 26);
            this.txt_anoIngresso.TabIndex = 1;
            // 
            // txt_anosdevida
            // 
            this.txt_anosdevida.Location = new System.Drawing.Point(6, 53);
            this.txt_anosdevida.Name = "txt_anosdevida";
            this.txt_anosdevida.Size = new System.Drawing.Size(100, 26);
            this.txt_anosdevida.TabIndex = 0;
            // 
            // txt_anosTrabalhando
            // 
            this.txt_anosTrabalhando.Location = new System.Drawing.Point(6, 105);
            this.txt_anosTrabalhando.Name = "txt_anosTrabalhando";
            this.txt_anosTrabalhando.Size = new System.Drawing.Size(100, 26);
            this.txt_anosTrabalhando.TabIndex = 1;
            // 
            // txt_aposentadoria
            // 
            this.txt_aposentadoria.Location = new System.Drawing.Point(6, 161);
            this.txt_aposentadoria.Name = "txt_aposentadoria";
            this.txt_aposentadoria.Size = new System.Drawing.Size(198, 26);
            this.txt_aposentadoria.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Digite seu ano de nascimento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(327, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Digite o ano que você ingressou na empresa:";
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Location = new System.Drawing.Point(6, 30);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(54, 20);
            this.a.TabIndex = 3;
            this.a.Text = "Idade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tempo trabalhando:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(216, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Resultado da Aposentadoria:";
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(404, 217);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(87, 37);
            this.btn.TabIndex = 4;
            this.btn.Text = "Calcular";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // txt_anoAtual
            // 
            this.txt_anoAtual.Location = new System.Drawing.Point(6, 166);
            this.txt_anoAtual.Name = "txt_anoAtual";
            this.txt_anoAtual.Size = new System.Drawing.Size(100, 26);
            this.txt_anoAtual.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Digite o ano atual:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_anoIngresso;
        private System.Windows.Forms.TextBox txt_nascimento;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.TextBox txt_aposentadoria;
        private System.Windows.Forms.TextBox txt_anosTrabalhando;
        private System.Windows.Forms.TextBox txt_anosdevida;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_anoAtual;
    }
}

