using System;

namespace _1_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //DECLARANDO UM ARRAY QUANDO NÃO CONHEÇO SEUS ELEMENTOS. DEVO INFORMAR SEU TAMANHO
            string[] aulas2 = new string[3];

            //DECLARANDO UM ARRAY QUANDO JÁ CONHEÇO OS ELEMENTOS QUE ELE TERÁ
            string aula1 = "C#";
            string aula2 = "Java";
            string aula3 = "Python";

            string[] aulas = new string[]
            {
                aula1,
                aula2,
                aula3
            };

            Imprimir(aulas);

            //ENCONTRANDO O ÍNDICE DA PRIMEIRA OCORRÊNCIA DE UM ELEMENTO DENTRO DO ARRAY 
            int primeiraOcorrencia = Array.IndexOf(aulas, "Java");
            Console.WriteLine("ìndice da primeira ocorrência de Java: " + primeiraOcorrencia);

            //ENCONTRANDO O ÍNDICE DA ÚLTIMA OCORRÊNCIA DE UM ELEMENTO DENTRO DO ARRAY 
            int ultimaOcorrencia = Array.IndexOf(aulas, "C#");
            Console.WriteLine("ìndice da ultima ocorrência de C#: " + ultimaOcorrencia);

            //INVERTENDO O ORDEM DO ARRAY
            Array.Reverse(aulas);

            //REDIMENSIONANDO UM ARRAY (DIMINUIR OU AUMENTAR SEU TAMANHO)
            Array.Resize(ref aulas, 2);

            Imprimir(aulas);

            //CLONANDO O ARRAY
            string[] copia = aulas.Clone() as string[];

            Imprimir(copia);

            //LIMPANDO ELEMENTOS DO ARRAY (ARRAY, ÍNDICE INICIAL, QUANTIDADE DE ELEMENTOS)
            Array.Clear(copia, 1, 1);

            Imprimir(copia);
        }

        private static void Imprimir(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine();
        }
    }
}
