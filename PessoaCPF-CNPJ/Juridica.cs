using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PessoaCPF_CNPJ
{
    class Juridica : Pessoa
    {
        public double IscriçaoEstadual { get; set; }
        public string Endereço { get; set; }
        public string Cnpj { get; set; }

        public Boolean validarCnpj()
        {
            return this.Cnpj.Length == 14;
        }
    }
}
