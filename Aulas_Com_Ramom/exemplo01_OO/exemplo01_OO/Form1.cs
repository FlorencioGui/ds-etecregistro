using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exemplo01_OO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Alunos al = new Alunos();

        /* Aluno é o nome da classe e AL é o nome do objeto,
         new Alunos(); e a riação do construtor, construtor pode ser
        alterado ou manter padrão.
        Todo processo possui o nome de instanciar o objeto*/

        private void btn_Click(object sender, EventArgs e)
        {
            txt_nome.Text = al.nome;
            txt_idade.Text=al.idade.ToString();
            txt_classe.Text=al.classe;
            txt_rm.Text=al.rm.ToString();
            txt_sexo.Text=al.sexo;
        }
    }
}
