using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_2_10_05
{
    class Alunos
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Curso { get; set; }

        public Alunos(string nome, int idade, string curso)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Curso = curso;
        }

        public override string ToString()
        {
            return "Nome: " + Nome +
                "\nIdade: " + Idade +
                "\nCurso: " + Curso;
        }
    }
}
