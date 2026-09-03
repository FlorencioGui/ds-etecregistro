using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace salarioRevendedoraVendedor
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
                double valor,carros, salario;
                valor=double.Parse(txt_valor.Text);
                carros=double.Parse(txt_carros.Text);
                salario=(valor*0.015*carros)+1158;
                txt_result.Text=(salario.ToString()+" R$");
            }
            catch (Exception)
            {
                MessageBox.Show("Digite valores válidos!");
            }
        }
    }
}
