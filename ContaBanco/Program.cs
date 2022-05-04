using System;

namespace ContaBanco
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria c1 = new ContaBancaria();
            Console.WriteLine("Digite Seu Nome: ");
            c1.Nome_Cliente = Console.ReadLine();
            Console.WriteLine("Digite sua Idade: ");
            c1.Idade_Cliente = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o numero da sua conta: ");
            c1.Numero_Conta = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite deu Saldo: ");
            c1.Saldo_Conta = double.Parse(Console.ReadLine());

            Console.WriteLine(c1);

            Console.WriteLine("Digite Valor do Seu Deposito: ");
            int ValorDepositado = int.Parse(Console.ReadLine());
            c1.DepositoConta(ValorDepositado);

            Console.WriteLine("Saldo Atualizado: ");
            Console.WriteLine(c1);

            Console.WriteLine("Digite um valor para Sacar: ");
            int valorSacar = int.Parse(Console.ReadLine());
            c1.SacaConta(valorSacar);

            Console.WriteLine("Saldo Atualizado: ");
            Console.WriteLine(c1);
        }
    }
}
