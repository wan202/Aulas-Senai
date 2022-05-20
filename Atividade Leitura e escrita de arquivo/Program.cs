using System;
using System.IO;

namespace Atividade_Leitura_e_escrita_de_arquivo
{
    class Program
    {
        static void Main(string[] args)
        {
            string arquivoOrigem = @"c:\temp\Produtos.txt";
            string arquivoDestino = @"c:\temp\copia\CpProduto.txt";

            try
            {
                string[] linhas = File.ReadAllLines(arquivoOrigem);
                using (StreamWriter sw = File.AppendText(arquivoDestino))
                {
                    foreach (string linha in linhas)
                    {
                        sw.WriteLine(linha.ToUpper());
                        Console.WriteLine(linha);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("erro: " + e.Message);
            }
        }
    }
}
