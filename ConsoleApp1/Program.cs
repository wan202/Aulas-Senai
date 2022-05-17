using System;
using ConsoleApp1.Entities;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            FuncionarioN1 n1 = new FuncionarioN1();
            n1.Nome = "Alan";
            n1.Sexo = "Masculino";
            n1.Idade = "27";

            FuncionarioN2 n2 = new FuncionarioN2();
            n2.Nome = "Jaqueline";
            n2.Sexo = "Feminino";
            n2.Idade = "30";

            FuncionarioN3 n3 = new FuncionarioN3();
            n3.Nome = "Suenia";
            n3.Sexo = "Feminino";
            n3.Idade = "39";


            Console.WriteLine("Nome: " + n1.Nome + "Sexo; " + n1.Sexo + " Idade: " + n1.Idade + " Participação: " + n1.ParticipacaoLucro().ToString() + "\n");
            Console.WriteLine("Nome: " + n2.Nome + "Sexo; " + n2.Sexo + " Idade: " + n2.Idade + " Participação: " + n2.ParticipacaoLucro().ToString() + "\n");
            Console.WriteLine("Nome: " + n3.Nome + "Sexo; " + n3.Sexo + " Idade: " + n3.Idade + " Participação: " + n3.ParticipacaoLucro().ToString());
        }
    }
}
