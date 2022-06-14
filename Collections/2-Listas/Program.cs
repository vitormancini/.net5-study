using System;
using System.Collections.Generic;
using System.Linq;

namespace _2_Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            //DECLARANDO UMA LISTA
            List<string> aulas = new List<string>();

            //ADICIONANDO ELEMENTOS NA LISTA
            aulas.Add("C#");
            aulas.Add("Java");
            aulas.Add("Python");
            aulas.Add("Javascript");

            Imprimir(aulas);

            //ENCONTRANDO EXPRESSÕES DENTRO DA LISTA (PRIMEIRA E ULTIMA OCORRÊNCIAS)
            try
            {
                Console.WriteLine("A primeira ocorrência da expressão 'Ja' é: " + aulas.First(aulas => aulas.Contains("Ja")));
                Console.WriteLine("A última ocorrência da expressão 'Py' é: " + aulas.Last(aulas => aulas.Contains("Py")));
            }
            catch(InvalidOperationException e)
            {
                Console.WriteLine("Expressão não encontrada em nenhum elemento da lista");
            }

            Console.WriteLine();

            //INVERTENDO A LISTA
            aulas.Reverse();

            Imprimir(aulas);

            //REMOVENDO UM ELEMENTO
            aulas.RemoveAt(2); //POR POSIÇÃO
            aulas.Remove("C#"); //POR ELEMENTO

            Imprimir(aulas);

            //COPIANDO A LISTA (POSIÇÃO INICIAL, QUANTIDADE DE ELEMENTOS)
            List<string> copia = aulas.GetRange(0, aulas.Count);

            Imprimir(copia);
        }

        private static void Imprimir(List<string> lista)
        {
            for(int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i]);
            }
            Console.WriteLine();
        }
    }
}
