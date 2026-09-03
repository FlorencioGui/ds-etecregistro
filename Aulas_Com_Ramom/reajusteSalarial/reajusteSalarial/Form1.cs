using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reajusteSalarial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            try
            {
                double salario, result;
                salario = double.Parse(txt_salario.Text);
                if (salario >= 2000)
                {
                    result = salario * 1.1;
                }
                else
                {
                    result = salario * 1.15;
                }
                txt_result.Text=result.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Digite um valor válido!");
            }
        }
    }
}
