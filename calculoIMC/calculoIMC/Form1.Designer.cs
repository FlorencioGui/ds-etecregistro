namespace calculoIMC
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
            this.txt_altura = new System.Windows.Forms.TextBox();
            this.txt_peso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rd_mulher = new System.Windows.Forms.RadioButton();
            this.rd_homem = new System.Windows.Forms.RadioButton();
            this.btn = new System.Windows.Forms.Button();
            this.txt_imc = new System.Windows.Forms.TextBox();
            this.Resultado = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_resultado = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.Resultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_altura);
            this.groupBox1.Controls.Add(this.txt_peso);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rd_mulher);
            this.groupBox1.Controls.Add(this.rd_homem);
            this.groupBox1.Location = new System.Drawing.Point(54, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 318);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Preencha os dados";
            // 
            // txt_altura
            // 
            this.txt_altura.Location = new System.Drawing.Point(18, 258);
            this.txt_altura.Name = "txt_altura";
            this.txt_altura.Size = new System.Drawing.Size(111, 26);
            this.txt_altura.TabIndex = 6;
            this.txt_altura.Text = "Altura (m)";
            this.txt_altura.Click += new System.EventHandler(this.txt_altura_Click);
            // 
            // txt_peso
            // 
            this.txt_peso.Location = new System.Drawing.Point(14, 178);
            this.txt_peso.Name = "txt_peso";
            this.txt_peso.Size = new System.Drawing.Size(115, 26);
            this.txt_peso.TabIndex = 5;
            this.txt_peso.Text = "Peso(Kg)";
            this.txt_peso.Click += new System.EventHandler(this.txt_peso_Click);
            this.txt_peso.TextChanged += new System.EventHandler(this.txt_peso_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Digite sua altura (m):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Digite em peso (Kg):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selecione seu sexo:";
            // 
            // rd_mulher
            // 
            this.rd_mulher.AutoSize = true;
            this.rd_mulher.Location = new System.Drawing.Point(14, 93);
            this.rd_mulher.Name = "rd_mulher";
            this.rd_mulher.Size = new System.Drawing.Size(82, 24);
            this.rd_mulher.TabIndex = 1;
            this.rd_mulher.Text = "Mulher";
            this.rd_mulher.UseVisualStyleBackColor = true;
            // 
            // rd_homem
            // 
            this.rd_homem.AutoSize = true;
            this.rd_homem.Location = new System.Drawing.Point(14, 63);
            this.rd_homem.Name = "rd_homem";
            this.rd_homem.Size = new System.Drawing.Size(90, 24);
            this.rd_homem.TabIndex = 0;
            this.rd_homem.Text = "Homem";
            this.rd_homem.UseVisualStyleBackColor = true;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(528, 104);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(125, 40);
            this.btn.TabIndex = 1;
            this.btn.Text = "Calcular";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // txt_imc
            // 
            this.txt_imc.Location = new System.Drawing.Point(6, 51);
            this.txt_imc.Name = "txt_imc";
            this.txt_imc.Size = new System.Drawing.Size(141, 26);
            this.txt_imc.TabIndex = 2;
            // 
            // Resultado
            // 
            this.Resultado.Controls.Add(this.label5);
            this.Resultado.Controls.Add(this.label4);
            this.Resultado.Controls.Add(this.txt_resultado);
            this.Resultado.Controls.Add(this.txt_imc);
            this.Resultado.Location = new System.Drawing.Point(506, 191);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(246, 176);
            this.Resultado.TabIndex = 3;
            this.Resultado.TabStop = false;
            this.Resultado.Text = "Resultado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Diagnóstico:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "IMC:";
            // 
            // txt_resultado
            // 
            this.txt_resultado.Location = new System.Drawing.Point(6, 129);
            this.txt_resultado.Name = "txt_resultado";
            this.txt_resultado.Size = new System.Drawing.Size(234, 26);
            this.txt_resultado.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Resultado.ResumeLayout(false);
            this.Resultado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rd_mulher;
        private System.Windows.Forms.RadioButton rd_homem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_altura;
        private System.Windows.Forms.TextBox txt_peso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.TextBox txt_imc;
        private System.Windows.Forms.GroupBox Resultado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_resultado;
    }
}

