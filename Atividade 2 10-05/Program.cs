using System;

namespace Atividade_2_10_05
{
    class Program
    {
        static void Main(string[] args)
        {
            char newalun;

            List<Alunos> alun = new List<Alunos>();
            do
            {
                Console.WriteLine("Digite o nome do Aluno");
                string nome = Console.ReadLine();

                Console.WriteLine("Digite a Idade do Aluno");
                int idade = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o Curso do Aluno");
                string curso = Console.ReadLine();

                alun.Add(new Alunos(nome, idade, curso));

                Console.Write("Cadastrar um novo Aluno? (s ou n)");
                newalun = char.Parse(Console.ReadLine());
            }
            while (newalun == 's');

            Console.WriteLine("########################################################");

            foreach (Alunos alu in alun)
            {
                Console.WriteLine(alu);
            }
            Console.WriteLine("########################################################");

            Console.WriteLine("Quantidade de Trabalhadores: " + alun.Count);

            int contador = 0;
            if (alun.Exists(x => x.Curso == "ti"))
            {
                foreach (Alunos alu in alun)
                {
                    contador++;
                }
                if (alun.Exists(x => x.Curso == "java"))
                {
                    contador++;
                }

                if (alun.Exists(x => x.Curso == "ti"))
                {
                    contador++;
                }
                if (alun.Exists(x => x.Curso == "c#"))
                {
                    contador++;
                }

                Console.WriteLine("Quantidade de Trabalhadores: " + alun.Curso);

            }
        }
    }
}
