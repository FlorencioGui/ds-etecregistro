namespace exemplo_OO_get_set
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
            this.txt_cpf = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_idade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_armazenar_set = new System.Windows.Forms.Button();
            this.btn_mostrar_get = new System.Windows.Forms.Button();
            this.lbl_motrar_nome = new System.Windows.Forms.Label();
            this.lbl_mostrar_idade = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_mostrar_cpf = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_cpf);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_idade);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_nome);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(57, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 250);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Digite";
            // 
            // txt_cpf
            // 
            this.txt_cpf.Location = new System.Drawing.Point(11, 211);
            this.txt_cpf.Name = "txt_cpf";
            this.txt_cpf.Size = new System.Drawing.Size(199, 26);
            this.txt_cpf.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Digite seu CPF";
            // 
            // txt_idade
            // 
            this.txt_idade.Location = new System.Drawing.Point(11, 123);
            this.txt_idade.Name = "txt_idade";
            this.txt_idade.Size = new System.Drawing.Size(199, 26);
            this.txt_idade.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Digite sua idade:";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(11, 50);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(199, 26);
            this.txt_nome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite seu nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome aluno:";
            // 
            // btn_armazenar_set
            // 
            this.btn_armazenar_set.Location = new System.Drawing.Point(568, 102);
            this.btn_armazenar_set.Name = "btn_armazenar_set";
            this.btn_armazenar_set.Size = new System.Drawing.Size(98, 69);
            this.btn_armazenar_set.TabIndex = 2;
            this.btn_armazenar_set.Text = "Armazenar SET";
            this.btn_armazenar_set.UseVisualStyleBackColor = true;
            this.btn_armazenar_set.Click += new System.EventHandler(this.btn_armazenar_set_Click);
            // 
            // btn_mostrar_get
            // 
            this.btn_mostrar_get.Location = new System.Drawing.Point(568, 231);
            this.btn_mostrar_get.Name = "btn_mostrar_get";
            this.btn_mostrar_get.Size = new System.Drawing.Size(98, 58);
            this.btn_mostrar_get.TabIndex = 3;
            this.btn_mostrar_get.Text = "Mostrar GET";
            this.btn_mostrar_get.UseVisualStyleBackColor = true;
            this.btn_mostrar_get.Click += new System.EventHandler(this.btn_mostrar_get_Click);
            // 
            // lbl_motrar_nome
            // 
            this.lbl_motrar_nome.AutoSize = true;
            this.lbl_motrar_nome.Location = new System.Drawing.Point(166, 328);
            this.lbl_motrar_nome.Name = "lbl_motrar_nome";
            this.lbl_motrar_nome.Size = new System.Drawing.Size(113, 20);
            this.lbl_motrar_nome.TabIndex = 4;
            this.lbl_motrar_nome.Text = "Mostrar Nome:";
            // 
            // lbl_mostrar_idade
            // 
            this.lbl_mostrar_idade.AutoSize = true;
            this.lbl_mostrar_idade.Location = new System.Drawing.Point(166, 364);
            this.lbl_mostrar_idade.Name = "lbl_mostrar_idade";
            this.lbl_mostrar_idade.Size = new System.Drawing.Size(112, 20);
            this.lbl_mostrar_idade.TabIndex = 6;
            this.lbl_mostrar_idade.Text = "Mostrar Idade:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Idade aluno:";
            // 
            // lbl_mostrar_cpf
            // 
            this.lbl_mostrar_cpf.AutoSize = true;
            this.lbl_mostrar_cpf.Location = new System.Drawing.Point(166, 403);
            this.lbl_mostrar_cpf.Name = "lbl_mostrar_cpf";
            this.lbl_mostrar_cpf.Size = new System.Drawing.Size(102, 20);
            this.lbl_mostrar_cpf.TabIndex = 8;
            this.lbl_mostrar_cpf.Text = "Mostrar CPF:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(62, 403);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "CPF aluno:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_mostrar_cpf);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbl_mostrar_idade);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_motrar_nome);
            this.Controls.Add(this.btn_mostrar_get);
            this.Controls.Add(this.btn_armazenar_set);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_armazenar_set;
        private System.Windows.Forms.Button btn_mostrar_get;
        private System.Windows.Forms.Label lbl_motrar_nome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_idade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_mostrar_idade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_mostrar_cpf;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_cpf;
    }
}

