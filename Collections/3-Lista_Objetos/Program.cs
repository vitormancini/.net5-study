using System;
using System.Collections.Generic;
using System.Linq;

namespace _3_Lista_Objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Aula> aulas = new List<Aula>();

            //INSTANCIANDO OBJETOS AULA
            var aula1 = new Aula("C#", 60);
            var aula2 = new Aula("Java", 75);
            var aula3 = new Aula("Python", 15);

            //ADICIONANDO OBJETOS AULA NA LISTA
            aulas.Add(aula1);
            aulas.Add(aula2);
            aulas.Add(aula3);

            Imprimir(aulas);

            //ORDENANDO POR TITULO EM ORDEM ALFABÉTICA
            aulas.Sort();

            Imprimir(aulas);

            //ORDENANDO POR DURAÇÃO UTILIZANDO EXPRESSÃO LAMBDA
            aulas.Sort((este, outro) => este.Duracao.CompareTo(outro.Duracao));

            Imprimir(aulas);

            //UTILIZANDO LINQ PARA CALCULAR O TEMPO TOTAL DE AULAS
            int duracaoTotal = aulas.Sum(aula => aula.Duracao);

            Console.WriteLine($"\nTempo total de aulas: {duracaoTotal}");
        }

        private static void Imprimir(List<Aula> lista)
        {
            foreach(Aula a in lista)
            {
                Console.WriteLine($"Título: {a.Titulo} - Duração: {a.Duracao}");
            }
            Console.WriteLine();
        }
    }
}
