namespace exemplo01_OO
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.btn = new System.Windows.Forms.Button();
            this.Dados = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_idade = new System.Windows.Forms.TextBox();
            this.txt_classe = new System.Windows.Forms.TextBox();
            this.txt_rm = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_sexo = new System.Windows.Forms.TextBox();
            this.Dados.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(10, 54);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(247, 26);
            this.txt_nome.TabIndex = 1;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(552, 138);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(108, 51);
            this.btn.TabIndex = 2;
            this.btn.Text = "Mostrar";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // Dados
            // 
            this.Dados.Controls.Add(this.txt_sexo);
            this.Dados.Controls.Add(this.label5);
            this.Dados.Controls.Add(this.txt_rm);
            this.Dados.Controls.Add(this.txt_classe);
            this.Dados.Controls.Add(this.txt_idade);
            this.Dados.Controls.Add(this.label4);
            this.Dados.Controls.Add(this.label3);
            this.Dados.Controls.Add(this.label2);
            this.Dados.Controls.Add(this.label1);
            this.Dados.Controls.Add(this.txt_nome);
            this.Dados.Location = new System.Drawing.Point(65, 57);
            this.Dados.Name = "Dados";
            this.Dados.Size = new System.Drawing.Size(308, 369);
            this.Dados.TabIndex = 3;
            this.Dados.TabStop = false;
            this.Dados.Text = "Dados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Idade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Classe:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Rm:";
            // 
            // txt_idade
            // 
            this.txt_idade.Location = new System.Drawing.Point(10, 120);
            this.txt_idade.Name = "txt_idade";
            this.txt_idade.Size = new System.Drawing.Size(247, 26);
            this.txt_idade.TabIndex = 5;
            // 
            // txt_classe
            // 
            this.txt_classe.Location = new System.Drawing.Point(11, 187);
            this.txt_classe.Name = "txt_classe";
            this.txt_classe.Size = new System.Drawing.Size(246, 26);
            this.txt_classe.TabIndex = 6;
            // 
            // txt_rm
            // 
            this.txt_rm.Location = new System.Drawing.Point(11, 254);
            this.txt_rm.Name = "txt_rm";
            this.txt_rm.Size = new System.Drawing.Size(246, 26);
            this.txt_rm.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Sexo:";
            // 
            // txt_sexo
            // 
            this.txt_sexo.Location = new System.Drawing.Point(15, 321);
            this.txt_sexo.Name = "txt_sexo";
            this.txt_sexo.Size = new System.Drawing.Size(100, 26);
            this.txt_sexo.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Dados);
            this.Controls.Add(this.btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Dados.ResumeLayout(false);
            this.Dados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.GroupBox Dados;
        private System.Windows.Forms.TextBox txt_rm;
        private System.Windows.Forms.TextBox txt_classe;
        private System.Windows.Forms.TextBox txt_idade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_sexo;
        private System.Windows.Forms.Label label5;
    }
}

