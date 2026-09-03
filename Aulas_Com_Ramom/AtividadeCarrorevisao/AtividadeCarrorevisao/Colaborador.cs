using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeCarrorevisao
{
    internal class Colaborador
    {
        private string nome;
        private double salarioAtual;

        public void aplicarReajuste(double porcentagem)
        {
            this.salarioAtual = this.salarioAtual * (1 + porcentagem/100);
        }
    }
}
