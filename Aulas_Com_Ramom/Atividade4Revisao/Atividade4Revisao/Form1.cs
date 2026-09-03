using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade4Revisao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Colaborador cola=new Colaborador();
        private void btn_Click(object sender, EventArgs e)
        {
            cola.aplicarReajuste(double.Parse(txtbox.Text));
            txtbox_results.Text=cola.mostarSalario().ToString();
        }
    }
}
