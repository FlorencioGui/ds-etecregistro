using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace anosParaDias
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

        private void btn_Click(object sender, EventArgs e)
        {
            double anos, dias;
            anos = double.Parse(txt1.Text);
            dias = anos * 365;
            txt_result.Text=dias.ToString();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_result.Text = "";
            txt1.Text = "";
        }
    }
}
