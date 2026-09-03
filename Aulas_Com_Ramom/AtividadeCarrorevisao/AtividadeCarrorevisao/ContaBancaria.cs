using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeCarrorevisao
{
    internal class ContaBancaria
    {
        private double saldo;

        public void depositar(double valorDepositado)
        {
            this.saldo = this.saldo + valorDepositado;
        }
        public void sacar(double valorSacado)
        {
            this.saldo = this.saldo + valorSacado;
        }
    }
}
