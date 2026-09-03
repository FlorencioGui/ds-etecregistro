using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValorPrestacao
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
                double prestacao, juros, dias;
                prestacao = double.Parse(txt_prestacao.Text);
                juros = double.Parse(txt_juros.Text);
                dias = double.Parse(txt_dias.Text);
                txt_result.Text = c.prestacao_final(prestacao, juros, dias).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Digite os valores corretamente!");
            }
        }
    }
}
