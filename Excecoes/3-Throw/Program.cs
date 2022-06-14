using System;

namespace _3_Throw
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int resultado = Dividir(10, 0);
            }
            catch(Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }

        public static int Dividir(int numero, int divisor)
        {
            try
            {
                return numero / divisor;
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Divisão por 0");
                throw; // Jogando o erro para o main
            }
        }
    }
}
