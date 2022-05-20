using System;
using System.IO;

namespace IO
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string arquivoOrigem = @"c:\temp\novo2.txt";
            string arquivoDestino = @"c:\temp\novo3.txt";
            try
            {
                //FileInfo arquivoOrg = new FileInfo(arquivoOrigem);
                //arquivoOrg.CopyTo(arquivoDestino);

                string[] arquivoLido = File.ReadAllLines(arquivoOrigem);
                
                foreach(string  leitura in arquivoLido)
                {
                    Console.WriteLine(leitura);
                }

            }catch(IOException e)
            {
                Console.WriteLine("Um erro ocorreu! " + e.Message);
            }

            FileStream fs = null;
            StreamReader sr = null;

            try
            {
                fs = new FileStream(arquivoOrigem, FileMode.Open);
                sr = new StreamReader(fs);

                while (!sr.EndOfStream)
                {
                    string linha = sr.ReadLine();
                    Console.WriteLine(linha);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }

            finally
            {
                if (sr != null) sr.Close();
                if (fs != null) fs.Close();
            }*/

            /*string arquivoOrigem = @"c:\temp\novo2.txt";
            string arquivoDestino = @"c:\temp\novo3.txt";

            try
            {
                using (FileStream fs = new FileStream(arquivoOrigem, FileMode.Open))
                {
                    using (StreamReader rs = new StreamReader(fs))
                    {
                        while (!rs.EndOfStream)
                        {
                            string linha = rs.ReadLine();
                            Console.WriteLine(linha);
                        }
                    }
                }
            }catch(IOException e)
            {
                Console.WriteLine("Deu erro: ");
                Console.WriteLine(e.Message);
            }*/

            string arquivoOrigem = @"c:\temp\novo2.txt";
            string arquivoDestino = @"c:\temp\novo3.txt";

            try
            {
                string[] linhas = File.ReadAllLines(arquivoOrigem);
                using (StreamWriter sw = File.AppendText(arquivoDestino))
                {
                    foreach(string linha in linhas)
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
