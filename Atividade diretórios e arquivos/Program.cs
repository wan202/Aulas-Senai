using System;
using System.Collections.Generic;
using System.IO;

namespace Atividade_diretórios_e_arquivos
{
    class Program
    {
        static void Main(string[] args)
        {            
            IEnumerable<string> allFilesInAllFolders = Directory.EnumerateFiles(@"c:\WaN202", "*.txt", SearchOption.AllDirectories);

            Console.WriteLine("file:");
            foreach (var file in allFilesInAllFolders)
            {
                Console.WriteLine(file);
            }
        }
    }
}
