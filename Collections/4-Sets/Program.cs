using System;
using System.Collections.Generic;

namespace _4_Sets
{
    class Program
    {
        static void Main(string[] args)
        {
            //UM SET NÃO PERMITE DUPLICIDADE DE ELEMENTOS E NÃO POSSUEM ORDENAÇÃO
            //É MAIS PERFORMÁTICO QUE AS LISTAS QUANDO VAMOS BUSCAR ELEMENTOS (TABELA DE ESPALHAMENTO)

            //DECLARANDO UM SET DE STRINGS
            ISet<string> alunos = new HashSet<string>();

            //ADICIONANDO ELEMENTOS
            alunos.Add("Vítor Mancini");
            alunos.Add("Lucas Martins");
            alunos.Add("Maria Oliveira");
            alunos.Add("Caio Passos");
            alunos.Add("Pricila Cardoso");

            //IMPRIMINDO
            Console.WriteLine(String.Join(",", alunos));

            //REMOVENDO UM ELEMENTO
            alunos.Remove("Lucas Martins");

            Console.WriteLine(String.Join(",", alunos));

            //QUANDO QUEREMOS ORDENAR UM SET, DEVEMOS COPIAR PARA UMA LISTA ANTES
            List<string> alunosEmLista = new List<string>(alunos);
            alunosEmLista.Sort();

            Console.WriteLine(String.Join(",", alunosEmLista));

            //CHECANDO SE UM ELEMENTO EXISTE NO SET (RETORNA TRUE OU FALSE)
            Console.WriteLine("O aluno Caio Passos está matriculado? " + alunos.Contains("Caio Passos"));

            //COMPARANDO DOIS ELEMENTOS (RETORNA TRUE OU FALSE)
            Console.WriteLine("Vítor Mancini é igual à vitor mancini? " + alunos.Equals("vitor mancini"));
        }
    }
}
