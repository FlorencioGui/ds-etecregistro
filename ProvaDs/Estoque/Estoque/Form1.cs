using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estoque
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            try
            {
                double atual,min, max, media;
                atual=double.Parse(txt_atual.Text);
                min=double.Parse(txt_min.Text);
                max=double.Parse(txt_max.Text);
                media = (min + max) / 2;

                txt_media.Text = media.ToString();

                if (atual >= media)
                {
                    txt_sts.Text = ("Não efetuar compra!");
                }
                else 
                {
                    txt_sts.Text = ("Efetuar compra!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Digite valores válidos!");
            }
        }
    }
}
