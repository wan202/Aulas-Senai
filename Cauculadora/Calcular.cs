using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cauculadora
{
    class Calcular
    {
        public int Numero1 { get; set; }

        public int Numero2 { get; set; }

        public Calcular(int n1, int n2)
        {
            Numero1 = n1;
            Numero2 = n2;
        }

        public int Soma()
        {
            return Numero1 +Numero2;
        }

        public int Subtracao()
        {
            return Numero1 - Numero2;
        }

        public int Divisao()
        {
            return Numero1 / Numero2;
        }

        public int Multip()
        {
            return Numero1 * Numero2;
        }
    }
}
