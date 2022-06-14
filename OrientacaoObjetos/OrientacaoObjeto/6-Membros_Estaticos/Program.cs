using System;

namespace _6_Membros_Estaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando duas instâncias da conta corrente
            ContaCorrente conta1 = new ContaCorrente();
            ContaCorrente conta2 = new ContaCorrente();

            Console.WriteLine("Quantidade de contas criadas: " + ContaCorrente.qtdContas);
        }
    }
}
