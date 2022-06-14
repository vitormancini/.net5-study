using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Bloco_Finally
{
    class LeitorDeArquivos
    {
        private string Mensagem { get;  set; }
        public LeitorDeArquivos(string conteudo)
        {
            if(conteudo == null)
            {
                throw new ArgumentException("Conteudo do arquivo não deve ser null", nameof(conteudo));
            }
            else
            {
                this.Mensagem = conteudo;
            }
        }

        public void LerConteudo()
        {
            Console.WriteLine("Lendo conteúdo do arquivo");
            // Lanço uma exceção para qualquer erro que possa ocorrer durante a leitura do conteúdo do arquivo
            throw new IOException();
        }

        public void FecharArquivo()
        {
            Console.WriteLine("Fechando arquivo");
        }
    }
}
