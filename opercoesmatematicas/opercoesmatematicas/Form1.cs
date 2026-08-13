using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace opercoesmatematicas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //bor decarar a variável
            double numero1,numero2,numero3,numero4,soma;
            numero1=double.Parse(txt1.Text);
            //isto quer dizer que QUANDO CLICAR NO BOTÃO a variável vai armazenar o que estiver na caixa de texto 1
            numero2=double.Parse(txt2.Text);
            numero3 = double.Parse(txt3.Text);
            numero4 = double.Parse(txt4.Text);
            soma =numero1 + numero2 + numero3 + numero4;
            //Agora vamos mostrar o resultado;
            txt_result.Text = soma.ToString();
            //Primeiro diz o nome do componente, depois a propriedade dele na qual vai ser alterada e depois por ultimo, ele converte os números em carctéres.
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //subtração
            double numero1, numero2, numero3, numero4, subtracao;
            numero1 = double.Parse(txt1.Text);
            numero2 = double.Parse(txt2.Text);
            numero3 = double.Parse(txt3.Text);
            numero4 = double.Parse(txt4.Text);
            subtracao =numero1 - numero2 - numero3 - numero4;
            txt_result.Text=subtracao.ToString();

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void divisao_Click(object sender, EventArgs e)
        {
            double numero1, numero2, numero3, numero4, divisao;
            numero1 = double.Parse(txt1.Text);
            numero2 = double.Parse(txt2.Text);
            numero3 = double.Parse(txt3.Text);
            numero4 = double.Parse(txt4.Text);
            divisao = numero1 / numero2 / numero3 / numero4;
            txt_result.Text = divisao.ToString();
        }

        private void multiplicacao_Click(object sender, EventArgs e)
        {
            double numero1, numero2, numero3, numero4, multiplicacao;
            numero1 = double.Parse(txt1.Text);
            numero2 = double.Parse(txt2.Text);
            numero3 = double.Parse(txt3.Text);
            numero4 = double.Parse(txt4.Text);
            multiplicacao = numero1 * numero2 * numero3 * numero4;
            txt_result.Text = multiplicacao.ToString();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            txt_result.Text = "";
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            txt4.Text = "";
        }
    }
}
