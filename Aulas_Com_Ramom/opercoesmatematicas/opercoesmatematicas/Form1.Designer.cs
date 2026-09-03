namespace opercoesmatematicas
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
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt_result = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl_resul = new System.Windows.Forms.Label();
            this.btn_soma = new System.Windows.Forms.Button();
            this.subtracao = new System.Windows.Forms.Button();
            this.divisao = new System.Windows.Forms.Button();
            this.multiplicacao = new System.Windows.Forms.Button();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(91, 81);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 26);
            this.txt1.TabIndex = 0;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(91, 136);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(100, 26);
            this.txt2.TabIndex = 1;
            // 
            // txt_result
            // 
            this.txt_result.Location = new System.Drawing.Point(91, 365);
            this.txt_result.Name = "txt_result";
            this.txt_result.Size = new System.Drawing.Size(100, 26);
            this.txt_result.TabIndex = 2;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(91, 55);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(138, 20);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "Digite o número 1:";
            this.lbl1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(91, 110);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(138, 20);
            this.lbl2.TabIndex = 4;
            this.lbl2.Text = "Digite o número 2:";
            // 
            // lbl_resul
            // 
            this.lbl_resul.AutoSize = true;
            this.lbl_resul.Location = new System.Drawing.Point(91, 339);
            this.lbl_resul.Name = "lbl_resul";
            this.lbl_resul.Size = new System.Drawing.Size(86, 20);
            this.lbl_resul.TabIndex = 5;
            this.lbl_resul.Text = "Resultado:";
            // 
            // btn_soma
            // 
            this.btn_soma.Location = new System.Drawing.Point(431, 30);
            this.btn_soma.Name = "btn_soma";
            this.btn_soma.Size = new System.Drawing.Size(106, 65);
            this.btn_soma.TabIndex = 6;
            this.btn_soma.Text = "Soma";
            this.btn_soma.UseVisualStyleBackColor = true;
            this.btn_soma.Click += new System.EventHandler(this.button1_Click);
            // 
            // subtracao
            // 
            this.subtracao.Location = new System.Drawing.Point(431, 123);
            this.subtracao.Name = "subtracao";
            this.subtracao.Size = new System.Drawing.Size(106, 52);
            this.subtracao.TabIndex = 7;
            this.subtracao.Text = "Subtração";
            this.subtracao.UseVisualStyleBackColor = true;
            this.subtracao.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // divisao
            // 
            this.divisao.Location = new System.Drawing.Point(431, 206);
            this.divisao.Name = "divisao";
            this.divisao.Size = new System.Drawing.Size(106, 55);
            this.divisao.TabIndex = 8;
            this.divisao.Text = "Divisão";
            this.divisao.UseVisualStyleBackColor = true;
            this.divisao.Click += new System.EventHandler(this.divisao_Click);
            // 
            // multiplicacao
            // 
            this.multiplicacao.Location = new System.Drawing.Point(431, 297);
            this.multiplicacao.Name = "multiplicacao";
            this.multiplicacao.Size = new System.Drawing.Size(117, 50);
            this.multiplicacao.TabIndex = 9;
            this.multiplicacao.Text = "Multiplicação";
            this.multiplicacao.UseVisualStyleBackColor = true;
            this.multiplicacao.Click += new System.EventHandler(this.multiplicacao_Click);
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(91, 202);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(100, 26);
            this.txt3.TabIndex = 10;
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(91, 265);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(100, 26);
            this.txt4.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Digite o número 3:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Digite o número 4:";
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(600, 181);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(126, 68);
            this.reset.TabIndex = 14;
            this.reset.Text = "Resetar números";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.multiplicacao);
            this.Controls.Add(this.divisao);
            this.Controls.Add(this.subtracao);
            this.Controls.Add(this.btn_soma);
            this.Controls.Add(this.lbl_resul);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txt_result);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt_result;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl_resul;
        private System.Windows.Forms.Button btn_soma;
        private System.Windows.Forms.Button subtracao;
        private System.Windows.Forms.Button divisao;
        private System.Windows.Forms.Button multiplicacao;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button reset;
    }
}

