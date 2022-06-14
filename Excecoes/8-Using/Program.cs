using System;

namespace _8_Using
{
    class Program
    {
        static void Main(string[] args)
        {
            // A diretiva using se responsabiliza por abrir, manipular o fechar o arquivo
            using(LeitorDeArquivos leitor = new LeitorDeArquivos("Conteúdo do arquivo"))
            {
                leitor.LerConteudo();
            }
        }
    }
}
