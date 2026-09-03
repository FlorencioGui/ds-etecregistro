using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aposentadoriaViavel
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
                double anoN, anoI, idade, tempoTrabalhado, anoAtual;
                anoN = double.Parse(txt_nascimento.Text);
                anoI = double.Parse(txt_anoIngresso.Text);
                anoAtual = double.Parse(txt_anoAtual.Text);
                idade = anoAtual - anoN;
                tempoTrabalhado = anoAtual - anoI;
                
                txt_anosdevida.Text = idade.ToString();
                txt_anosTrabalhando.Text=tempoTrabalhado.ToString();
                if ((anoN+10)>anoI)
                {
                    MessageBox.Show("Digite os dados HONESTAMENTE!");
                    txt_aposentadoria.Text = ("");
                }
                else if (idade>=65||tempoTrabalhado>=30||(idade>=60&&tempoTrabalhado>=25))
                {
                    txt_aposentadoria.Text = ("Requerer Aposentadoria!");
                }
                else
                {
                    txt_aposentadoria.Text = ("Não requerer!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Digite valores válidos!");
            }
        }
    }
}
