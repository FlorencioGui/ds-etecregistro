namespace EleicaoForm
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
            this.txt_totalEleitores = new System.Windows.Forms.TextBox();
            this.txt_branco = new System.Windows.Forms.TextBox();
            this.txt_nulo = new System.Windows.Forms.TextBox();
            this.txt_valido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.txt_results = new System.Windows.Forms.TextBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.txt_result2 = new System.Windows.Forms.TextBox();
            this.txt_result3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_totalEleitores
            // 
            this.txt_totalEleitores.Location = new System.Drawing.Point(62, 71);
            this.txt_totalEleitores.Name = "txt_totalEleitores";
            this.txt_totalEleitores.Size = new System.Drawing.Size(100, 26);
            this.txt_totalEleitores.TabIndex = 0;
            // 
            // txt_branco
            // 
            this.txt_branco.Location = new System.Drawing.Point(62, 142);
            this.txt_branco.Name = "txt_branco";
            this.txt_branco.Size = new System.Drawing.Size(100, 26);
            this.txt_branco.TabIndex = 1;
            // 
            // txt_nulo
            // 
            this.txt_nulo.Location = new System.Drawing.Point(62, 213);
            this.txt_nulo.Name = "txt_nulo";
            this.txt_nulo.Size = new System.Drawing.Size(100, 26);
            this.txt_nulo.TabIndex = 2;
            // 
            // txt_valido
            // 
            this.txt_valido.Location = new System.Drawing.Point(62, 284);
            this.txt_valido.Name = "txt_valido";
            this.txt_valido.Size = new System.Drawing.Size(100, 26);
            this.txt_valido.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Digite o número total de eleitores:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Digite o número de votos em branco:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Digite o número de votos nulos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Digite o número de votos válidos:";
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(595, 96);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(133, 61);
            this.btn_calcular.TabIndex = 8;
            this.btn_calcular.Text = "Calcular Porcentagem";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // txt_results
            // 
            this.txt_results.Location = new System.Drawing.Point(61, 337);
            this.txt_results.Name = "txt_results";
            this.txt_results.Size = new System.Drawing.Size(242, 26);
            this.txt_results.TabIndex = 9;
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(595, 242);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(133, 52);
            this.btn_reset.TabIndex = 10;
            this.btn_reset.Text = "Resetar";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // txt_result2
            // 
            this.txt_result2.Location = new System.Drawing.Point(62, 370);
            this.txt_result2.Name = "txt_result2";
            this.txt_result2.Size = new System.Drawing.Size(241, 26);
            this.txt_result2.TabIndex = 11;
            // 
            // txt_result3
            // 
            this.txt_result3.Location = new System.Drawing.Point(61, 403);
            this.txt_result3.Name = "txt_result3";
            this.txt_result3.Size = new System.Drawing.Size(242, 26);
            this.txt_result3.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_result3);
            this.Controls.Add(this.txt_result2);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.txt_results);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_valido);
            this.Controls.Add(this.txt_nulo);
            this.Controls.Add(this.txt_branco);
            this.Controls.Add(this.txt_totalEleitores);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_totalEleitores;
        private System.Windows.Forms.TextBox txt_branco;
        private System.Windows.Forms.TextBox txt_nulo;
        private System.Windows.Forms.TextBox txt_valido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.TextBox txt_results;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.TextBox txt_result2;
        private System.Windows.Forms.TextBox txt_result3;
    }
}

