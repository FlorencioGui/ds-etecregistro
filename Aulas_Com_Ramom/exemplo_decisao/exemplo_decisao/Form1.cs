using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exemplo_decisao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chk_manha.Visible = false;
            chk_noite.Visible = false;
            chk_tarde.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
        }

        private void rdb_adm_CheckedChanged(object sender, EventArgs e)
        {
            chk_manha.Visible = true;
            chk_noite.Visible = true;
            chk_tarde.Visible = true;
        }

        private void rdb_ds_CheckedChanged(object sender, EventArgs e)
        {
            chk_manha.Visible = true;
            chk_noite.Visible = false;
            chk_tarde.Visible = true;
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            if (rdb_adm.Checked)
            {
                label3.Visible = true;
                label3.Text = "ADM Selecionado!";
                label3.ForeColor = Color.Blue;


            }
            else if (rdb_ds.Checked)
            {
                label3.Visible = true;
                label3.Text = "DS Selecionado!";
                label3.ForeColor = Color.Red;
            }
            else
            {
                label3.Visible = true;
                label3.Text = "Selecione um curso!";
            }

            if (chk_manha.Checked && chk_noite.Checked && chk_tarde.Checked)
            {
                label4.Visible = true;
                label4.Text = "Príodo Inválido!";
            }
            else if (chk_manha.Checked && chk_noite.Checked)
            {
                label4.Visible = true;
                label4.Text = "Príodo Inválido!";
            }
            else if (chk_manha.Checked && chk_noite.Checked)
            {
                label4.Visible = true;
                label4.Text = "Príodo Inválido!";
            }
            else if (chk_manha.Checked && chk_tarde.Checked)
            {
                label4.Visible = true;
                label4.Text = "Período Diurno";
            }
            else if (chk_noite.Checked)
            {
                label4.Visible = true;
                label4.Text = "Período Noturno";
            }
            else if (chk_tarde.Checked)
            {
                label4.Visible = true;
                label4.Text = "Período Diurno";
            }
            else if (chk_manha.Checked)
            {
                label4.Visible = true;
                label4.Text = "Príodo Inválido!";
            }
            
        }
    }
            
}
        

