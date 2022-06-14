using System;
using System.Collections.Generic;

namespace _7_Fila
{
    class Program
    {
        static void Main(string[] args)
        {
            // FILAS UTILIZAM O CONCEITO DO FIFO? FIRST IN FIRST OUT

            //CRIANDO UMA FILA DE STRINGS
            Queue<string> fila = new Queue<string>();

            //ADICIONANDO ELEMENTOS NA FILA
            fila.Enqueue("Fusca");
            fila.Enqueue("Van");
            fila.Enqueue("Ferrari");
            fila.Enqueue("Brasilia");

            Imprimir(fila);

            //REMOVENDO ELEMENTOS
            fila.Dequeue();
            fila.Dequeue();

            Imprimir(fila);

            //SABER QUAL O PRÓXIMO ELEMENTO QUE SERIA REMOVIDO
            Console.WriteLine("O próximo elementos que seria removido seria o " + fila.Peek());
        }

        static void Imprimir(Queue<string> fila)
        {
            foreach(string l in fila)
            {
                Console.WriteLine(l);
            }
            Console.WriteLine();
        }
    }
}
