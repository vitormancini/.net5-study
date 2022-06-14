using System;

namespace _4_Escrita_Leitura_Binaria
{
    class Program
    {
        static void Main(string[] args)
        {
            LeitorEscritorBinario.EscritorBinario();
            ContaCorrente conta = LeitorEscritorBinario.LeitorBinario();

            Console.WriteLine($"Titular: {conta.Titular} - Agencia: {conta.Agencia} - Numero: {conta.Numero} - Saldo: {conta.Saldo}");
        }
    }
}
