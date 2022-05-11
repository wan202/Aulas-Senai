using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_10_05
{
    class Funcionário
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Departamento { get; set; }
        public string Email { get; set; }
        public double Salario { get; set; }

        public Funcionário()
        {

        }

        public Funcionário(string nome, int idade, string departamento, string email, double salario)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Departamento = departamento;
            this.Email = email;
            this.Salario = salario;
        }

        public override string ToString()
        {
            return "Nome: " + Nome +
                "\nIdade: " + Idade +
                "\nDepartamento: " + Departamento +
                "\nEmail: " + Email +
                "\nSalario: " + Salario;
        }


    }
}
