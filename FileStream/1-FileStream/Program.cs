using System;
using System.IO;
using System.Text;

namespace _1_FileStream
{
    class Program
    {
        static void Main(string[] args)
        {

            // LENDO O CONTEÚDO DE UM ARQUIVO .TXT: QUANDO NÃO ESPECIFICADO O DIRETÓRIO, O ARQUIVO DEVE ESTAR NA PASTA bin/Debug
            var enderecoDoArquivo = "arquivo.txt";

            using(var fluxodoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
            {
                using (var leitor = new StreamReader(fluxodoArquivo))
                {
                    // LÊ O ARQUIVO INTEIRO
                    //var linha = leitor.ReadToEnd();

                    // LÊ LINHA POR LINHA DO ARQUIVO
                    while (!leitor.EndOfStream)
                    {
                        var linha = leitor.ReadLine();
                        Console.WriteLine(linha);
                    }
                }                        
            }
        }
    }
}
