using System;

namespace _1_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarando um array com 5 posições de números inteiros
            int[] idades = new int[5];

            idades[0] = 15;
            idades[1] = 22;
            idades[2] = 25;
            idades[3] = 10;
            idades[4] = 51;

            Console.WriteLine("Idade no índice 0: " + idades[0]);
            Console.WriteLine("Idade no índice 1: " + idades[1]);
            Console.WriteLine("Idade no índice 2: " + idades[2]);
            Console.WriteLine("Idade no índice 3: " + idades[3]);
            Console.WriteLine("Idade no índice 4: " + idades[4]);

            //Array é um objeto de referência
            int[] novoArray = idades;

            Console.WriteLine("Valor no índice 2 do novoArray: " + novoArray[2]);

            //Pegando a quantidade de índices de uma array (tamanho) e iterando sobre um array
            int tamanho = idades.Length;
            for (int i = 0; i < tamanho; i++)
            {
                Console.WriteLine($"Índice {i}: {idades[i]}");
            }
        }
    }
}
