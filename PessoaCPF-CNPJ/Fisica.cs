using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PessoaCPF_CNPJ
{
    class Fisica : Pessoa
    {
        public double Rg { get; set; }
        public double DataNascimento { get; set; }
        public string Cpf { get; set; }
        public Boolean validarCpf()
        {
            return this.Cpf.Length == 11;
        }

        
    }
}
