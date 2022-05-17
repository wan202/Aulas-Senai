using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entities
{
    class Funcionario
    {
        public string Nome { get; set; }
        public string Sexo { get; set; }
        public string Idade { get; set; }
        public Funcionario()
        {

        } 
        public Funcionario(string nome, string sexo, string idade)
        {
            Nome = nome;
            Sexo = sexo;
            Idade = idade;
        }
        public virtual double ParticipacaoLucro()
        {
            return 1500;
        }
    }
}
