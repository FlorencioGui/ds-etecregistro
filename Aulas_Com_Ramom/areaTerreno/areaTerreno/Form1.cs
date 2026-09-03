using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace areaTerreno
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
                double largura, altura, area;
                largura = double.Parse(txt_largura.Text);
                altura = double.Parse(txt_altura.Text);
                area = largura * altura;
                if (area > 200)
                {
                    txt_result.Text = area.ToString() + " m² TERRENO VIP!";
                }
                else
                {
                    txt_result.Text = area.ToString() + " m² TERRENO POPULAR!";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Digite valores válidos!");
            }
        }
    }
}
