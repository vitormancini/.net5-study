using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos; // Utilizando o namespace da biblioteca Modelos

namespace _1_Conectando_Biblioteca
{
    class Program
    {
        static void Main(string[] args)
        {
            // Consigo instanciar lasses da biblioteca
            Cliente cliente = new Cliente("Vítor", "123456789", "Programador");
            Conta conta = new Conta(cliente, 123, 45678);

            Console.WriteLine("Titular: " + conta.Titular.Titular);
            Console.WriteLine("CPF: " + conta.Titular.CPF);
            Console.WriteLine("Profissao: " + conta.Titular.Profissao);
            Console.WriteLine("Agência: " + conta.Agencia);
            Console.WriteLine("Numero: " + conta.Numero);

            // Causando uma Exception (a biblioteca deve estar prparada para tratar)
            try
            {
                Cliente cliente2 = new Cliente(null, null, null);
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine("\nException enviada pela biblioteca Modelos: " + ex.Message);
            }
        }
    }
}
