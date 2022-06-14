using System;

namespace _4_Criando_Excecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tentando instanciar a classe ContaCorrente com parâmetros inválidos
            try
            {
                ContaCorrente conta = new ContaCorrente(null, 0, 0);
            }
           catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
