using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXEMPLO_OO_METODO
{
    internal class Calculos_matematicos
    {
        //dntro dessa classe nos colocaremos o calculo dos números que lemos dentro da classe orignal (form 1)
        //Na última aula nos criamos o um método para armazenar o valor lido no fomr 1 para a classe, depois outro para calcular o que se devia e enviar de volta ao form 1
        public double calculo_soma(double x, double y, double w, double z)
        /*Para o metodo funcionar é nescessário informar os parametros("números nescessários para a formula matemátca funcionar"Quase como se você estivesse redeclarando as variávis aqui.)*/
        {
            return (x + y + w + z);
        }
        public double calculo_sub(double a, double b, double c, double d)
        {
            return(a - b - c - d);
        }
        public double calculo_mult(double e, double f, double g, double h)
        {
            return (e * f * g * h);
        }
        public double calculo_div(double i, double j, double k, double l)
        {
            return (i / j / k / l);
        }
    }
}
