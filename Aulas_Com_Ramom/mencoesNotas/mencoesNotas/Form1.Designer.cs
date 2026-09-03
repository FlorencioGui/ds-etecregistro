namespace mencoesNotas
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
            this.txt_nota4 = new System.Windows.Forms.TextBox();
            this.txt_nota3 = new System.Windows.Forms.TextBox();
            this.txt_nota2 = new System.Windows.Forms.TextBox();
            this.txt_nota1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_1 = new System.Windows.Forms.Button();
            this.txt_media = new System.Windows.Forms.TextBox();
            this.txt_conceito = new System.Windows.Forms.TextBox();
            this.Resultados = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.Resultados.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_nota4);
            this.groupBox1.Controls.Add(this.txt_nota3);
            this.groupBox1.Controls.Add(this.txt_nota2);
            this.groupBox1.Controls.Add(this.txt_nota1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(49, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 327);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Notas";
            // 
            // txt_nota4
            // 
            this.txt_nota4.Location = new System.Drawing.Point(11, 282);
            this.txt_nota4.Name = "txt_nota4";
            this.txt_nota4.Size = new System.Drawing.Size(139, 26);
            this.txt_nota4.TabIndex = 7;
            // 
            // txt_nota3
            // 
            this.txt_nota3.Location = new System.Drawing.Point(11, 203);
            this.txt_nota3.Name = "txt_nota3";
            this.txt_nota3.Size = new System.Drawing.Size(139, 26);
            this.txt_nota3.TabIndex = 6;
            // 
            // txt_nota2
            // 
            this.txt_nota2.Location = new System.Drawing.Point(11, 134);
            this.txt_nota2.Name = "txt_nota2";
            this.txt_nota2.Size = new System.Drawing.Size(139, 26);
            this.txt_nota2.TabIndex = 5;
            // 
            // txt_nota1
            // 
            this.txt_nota1.Location = new System.Drawing.Point(11, 65);
            this.txt_nota1.Name = "txt_nota1";
            this.txt_nota1.Size = new System.Drawing.Size(139, 26);
            this.txt_nota1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Digita a nota 4:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Digita a nota 3:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digita a nota 2:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digita a nota 1:";
            // 
            // btn_1
            // 
            this.btn_1.Location = new System.Drawing.Point(506, 102);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(136, 51);
            this.btn_1.TabIndex = 1;
            this.btn_1.Text = "Calcular média";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // txt_media
            // 
            this.txt_media.Location = new System.Drawing.Point(18, 68);
            this.txt_media.Name = "txt_media";
            this.txt_media.Size = new System.Drawing.Size(100, 26);
            this.txt_media.TabIndex = 2;
            // 
            // txt_conceito
            // 
            this.txt_conceito.Location = new System.Drawing.Point(18, 135);
            this.txt_conceito.Name = "txt_conceito";
            this.txt_conceito.Size = new System.Drawing.Size(100, 26);
            this.txt_conceito.TabIndex = 3;
            // 
            // Resultados
            // 
            this.Resultados.Controls.Add(this.label6);
            this.Resultados.Controls.Add(this.label5);
            this.Resultados.Controls.Add(this.txt_media);
            this.Resultados.Controls.Add(this.txt_conceito);
            this.Resultados.Location = new System.Drawing.Point(464, 208);
            this.Resultados.Name = "Resultados";
            this.Resultados.Size = new System.Drawing.Size(222, 180);
            this.Resultados.TabIndex = 4;
            this.Resultados.TabStop = false;
            this.Resultados.Text = "Resutados";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Conceito";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Média final:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Resultados);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Resultados.ResumeLayout(false);
            this.Resultados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_nota4;
        private System.Windows.Forms.TextBox txt_nota3;
        private System.Windows.Forms.TextBox txt_nota2;
        private System.Windows.Forms.TextBox txt_nota1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.TextBox txt_media;
        private System.Windows.Forms.TextBox txt_conceito;
        private System.Windows.Forms.GroupBox Resultados;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

