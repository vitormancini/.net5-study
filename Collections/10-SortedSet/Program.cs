using System;
using System.Collections.Generic;

namespace _10_SortedSet
{
    class Program
    {
        static void Main(string[] args)
        {
            //O SORTED SET PERMITE ORDENAÇÃO NA COLLECTION SET
            ISet<string> alunos = new SortedSet<string>()
            {
                "Vítor",
                "Lucas",
                "Maria",
                "João"
            };

            Imprimir(alunos);
            //PERCEBA QUE OS ELEMENTOS APARECERÃO ORDENADOS POR ORDEM ALFABÉTICA
        }

        static void Imprimir(ISet<string> set)
        {
            foreach(string s in set)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();
        }
    }
}
