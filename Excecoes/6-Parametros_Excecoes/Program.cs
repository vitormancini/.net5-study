using System;

namespace _6_Parametros_Excecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tentando instanciar uma conta com parâmetros inválidos no construtor
            try
            {
                Conta conta = new Conta("", 123, 45678);
            }
            catch(ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            // Instanciando uma conta de forma correta
            Conta conta2 = new Conta("Vitor", 123, 4567);
            Console.WriteLine("\nTitular: " + conta2.Titular);
            Console.WriteLine("Agencia: " + conta2.Agencia);
            Console.WriteLine("Numero: " + conta2.Numero);
            try
            {
                conta2.Depositar(500);
            }
            catch(ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Saldo: " + conta2.Saldo);

            // Tentando sacar mais do que tenho
            try
            {
                conta2.Sacar(600);
            }
            catch(SaldoInsuficienteException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                conta2.Sacar(650);
            }
            catch (SaldoInsuficienteException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Quantidade de tentativas de saques inválidos: " + Conta.TentativaSaquesInvalidos);
        }
    }
}
