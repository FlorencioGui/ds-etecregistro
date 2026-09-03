using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace salarioTotal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            try
            {
                double horas, valorHora, salario;
                horas=double.Parse(txt_horas.Text);
                valorHora = double.Parse(txt_valor.Text);

                if (horas > 40)
                {
                    salario = (horas - 40) * (1.5 * valorHora) + (40 * valorHora);
                }
                else
                {
                    salario = horas * valorHora;
                }
                txt_result.Text = salario.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Digite valores válidos!");
            }
        }
    }
}
