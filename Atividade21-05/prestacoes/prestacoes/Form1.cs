using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prestacoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        calculo c=new calculo();
        private void btn_Click(object sender, EventArgs e)
        {
            double totais, pagas, valor;
            totais=double.Parse(txt_prestacoes.Text);
            pagas=double.Parse(txt_pagas.Text);
            valor=double.Parse(txt_valor.Text);

            txt_result1.Text = c.calculo_valor_pago(pagas, valor).ToString();
            txt_result2.Text = c.calculo_valor_devendo(totais,pagas,valor).ToString();
        }
    }
}
