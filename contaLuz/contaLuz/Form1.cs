using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace contaLuz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
                
        }

        private void btn_Click(object sender, EventArgs e)
        {
            try
            {
                double consumo, valor, total;
                consumo=double.Parse(txt_consumo.Text);
                valor=double.Parse(txt_valor.Text);
                if (consumo>100)
                {
                    total = consumo * (valor * 1.15);
                }
                else
                {
                    total=valor*consumo;
                }
                txt_result.Text = total.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Digite valores válidos!");
            }
        }
    }
}
