using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reaisDolar
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
                double reais,cotacao, dolares;
                reais=double.Parse(txt_reais.Text);
                cotacao=double.Parse(txt_cotacao.Text);
                dolares = reais * cotacao;
                txt_dolares.Text=dolares.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Digite um valor válido!");
            }
        }
    }
}
