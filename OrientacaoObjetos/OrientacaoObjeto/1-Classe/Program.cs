using System;

namespace _1_Classe
{
    class Program
    {
        static void Main(string[] args)
        {
            // Como as classes ContaCorrente e Program pertencem ao mesmo namespace, não preciso declarar usando a diretiva using

            // Instanciando a classe ContaCorrente
            ContaCorrente conta = new ContaCorrente();

            // Acessando os atributos do objeto
            conta.titular = "Vítor";
            conta.agencia = 123;
            conta.numero = 102030;
            conta.saldo = 1254.20;

            Console.WriteLine("Titular: " + conta.titular);
            Console.WriteLine("Agência: " + conta.agencia);
            Console.WriteLine("Número: " + conta.numero);
            Console.WriteLine("Saldo: " + conta.saldo);

        }
    }
}
