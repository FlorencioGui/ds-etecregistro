using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exemplo_Heranca
{
    internal class pessoa_fisica : pessoa
    {
        private double rg;

        public void setRg(double rg)
        {
            this.rg = rg;
        }
        public double getRg()
        {
            return this.rg;
        }
    }
}
