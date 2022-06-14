using System;

namespace _5_Construtores
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciando um cliente e passando seu nome pelo método construtor
            Cliente vitor = new Cliente("Vítor");

            Console.WriteLine("Nome do Cliente criado: " + vitor.nome);
        }
    }
}
