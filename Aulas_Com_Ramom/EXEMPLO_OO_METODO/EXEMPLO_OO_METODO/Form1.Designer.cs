namespace EXEMPLO_OO_METODO
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
            this.txt_numero1 = new System.Windows.Forms.TextBox();
            this.txt_numero2 = new System.Windows.Forms.TextBox();
            this.txt_result = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn = new System.Windows.Forms.Button();
            this.btn_sub = new System.Windows.Forms.Button();
            this.btn_mult = new System.Windows.Forms.Button();
            this.btn_div = new System.Windows.Forms.Button();
            this.txt_numero3 = new System.Windows.Forms.TextBox();
            this.txt_numero4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_numero1
            // 
            this.txt_numero1.Location = new System.Drawing.Point(72, 90);
            this.txt_numero1.Name = "txt_numero1";
            this.txt_numero1.Size = new System.Drawing.Size(100, 26);
            this.txt_numero1.TabIndex = 0;
            // 
            // txt_numero2
            // 
            this.txt_numero2.Location = new System.Drawing.Point(72, 164);
            this.txt_numero2.Name = "txt_numero2";
            this.txt_numero2.Size = new System.Drawing.Size(100, 26);
            this.txt_numero2.TabIndex = 1;
            // 
            // txt_result
            // 
            this.txt_result.Location = new System.Drawing.Point(72, 376);
            this.txt_result.Name = "txt_result";
            this.txt_result.Size = new System.Drawing.Size(100, 26);
            this.txt_result.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Número 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Número 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Resultado:";
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(535, 80);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(118, 47);
            this.btn.TabIndex = 6;
            this.btn.Text = "Soma";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_sub
            // 
            this.btn_sub.Location = new System.Drawing.Point(535, 148);
            this.btn_sub.Name = "btn_sub";
            this.btn_sub.Size = new System.Drawing.Size(118, 47);
            this.btn_sub.TabIndex = 7;
            this.btn_sub.Text = "Subtração";
            this.btn_sub.UseVisualStyleBackColor = true;
            this.btn_sub.Click += new System.EventHandler(this.btn_sub_Click);
            // 
            // btn_mult
            // 
            this.btn_mult.Location = new System.Drawing.Point(535, 221);
            this.btn_mult.Name = "btn_mult";
            this.btn_mult.Size = new System.Drawing.Size(118, 47);
            this.btn_mult.TabIndex = 8;
            this.btn_mult.Text = "Multiplicação";
            this.btn_mult.UseVisualStyleBackColor = true;
            this.btn_mult.Click += new System.EventHandler(this.btn_mult_Click);
            // 
            // btn_div
            // 
            this.btn_div.Location = new System.Drawing.Point(535, 290);
            this.btn_div.Name = "btn_div";
            this.btn_div.Size = new System.Drawing.Size(118, 47);
            this.btn_div.TabIndex = 9;
            this.btn_div.Text = "Divisão";
            this.btn_div.UseVisualStyleBackColor = true;
            this.btn_div.Click += new System.EventHandler(this.btn_div_Click);
            // 
            // txt_numero3
            // 
            this.txt_numero3.Location = new System.Drawing.Point(72, 236);
            this.txt_numero3.Name = "txt_numero3";
            this.txt_numero3.Size = new System.Drawing.Size(100, 26);
            this.txt_numero3.TabIndex = 10;
            // 
            // txt_numero4
            // 
            this.txt_numero4.Location = new System.Drawing.Point(72, 305);
            this.txt_numero4.Name = "txt_numero4";
            this.txt_numero4.Size = new System.Drawing.Size(100, 26);
            this.txt_numero4.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Número 3:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Número 4:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_numero4);
            this.Controls.Add(this.txt_numero3);
            this.Controls.Add(this.btn_div);
            this.Controls.Add(this.btn_mult);
            this.Controls.Add(this.btn_sub);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_result);
            this.Controls.Add(this.txt_numero2);
            this.Controls.Add(this.txt_numero1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_numero1;
        private System.Windows.Forms.TextBox txt_numero2;
        private System.Windows.Forms.TextBox txt_result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button btn_sub;
        private System.Windows.Forms.Button btn_mult;
        private System.Windows.Forms.Button btn_div;
        private System.Windows.Forms.TextBox txt_numero3;
        private System.Windows.Forms.TextBox txt_numero4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

