using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EleicaoForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            double total, branco, nulo, valido;
            branco=double.Parse(txt_branco.Text);
            nulo=double.Parse(txt_nulo.Text);
            valido=double.Parse(txt_valido.Text);
            total = double.Parse(txt_totalEleitores.Text);
            if (total == branco + nulo + valido)
            {
                txt_results.Text = (branco / total * 100) + "% votaram em branco!";
                txt_result2.Text = (nulo / total * 100) + "% votaram nulo!";
                txt_result3.Text = (valido / total * 100) + "% votaram de forma válida";
            }
            else
            {
                MessageBox.Show("Você digitou os valores incorretamente!");
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_branco.Text = "";
            txt_nulo.Text = "";
            txt_valido.Text = "";
            txt_results.Text = "";
            txt_result3.Text = "";
            txt_result2.Text = "";
            txt_totalEleitores.Text = "";
        }
    }
}
