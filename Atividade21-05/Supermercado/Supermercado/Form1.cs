using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermercado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        calculo c=new calculo();
        private void btn_Click(object sender, EventArgs e)
        {
            try
            {
                string nome;
                int max, atual;
                max = int.Parse(txt_max.Text);
                atual = int.Parse(txt_atual.Text);
                nome = txt_nome.Text;
                txt_result.Text = c.calculo_diferenca(max, atual).ToString();
                txt_nomeR.Text = nome;
            }
            catch (Exception)
            {
                MessageBox.Show("Digite os valores corretamente!");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
