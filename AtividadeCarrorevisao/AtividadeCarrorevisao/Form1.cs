using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeCarrorevisao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Carro car1 = new Carro();
        Carro car2 = new Carro();

        Colaborador col = new Colaborador();

        ProdutoRevenda revenda = new ProdutoRevenda();
        private void btn_Click(object sender, EventArgs e)
        {
            revenda.custoAquisicao = double.Parse(TextBox1.Text);
            revenda.margemLucro = double.Parse(TextBox2.Text);
            TextBox_results.Text = revenda.precoVenda().ToString();
        }

    }
}
