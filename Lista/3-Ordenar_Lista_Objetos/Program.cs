using System;
using System.Collections.Generic;
using System.Linq;

namespace _3_Ordenar_Lista_Objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            //ORDENAREMOS UMA LISTA DE ContaCorrente
            var lista = new List<ContaCorrente>();

            ContaCorrente c1 = new ContaCorrente("Vítor", 123, 4567);
            c1.Depositar(1000.00);

            ContaCorrente c2 = new ContaCorrente("Lucas", 789, 4587);
            c2.Depositar(900.00);

            ContaCorrente c3 = new ContaCorrente("Pedro", 789, 4587);
            c3.Depositar(1200.00);

            ContaCorrente c4 = new ContaCorrente("João", 789, 4587);
            c4.Depositar(500.00);

            //ADICIONANDO AS CONTAS NA LISTA UTILIZANDO UM MÉTODO DE EXTENSÃO
            lista.AdicionarVarios<ContaCorrente>(c1, c2, c3, c4);

            //EXIBINDO A LISTA NÃO ORDENADA
            foreach(ContaCorrente conta in lista)
            {
                Console.WriteLine($"({conta.Titular}, {conta.Numero}, {conta.Agencia}, {conta.Saldo})");
            }

            // ORDENANDO A LISTA PELO SALDO DAS CONTAS. PARA ISSO, IMPLEMENTAMOS A INTERFACE IComparable NA NOSSA CLASSE ContaCorrente
            lista.Sort();

            Console.WriteLine();

            //EXIBINDO A LISTA ORDENADA
            foreach (ContaCorrente conta in lista)
            {
                Console.WriteLine($"({conta.Titular}, {conta.Numero}, {conta.Agencia}, {conta.Saldo})");
            }

            //MÉTODO Where(): FILTRA VALORES (FILTRANDO VALORES NÃO NULOS)
            IEnumerable<ContaCorrente> listaDeValoresNaoNulos = lista.Where(conta => conta.Titular != null);

            // ORDENANDO A LISTA PELO NOME DOS TITULARES (ORDEM ALFABÉTICA) ATRAVÉS DO MÉTODO OrderBy() -> EXPRESSÃO LAMBDA
            // O MÉTODO OrderBy() NÃO VERIFICA VALORES NULOS, POR ISSO FILTRAMOS COM O Where() ANTES
            IOrderedEnumerable<ContaCorrente> listaOrdenadaPeloTitular = lista.OrderBy(conta => { return conta.Titular; });

            Console.WriteLine();

            foreach (ContaCorrente conta in listaOrdenadaPeloTitular)
            {
                Console.WriteLine($"({conta.Titular}, {conta.Numero}, {conta.Agencia}, {conta.Saldo})");
            }
        }
    }
}
