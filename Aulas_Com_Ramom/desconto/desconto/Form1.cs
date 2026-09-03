using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desconto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            try
            {
                double valor,resultado;
                valor=double.Parse(txt_valor.Text);
                if (rd_avista.Checked)
                {
                    resultado = valor * 0.9;
                    txt_result.Text = resultado.ToString();
                }
                else if (rd_parcelado.Checked)
                {
                    resultado = valor * 1.05;
                    txt_result.Text = resultado.ToString();
                }
                else
                {
                    MessageBox.Show("Selecione uma forma de pagamento!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Digite um valor válido!");
            }
        }
    }
}
