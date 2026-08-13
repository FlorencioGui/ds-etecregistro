using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mencoesNotas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            double nota1,nota2,nota3,nota4,media;

            try
            {
                nota1 = double.Parse(txt_nota1.Text);
                nota2 = double.Parse(txt_nota2.Text);
                nota3 = double.Parse(txt_nota3.Text);
                nota4 = double.Parse(txt_nota4.Text);

                if (nota1 > 10 || nota2 > 10 || nota3 > 10 || nota4 > 10)
                {
                    MessageBox.Show("Digite notas de 0 a 10!");
                }
                else
                {

                    media = (nota1 + nota2 + nota3 + nota4) / 4;

                    txt_media.Text = media.ToString();


                    if (media < 5)
                    {
                        txt_conceito.Text = "Irregular";
                        txt_conceito.ForeColor = Color.Red;
                    }
                    else if (media < 7)
                    {
                        txt_conceito.Text = "Regular";
                        txt_conceito.ForeColor = Color.Gray;
                    }
                    else if (media < 9)
                    {
                        txt_conceito.Text = "Bom";
                        txt_conceito.ForeColor = Color.Blue;
                    }
                    else
                    {
                        txt_conceito.Text = "Muito Bom";
                        txt_conceito.ForeColor = Color.Green;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Digite valores válidos!");
            }
        }
    }
}
