using System;
using System.IO;

namespace _8_Using
{
    class LeitorDeArquivos : IDisposable // Implementando a interface IDisposable, podemos utilizar a diretiva using
    {
        private string Mensagem { get;  set; }
        public LeitorDeArquivos(string conteudo)
        {
            if(conteudo == null)
            {
                throw new ArgumentException("conteudo do arquivo não deve ser null", nameof(conteudo));
            }
            else
            {
                this.Mensagem = conteudo;
            }
        }

        public void LerConteudo()
        {
            Console.WriteLine("Lendo conteúdo do arquivo");
            // Lançada uma exceção para qualquer erro que possa ocorrer durante a leitura do conteúdo do arquivo
            throw new FileNotFoundException();
        }

        // Método da interface
        public void Dispose()
        {
            Console.WriteLine("Fechando arquivo");
        }
    }
}
