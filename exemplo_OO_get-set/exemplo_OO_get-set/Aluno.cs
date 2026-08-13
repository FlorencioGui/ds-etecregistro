using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplo_OO_get_set
{
    internal class Aluno
    {

        private string nome_aluno;
        private int idade_aluno;
        private double cpf_aluno;


    /**/
        public void setNome_aluno(string nome_aluno)
        {
            this.nome_aluno = nome_aluno;
        }
        public void setIdade_aluno(int idade_aluno)
        {
            this.idade_aluno = idade_aluno;
        }
        public void setCpf_aluno(double cpf_aluno)
        {
            this.cpf_aluno = cpf_aluno;
        }

        public string getNome_aluno()
        {
            return this.nome_aluno;
        }
        public int getIdade_aluno()
        {
            return this.idade_aluno;
        }
        public double getCpf_aluno()
        {
            return this.cpf_aluno;
        }
    }
}
