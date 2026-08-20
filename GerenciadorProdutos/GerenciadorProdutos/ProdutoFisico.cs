using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorProdutos
{
    public class ProdutoFisico : Produto
    {
        public double PesoKg { get; set; }

        // Sobrecarga de construtores chamando o construtor base
        public ProdutoFisico(string nome, decimal precoBase, double pesoKg) : base(nome, precoBase)
            // Basicamente etamos importando as variáveis lá da nossa classe base, dessa forma, não precisamos redeclarar
        {
            PesoKg = pesoKg;
        }


        // Aqui estamos utilizando o polimorfismo sobreescrevendo o método abstrato da classe base
        // o produto físico possui o acrecimo de frete baseado no peso
        public override decimal CalcularPrecoFinal()
            // LEMBRAR DE PERGUNTAR AO PROFESSOR O PORQUÊ DEVEMOS DECLARAR INICIALMENTE O MÉTODO VAZIO NA NOSSA CLASSE BASE SENDO QUE POSTERIORMENTE
            // TEREMOS QUE SOBREESCREVER ELE. NÃO SERIA MAIS FÁCIL NÓS SIMPLISMENTE CRIARMOS O MÉTODO EM CADA CLASSE FILHA INDIVISUALMENTE?

            // SERÁ QUE ISSO É ASSIM POIS NÓS SEMPRE CHAMAREMOS A CLASSE BASE, E POR ISSO PRECISAMOS QUE O MÉTODO RETORNE QUANDO A CLASSE BASE FOR CHAMADA,
            // E COMO CADA PRODUTO POSSUI SUAS DIFERENÇAS, ELE TEM QUE SER SOBREESCRITO INDIVIDUALMENTE PARA TERMOS CALCULOS DIFERENTES
        {
            decimal frete = (decimal)(PesoKg * 2.50);
            return PrecoBase + frete;
        }

    }
}
