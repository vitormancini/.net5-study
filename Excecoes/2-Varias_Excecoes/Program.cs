using System;

namespace _2_Varias_Excecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MeuMetodo(10, 0);
                Console.WriteLine("Método executado com sucesso!");
            }
            catch(DivideByZeroException erro)  // Estou criando um catch para cada possível erro que o método Divisao pode retornar
            {
                Console.WriteLine("Mensagem de erro: " + erro.Message);
            }
            catch(NullReferenceException erro)
            {
                Console.WriteLine("Mensagem de erro: " + erro.Message);
            }
        }

        static void MeuMetodo(int divisor, int dividendo)
        {
           int calculo =  divisor / dividendo;
           string nome = null;
           string nomeMaiusculo = nome.ToUpper();
        }
    }
}
