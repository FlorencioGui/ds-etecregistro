using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculoIMC
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
                double altura, peso, imc;
                altura = double.Parse(txt_altura.Text);
                peso = double.Parse(txt_peso.Text);
                imc = peso/(altura*altura);

                txt_imc.Text = imc.ToString();
                txt_peso.Text = "Peso(Kg)";
                txt_altura.Text = "Metro(m)";

                if (rd_homem.Checked)
                {
                    if (imc > 40)
                    {
                        txt_resultado.Text = ("Obesidade Mórbida!");
                        txt_resultado.ForeColor = Color.Red;
                    }
                    else if (imc > 30)
                    {
                        txt_resultado.Text = ("Obesidade Moderada!");
                        txt_resultado.ForeColor = Color.Red;
                    }
                    else if (imc > 25)
                    {
                        txt_resultado.Text = ("Obesidade Leve!");
                        txt_resultado.ForeColor = Color.Red;
                    }
                    else if (imc > 20)
                    {
                        txt_resultado.Text = ("Normal!");
                        txt_resultado.ForeColor = Color.Green;
                    }
                    else
                    {
                        txt_resultado.Text = ("Abaixo do Normal");
                        txt_resultado.ForeColor = Color.Red;
                    }
                }
                else if (rd_mulher.Checked)
                {
                    if (imc > 39)
                    {
                        txt_resultado.Text = ("Obesidade Mórbida!");
                        txt_resultado.ForeColor = Color.Red;
                    }
                    else if (imc > 29)
                    {
                        txt_resultado.Text = ("Obesidade Moderada!");
                        txt_resultado.ForeColor = Color.Red;
                    }
                    else if (imc > 24)
                    {
                        txt_resultado.Text = ("Obesidade Leve!");
                        txt_resultado.ForeColor = Color.Red;
                    }
                    else if (imc > 19)
                    {
                        txt_resultado.Text = ("Normal!");
                        txt_resultado.ForeColor = Color.Green;
                    }
                    else
                    {
                        txt_resultado.Text = ("Abaixo do Normal");
                        txt_resultado.ForeColor = Color.Red;
                    }
                }
                else 
                { txt_resultado.Text = ("Selecione seu sexo para saber!"); }
            }
            catch (Exception)
            {
                MessageBox.Show("Digite valores válidos!");
            }
        }

        private void txt_peso_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_peso_Click(object sender, EventArgs e)
        {
            txt_peso.Text = ("");
        }

        private void txt_altura_Click(object sender, EventArgs e)
        {
            txt_altura.Text = ("");
        }
    }
}
