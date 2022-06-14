using System;

namespace _1_Entendendo_Excecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente("Vítor", "123456789", "Programador");

            // Ainda não temos nenhuma conta criado, vamos tentar calcular a taxa de operação
            double taxa = ContaCorrente.CalcularTaxaoperacao();

            // Agora vamos criar uma conta e tentar calcular a taxa novamente
            ContaCorrente conta = new ContaCorrente(cliente, 123, 12345);
            taxa = ContaCorrente.CalcularTaxaoperacao();

            Console.WriteLine("Valor da taxa de Operação: " + taxa);
        }
    }
}
