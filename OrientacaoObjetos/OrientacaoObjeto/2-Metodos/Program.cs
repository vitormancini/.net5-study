using System;

namespace _2_Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();

            conta.titular = "Vitor";

            Console.WriteLine("Saldo da conta do Vitor: " + conta.saldo);

            //Sacando 200 reais da conta
            bool resultadoSaque = conta.Sacar(200);

            if(resultadoSaque)
            {
                Console.WriteLine("Saldo da conta do Vitor após o saque: " + conta.saldo);
            }
            else
            {
                Console.WriteLine("Vitor não tem saldo sufuciente para sacar esse valor");
            }

            //Depositando 80 reais
            conta.Depositar(80);

            Console.WriteLine("saldo da conta do Vitor após o depósito: " + conta.saldo);
        }
    }
}
