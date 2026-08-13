using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exemplo_OO_get_set
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Aluno al = new Aluno();
        private void btn_armazenar_set_Click(object sender, EventArgs e)
        {
            al.setNome_aluno(txt_nome.Text);
            al.setIdade_aluno(int.Parse(txt_idade.Text));
            al.setCpf_aluno(double.Parse(txt_cpf.Text));
        }

        private void btn_mostrar_get_Click(object sender, EventArgs e)
        {
            lbl_motrar_nome.Text = al.getNome_aluno();
            lbl_mostrar_idade.Text = al.getIdade_aluno().ToString();
            lbl_mostrar_cpf.Text = al.getCpf_aluno().ToString();
        }
    }
}
