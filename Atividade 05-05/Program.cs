using System;

namespace Atividade_05_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Soma calc = new Soma();
            double num;
            num = calc.Numero();
            Console.WriteLine(num.ToString());
        }
    }
}
