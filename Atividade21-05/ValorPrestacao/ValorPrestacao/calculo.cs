using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValorPrestacao
{
    internal class calculo
    {
        public double prestacao_final(double x,double y,double z)
        {
            return (x + (x * (y / 100) * z))
;        }
    }
}
