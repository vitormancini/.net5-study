using System;
using System.Collections.Generic;

namespace _1_Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            // CRIANDO UMA LISTA DE STRINGS. PARA UTLIZAR AS LISTAS DO .NET PRECISAMOS IMPORTAR O System.Collections.Generic
            List<string> lista = new List<string>();

            // ADICIONANDO ELEMENTOS NA LISTA
            lista.Add("Vítor");
            lista.Add("Lucas");
            lista.Add("João");
            lista.Add("Pedro");
            lista.Add("Júlia");
            lista.Add("Carlos");

            //ITERANDO SOBRE A LISTA. O TAMANHO DA LISTA CONSEGUIMOS ATRAVÉS DO Count
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine($"Elemento {i}: {lista[i]}");
            }

            Console.WriteLine();

            // REMOVENDO UM ELEMENTO DA LISTA
            lista.Remove("Lucas");

            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine($"Elemento {i}: {lista[i]}");
            }

            // ORDENANDO A LISTA POR ORDEM ALFABÉTICA
            lista.Sort();

            Console.WriteLine("\nLista Ordenada:");

            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine($"Elemento {i}: {lista[i]}");
            }
        }
    }
}
