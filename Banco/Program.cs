using System;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria c1 = new ContaBancaria();
            c1.Nome_Cliente = Console.ReadLine();
            c1.Idade_Cliente = int.Parse(Console.ReadLine());
            c1.Numero_Conta = int.Parse(Console.ReadLine());
            c1.Saldo_Conta = double.Parse(Console.ReadLine());

        }
    }
}
