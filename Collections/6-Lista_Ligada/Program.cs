using System;
using System.Collections.Generic;

namespace _6_Lista_Ligada
{
    class Program
    {
        static void Main(string[] args)
        {
            //RECOMENDADA SER UTILIZADA QUANDO TEMOS UMA LISTA COM UM GRANDE FLUXO DE MUDANÇA NA ORDENAÇÃO DOS ELEMENTOS
            LinkedList<string> dias = new LinkedList<string>();

            //ADICIONANDO PRIMEIRO ELEMENTO
            var d1 = dias.AddFirst("domingo");
            Console.WriteLine($"Valor do nó d1: {d1.Value}");

            //ADICIONANDO UM ELEMENTO APÓS UM NÓ CONHECIDO
            var d2 = dias.AddAfter(d1, "segunda");
            Console.WriteLine($"Valor do nó d2: {d2.Value}");

            //ADICIONANDO O ÚLTIMO ELEMENTO
            var d7 = dias.AddLast("Sábado");
            Console.WriteLine($"Valor do nó d7: {d7.Value}");

            //ADICIONANDO UM ELEMENTO ANTES DE UM NÓ CONHECIDO
            var d6 = dias.AddBefore(d7, "sexta");
            Console.WriteLine($"Valor do nó d6: {d6.Value}");

            //PARA IMPRIMIR UMA LISTA LIGADA, PRECISAMOS USAR O FOREACH, E NÃO O FOR
            foreach(string dia in dias)
            {
                Console.WriteLine(dia);
            }

            //BUSCANDO UM ELEMENTO
            var segunda = dias.Find("segunda");
            Console.WriteLine(segunda.Value);

            //REMOVENDO UM ELEMENTO
            dias.Remove("Sábado");
        }
    }
}
