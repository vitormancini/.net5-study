using System;
using System.IO;

namespace _7_Bloco_Finally
{
    class Program
    {
        static void Main(string[] args)
        {
            CarregarContas();
        }

        private static void CarregarContas()
        {
            // Criando instância de arquivo
            LeitorDeArquivos leitor = null;

            // Lendo o conteúdo do arquivo
            try
            {
                leitor = new LeitorDeArquivos("Conteúdo do arquivo");

                leitor.LerConteudo();
                 
                leitor.FecharArquivo();
            }
            catch(IOException ex)
            {
                Console.WriteLine("Erro ocorrido: " + ex.Message);
            }
            finally
            {
                // O bloco finally sempre é executado, estourado uma exception ou não. Aproveito para fechar o arquivo dentro dele, pegando ou não a exception
                leitor.FecharArquivo();
            }
        }
    }
}
