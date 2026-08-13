using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exemplo_Heranca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        funcionario f = new funcionario();
        private void btn_Click(object sender, EventArgs e)
        {
            f.setNome(txtbox1.Text);
            f.setRg(double.Parse(txtbox2.Text));
            f.setCartao(double.Parse(txtbox3.Text));

            txt_result_nome.Text = f.getNome();
            txt_result_RG.Text = f.getRg().ToString();
            txt_result_cartao.Text = f.getCartao().ToString();
        }
    }
}
