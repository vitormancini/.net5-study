using System;
using _3_Namespace;

namespace _4_Get_Set
{
    class Program
    {
        static void Main(string[] args)
        {
            // Neste programa vamos usar o conceito de encapsulamento (pivate - get e set)
            Cliente vitor = new Cliente();

            vitor.nome = "Vitor";
            vitor.cpf = "123456789";
            vitor.profissao = "Programador";
            vitor.telefone = "1965412358";

            ContaCorrente conta = new ContaCorrente();

            conta.titular = vitor;
            conta.agencia = 111;
            conta.numero = 01234;

            // Chamando o método encapsulado
            conta.setSaldo(1520.2);

            Console.WriteLine("Saldo da conta do " + conta.titular.nome + ": " + conta.getSaldo());
        }
    }
}
