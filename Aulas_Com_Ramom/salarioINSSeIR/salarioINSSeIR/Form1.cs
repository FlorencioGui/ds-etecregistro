using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace salarioINSSeIR
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
                double salarioI, salarioF;
                salarioI = double.Parse(txt_salario.Text);
                salarioF=salarioI*0.874;
                txt_result.Text=salarioF.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Digite um valor válido!");
            }
        }
    }
}
