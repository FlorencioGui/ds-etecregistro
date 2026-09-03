using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeCarrorevisao
{
    internal class ProdutoRevenda
    {
        public double custoAquisicao;
        public double margemLucro;

        public double precoVenda()
        {
            return custoAquisicao * (1 + margemLucro / 100);
        }

    }
}
