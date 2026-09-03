namespace GerenciadorProdutos
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
            System.Windows.Forms.TextBox txtNome;
            System.Windows.Forms.TextBox txtPrecoBase;
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAtributoEspecifico = new System.Windows.Forms.TextBox();
            this.lblAtributo = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            txtNome = new System.Windows.Forms.TextBox();
            txtPrecoBase = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome: ";
            // 
            // txtNome
            // 
            txtNome.Location = new System.Drawing.Point(15, 57);
            txtNome.Name = "txtNome";
            txtNome.Size = new System.Drawing.Size(100, 20);
            txtNome.TabIndex = 1;
            // 
            // txtPrecoBase
            // 
            txtPrecoBase.Location = new System.Drawing.Point(15, 118);
            txtPrecoBase.Name = "txtPrecoBase";
            txtPrecoBase.Size = new System.Drawing.Size(100, 20);
            txtPrecoBase.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo: ";
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Físico",
            "Digital"});
            this.cmbTipo.Location = new System.Drawing.Point(15, 178);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(121, 21);
            this.cmbTipo.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Preço Base:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Atributo: ";
            // 
            // txtAtributoEspecifico
            // 
            this.txtAtributoEspecifico.Location = new System.Drawing.Point(15, 248);
            this.txtAtributoEspecifico.Name = "txtAtributoEspecifico";
            this.txtAtributoEspecifico.Size = new System.Drawing.Size(100, 20);
            this.txtAtributoEspecifico.TabIndex = 7;
            // 
            // lblAtributo
            // 
            this.lblAtributo.AutoSize = true;
            this.lblAtributo.Location = new System.Drawing.Point(148, 248);
            this.lblAtributo.Name = "lblAtributo";
            this.lblAtributo.Size = new System.Drawing.Size(16, 13);
            this.lblAtributo.TabIndex = 8;
            this.lblAtributo.Text = "...";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(20, 324);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(95, 42);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblAtributo);
            this.Controls.Add(this.txtAtributoEspecifico);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(txtPrecoBase);
            this.Controls.Add(this.label2);
            this.Controls.Add(txtNome);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAtributoEspecifico;
        private System.Windows.Forms.Label lblAtributo;
        private System.Windows.Forms.Button btnSalvar;
    }
}

