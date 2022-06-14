using System;
using System.Collections.Generic;
using System.Linq;

namespace _12_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //CRIANDO UMA LISTA DE OBJETO MES
            List<Mes> lista = new List<Mes>()
            {
                new Mes("Janeiro", 31),
                new Mes("Fevereiro", 28),
                new Mes("Março", 31),
                new Mes("Abril", 30),
                new Mes("Maio", 31),
                new Mes("Junho", 30),
                new Mes("Julho", 31),
                new Mes("Agosto", 31),
                new Mes("Setembro", 30),
                new Mes("Outubro", 31),
                new Mes("Novembro", 30),
                new Mes("Dezembro", 31)
            };

            //FILTRANDO OS MESES QUE TÊM 31 DIAS
            IEnumerable<Mes> mesesCom31Dias = lista.Where(m => m.Dias == 31);

            Imprimir(mesesCom31Dias);

            //ORDENANDO A LISTA PELO NOME
            IEnumerable<Mes> listaOrdenadaPeloNome = lista.OrderBy(m => m.Nome);

            Imprimir(listaOrdenadaPeloNome);

            //CONVERTENDO OS NOMES PARA MAÍSCULOS
            IEnumerable<string> listaEmMaiscula = lista.Select(m => m.Nome.ToUpper());

            Console.WriteLine();

            foreach (string l in listaEmMaiscula)
            {
                Console.WriteLine(l);
            }

            Console.WriteLine();

            //OBTENDO OS MESES DO PRIMEIRO SEMESTRE
            IEnumerable<Mes> primeiroSemestre = lista.Take(6);

            Imprimir(primeiroSemestre);

            //OBTENDO OS MESES DO SEGUNDO SEMESTRE
            IEnumerable <Mes> segundoSemestre = lista.Skip(6);

            Imprimir(segundoSemestre);
        }

        static void Imprimir(IEnumerable<Mes> lista)
        {
            foreach(Mes m in lista)
            {
                Console.WriteLine(m.Nome + " - " + m.Dias);
            }
            Console.WriteLine();
        }
    }
}
