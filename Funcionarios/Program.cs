using System;
using System.Collections.Generic;

namespace Atividade_10_05
{
    class Program
    {
        static void Main(string[] args)
        {
            char newfunc;

            List<Funcionário> func = new List<Funcionário>();
            do
            {
                Console.WriteLine("Digite o nome de Funcionario");
                string nome = Console.ReadLine();

                Console.WriteLine("Digite a Idade do Funcionario");
                int idade = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite Qual Departamento");
                string departamento = Console.ReadLine();

                Console.WriteLine("Digite o Email do Funcionario");
                string email = Console.ReadLine();

                Console.WriteLine("Digite o Salario a Receber");
                double salario = double.Parse(Console.ReadLine());

                func.Add(new Funcionário(nome, idade, departamento, email, salario));

                Console.Write("Cadastrar um novo funcionario? (s ou n)");
                newfunc = char.Parse(Console.ReadLine());
            }
            while (newfunc == 's');

            Console.WriteLine("########################################################");

            foreach (Funcionário fnc in func)
            {
                Console.WriteLine(fnc);
            }
            Console.WriteLine("########################################################");

            Console.WriteLine("Quantidade de Trabalhadores: " + func.Count);

            int contador = 0;
            if (func.Exists(x => x.Departamento == "desing"))
            {
                foreach (Funcionário fnc in func)
                {
                    contador++;
                }
                if (func.Exists(x => x.Departamento == "rh"))
                {
                    contador++;
                }

                if (func.Exists(x => x.Departamento == "ti"))
                {
                    contador++;
                }
            }
        }

    }
}
