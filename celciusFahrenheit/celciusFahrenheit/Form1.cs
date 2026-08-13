using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace celciusFahrenheit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            try
            {
                double resultado, graus;
                graus = double.Parse(txt_graus.Text);
                resultado = (graus * 1.8) + 32;
                txt_result.Text = resultado.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Digite um valor válido!");
            }
        }
    }
}
