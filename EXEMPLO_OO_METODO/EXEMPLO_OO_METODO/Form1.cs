using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXEMPLO_OO_METODO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Agora instanciaremos o objeto
        Calculos_matematicos cm = new Calculos_matematicos();

        double v_numero1, v_numero2,v_numero3,v_numero4;

        private void btn_div_Click(object sender, EventArgs e)
        {
            v_numero1 = double.Parse(txt_numero1.Text);
            v_numero2 = double.Parse(txt_numero2.Text);
            v_numero3 = double.Parse(txt_numero3.Text);
            v_numero4 = double.Parse(txt_numero4.Text);
            txt_result.Text = cm.calculo_div(v_numero1, v_numero2, v_numero3, v_numero4).ToString();
        }

        private void btn_mult_Click(object sender, EventArgs e)
        {
            v_numero1 = double.Parse(txt_numero1.Text);
            v_numero2 = double.Parse(txt_numero2.Text);
            v_numero3 = double.Parse(txt_numero3.Text);
            v_numero4 = double.Parse(txt_numero4.Text);
            txt_result.Text = cm.calculo_mult(v_numero1, v_numero2, v_numero3, v_numero4).ToString();
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            v_numero1 = double.Parse(txt_numero1.Text);
            v_numero2 = double.Parse(txt_numero2.Text);
            v_numero3 = double.Parse(txt_numero3.Text);
            v_numero4 = double.Parse(txt_numero4.Text);
            txt_result.Text = cm.calculo_sub(v_numero1, v_numero2, v_numero3, v_numero4).ToString();


        }

        private void btn_Click(object sender, EventArgs e)
        {
            v_numero1 = double.Parse(txt_numero1.Text);
            v_numero2 = double.Parse(txt_numero2.Text);
            v_numero3=  double.Parse(txt_numero3.Text); 
            v_numero4 = double.Parse(txt_numero4.Text);
            txt_result.Text = cm.calculo_soma(v_numero1,v_numero2,v_numero3,v_numero4).ToString();
            //Aqui, nos chamamos o metodo CALCULO_SOMA de dentro da classe com apelido CM
            //Ele executou toda a fórmula la na classe que nos retoronou o resultado que exibiremos.
        }
    }
}
