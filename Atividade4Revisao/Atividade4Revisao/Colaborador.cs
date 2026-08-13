using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade4Revisao
{
    internal class Colaborador
    {
        public string nome;
        private double salarioAtual=1000;


        public void aplicarReajuste(double porcentagem)
        {
            this.salarioAtual = this.salarioAtual * (1 + porcentagem / 100);
        }

        public double mostarSalario()
        {
            return this.salarioAtual;
        }

    }
}
