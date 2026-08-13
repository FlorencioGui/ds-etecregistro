using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeCarrorevisao
{
    internal class Produto
    {
        private int codigo;
        private string descricao;
        private double preco;

        public void aplicarDesconto(double porcentagem)
        {
            this.preco = this.preco * (1 - porcentagem / 100);
        }

        public double exibirDetalhes()
        {
            return this.preco;
        }
    }
}
