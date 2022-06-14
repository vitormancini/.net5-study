using System;

// Declarando namespaces externos
// Namespace é a divisão lógica do programa
using _3_Namespace;

namespace Namespace
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente vitor = new Cliente();

            vitor.nome = "Vítor";
            vitor.cpf = "123456789";
            vitor.profissao = "Programador";

            ContaCorrente conta = new ContaCorrente();

            conta.titular = vitor;
            conta.agencia = 123;
            conta.numero = 12345;

            // Composição de classes
            Console.WriteLine("Titular: " + conta.titular.nome);
            Console.WriteLine("CPF: " + conta.titular.cpf);
            Console.WriteLine("Agência: " + conta.agencia);
            Console.WriteLine("Número: " + conta.numero);
            Console.WriteLine("Saldo: " + conta.saldo);
        }
    }
}

