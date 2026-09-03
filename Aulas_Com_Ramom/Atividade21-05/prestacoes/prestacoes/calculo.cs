using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prestacoes
{
    internal class calculo
    {
        public double calculo_valor_pago(double x, double y)
        {
            return (x * y);
        }

        public double calculo_valor_devendo(double x, double y, double z)
        {
            return ((x-y)*z);
        }
    }
}
