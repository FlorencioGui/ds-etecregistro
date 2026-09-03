using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mediaDeAlunosPonderada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_media_Click(object sender, EventArgs e)
        {
            double media,nota1,nota2,nota3;
            nota1 = double.Parse(txt1.Text)*0.2;
            nota2 = double.Parse(txt2.Text)*0.3;
            nota3 = double.Parse(txt3.Text)*0.5;
            media = nota1 + nota2 + nota3;
            txt_result.Text=media.ToString();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            txt_result.Text = "";
        }
    }
}
