using System;

namespace PessoaCPF_CNPJ
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();
            Fisica fis = new Fisica();
            Juridica juri = new Juridica();

            Console.WriteLine("############# Dados CPF #############");
            Console.WriteLine("Digite Seu Nome");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite Sua data de Nascimento");
            double DataNascimento = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite Seu Rg");
            double Rg = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite Seu CPF");
            double Cpf = double.Parse(Console.ReadLine());

            Console.WriteLine(""); 
            Console.WriteLine("############# Dados CNPJ #############");

            Console.WriteLine("Digite Seu Nome");
            nome = Console.ReadLine();

            Console.WriteLine("Digite Sua data de Nascimento");
            double Endereço = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite Seu Rg");
            double Cnpj = double.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("############# Info CPF #############");
            Console.WriteLine("Nome: " + pessoa.Nome);
            Console.WriteLine("Data de Nascimento: " + fis.DataNascimento);
            Console.WriteLine("RG: " + fis.Rg);
            Console.WriteLine("CPF: " + fis.Cpf);

            Console.WriteLine("############# Info CNPJ #############");
            Console.WriteLine("Nome: " + pessoa.Nome);
            Console.WriteLine("Inscrição Estatual: " + juri.IscriçaoEstadual);
            Console.WriteLine("CNPJ: " + juri.Cnpj);
            Console.WriteLine("Endereço: " + juri.Endereço);
        }
    }
}
