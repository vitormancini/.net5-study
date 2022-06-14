using System;

namespace _5_Criando_Excecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                TestarExcecao();
            }
            catch(MinhaExcecao e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void TestarExcecao()
        {
            //MinhaExcecao minhaExcecao = new MinhaExcecao("Mensagem da minha exceção que acabou de ser disparada");
            throw new MinhaExcecao("Mensagem da minha exceção que acabou de ser disparada");
        }
    }
}
