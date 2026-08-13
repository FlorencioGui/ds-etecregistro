namespace exemplo_decisao
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
            this.rdb_ds = new System.Windows.Forms.RadioButton();
            this.rdb_adm = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chk_noite = new System.Windows.Forms.CheckBox();
            this.chk_tarde = new System.Windows.Forms.CheckBox();
            this.chk_manha = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_mostrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdb_ds);
            this.groupBox1.Controls.Add(this.rdb_adm);
            this.groupBox1.Location = new System.Drawing.Point(38, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Curso";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rdb_ds
            // 
            this.rdb_ds.AutoSize = true;
            this.rdb_ds.Location = new System.Drawing.Point(17, 57);
            this.rdb_ds.Name = "rdb_ds";
            this.rdb_ds.Size = new System.Drawing.Size(247, 24);
            this.rdb_ds.TabIndex = 1;
            this.rdb_ds.Text = "Desenvolvimento de Sistemas";
            this.rdb_ds.UseVisualStyleBackColor = true;
            this.rdb_ds.CheckedChanged += new System.EventHandler(this.rdb_ds_CheckedChanged);
            // 
            // rdb_adm
            // 
            this.rdb_adm.AutoSize = true;
            this.rdb_adm.Location = new System.Drawing.Point(17, 26);
            this.rdb_adm.Name = "rdb_adm";
            this.rdb_adm.Size = new System.Drawing.Size(233, 24);
            this.rdb_adm.TabIndex = 0;
            this.rdb_adm.Text = "Administração de Empresas";
            this.rdb_adm.UseVisualStyleBackColor = true;
            this.rdb_adm.CheckedChanged += new System.EventHandler(this.rdb_adm_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chk_noite);
            this.groupBox2.Controls.Add(this.chk_tarde);
            this.groupBox2.Controls.Add(this.chk_manha);
            this.groupBox2.Location = new System.Drawing.Point(38, 273);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 123);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Período";
            // 
            // chk_noite
            // 
            this.chk_noite.AutoSize = true;
            this.chk_noite.Location = new System.Drawing.Point(17, 85);
            this.chk_noite.Name = "chk_noite";
            this.chk_noite.Size = new System.Drawing.Size(72, 24);
            this.chk_noite.TabIndex = 2;
            this.chk_noite.Text = "Noite";
            this.chk_noite.UseVisualStyleBackColor = true;
            // 
            // chk_tarde
            // 
            this.chk_tarde.AutoSize = true;
            this.chk_tarde.Location = new System.Drawing.Point(17, 55);
            this.chk_tarde.Name = "chk_tarde";
            this.chk_tarde.Size = new System.Drawing.Size(76, 24);
            this.chk_tarde.TabIndex = 1;
            this.chk_tarde.Text = "Tarde";
            this.chk_tarde.UseVisualStyleBackColor = true;
            // 
            // chk_manha
            // 
            this.chk_manha.AutoSize = true;
            this.chk_manha.Location = new System.Drawing.Point(17, 25);
            this.chk_manha.Name = "chk_manha";
            this.chk_manha.Size = new System.Drawing.Size(84, 24);
            this.chk_manha.TabIndex = 0;
            this.chk_manha.Text = "Manhã";
            this.chk_manha.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(348, 58);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resultado";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(348, 273);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 100);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Resultado Período";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 0;
            // 
            // btn_mostrar
            // 
            this.btn_mostrar.Location = new System.Drawing.Point(606, 190);
            this.btn_mostrar.Name = "btn_mostrar";
            this.btn_mostrar.Size = new System.Drawing.Size(99, 45);
            this.btn_mostrar.TabIndex = 4;
            this.btn_mostrar.Text = "Mostrar";
            this.btn_mostrar.UseVisualStyleBackColor = true;
            this.btn_mostrar.Click += new System.EventHandler(this.btn_mostrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_mostrar);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_mostrar;
        private System.Windows.Forms.RadioButton rdb_ds;
        private System.Windows.Forms.RadioButton rdb_adm;
        private System.Windows.Forms.CheckBox chk_noite;
        private System.Windows.Forms.CheckBox chk_tarde;
        private System.Windows.Forms.CheckBox chk_manha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

