using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_Heranca
{
    internal class funcionario : pessoa_fisica
    {
        private double cartao;

        public void setCartao(double cartao)
        {
            this.cartao = cartao;
        }
        public double getCartao()
        {
            return this.cartao;
        }
    }
}
