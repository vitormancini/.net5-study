using System;

namespace _11_Array_Multidimensional
{
    class Program
    {
        static void Main(string[] args)
        {
            //DECLARANDO UM ARRAY MULTIDIMENSIONAL
            string[,] resultados = new string[3,3]
            {
                { "Alemanha", "Espanha", "Itália" },
                { "Argentina", "Holanda", "França" },
                { "Holanda", "Alemanha", "Alemanha" }
            };

            Imprimir(resultados);

            //OUTRA FORMA DE POPULAR O ARRAY MULTIDIMENSIONAL
            resultados[0, 0] = "Alemanha";
            resultados[1, 0] = "Argentina";
            resultados[2, 0] = "Holanda";

            resultados[0, 1] = "Espanha";
            resultados[1, 1] = "Holanda";
            resultados[2, 1] = "Alemanha";

            resultados[0, 2] = "Itália";
            resultados[1, 2] = "França";
            resultados[2, 2] = "Alemanha";

            //DECLARANDO UM JAGGED ARRAY - DIMENSÃO DE COLUNAS INDEFINIDA, CADA LINHA PODE TER QUANTIDADE DE COLUNAS DIFERENTES
            string[][] jaggedArray = new string[3][];

            jaggedArray[0] = new string[]
            {
                "e1", "e2", "e3"
            };

            jaggedArray[1] = new string[]
            {
                "e4", "e4", "e6", "e6", "e8"
            };

            jaggedArray[2] = new string[]
            {
                "e9", "e10"
            };

            //IMPRIMINDO JAGGED ARRAY
            foreach(string[] j in jaggedArray)
            {
                Console.WriteLine(String.Join(",", j));
            }

        }
        static void Imprimir(string[,] array)
        {
            for(int i = 0; i < 3; i++)
            {
                int ano = 2014 - i * 4;
                Console.Write(ano.ToString().PadRight(12)); //TABULANDO COM 12 CARACTERES
            }
            Console.WriteLine();
            for(int x = 0; x <= array.GetUpperBound(0); x++) //GetUpperBound PEGA A DIMENSÃO DAS LINHAS DO ARRAY (NO CASO IGUAL A 3)
            {
                for (int i = 0; i <= array.GetUpperBound(1); i++) //GetUpperBound PEGA A DIMENSÃO DAS COLUNAS DO ARRAY (NO CASO IGUAL A 3)
                {
                    Console.Write(array[x, i].PadRight(12));
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
