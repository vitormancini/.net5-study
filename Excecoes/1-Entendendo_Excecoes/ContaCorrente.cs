using System;

namespace _1_Entendendo_Excecoes
{
    class ContaCorrente
    {
        public Cliente Titular { get; private set; }
        public int Numero { get; private set; }
        public int Agencia { get; private set; }
        public double Saldo { get; private set; }

        private static int quantidadeContas = 0;

        // A taxa de operação é baseada na quantidade de contas criadas
        public static double taxaOperacao { get; private set; }

        public ContaCorrente(Cliente titular, int agencia, int numero)
        {
            this.Titular = titular;
            this.Agencia = agencia;
            this.Numero = numero;
            quantidadeContas++;
        }

        // Método que calcula a taxa de operação
        public static double CalcularTaxaoperacao()
        {
            double taxa = 0;
            // Antes de fazer a divisão, precisamos nos certificar que não ocorrerá uma divisão por 0
            try
            {
                taxa = 30 / quantidadeContas;
            }
            catch(DivideByZeroException erro)
            {
                Console.WriteLine(erro.Message);
            }
            return taxa;
        }
    }
}
