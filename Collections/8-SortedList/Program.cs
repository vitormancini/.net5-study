using System;
using System.Collections.Generic;

namespace _8_SortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //CRIANDO UM DICIONÁRIO DE ALUNOS QUE PERMITA ORDENAÇÃO DOS ELEMENTOS
            IDictionary<int, Aluno> alunos = new SortedList<int, Aluno>();

            //INSTANCIANDO ALUNOS
            Aluno a1 = new Aluno("Vítor");
            Aluno a2 = new Aluno("Lucas");
            Aluno a3 = new Aluno("Maria");

            alunos.Add(1, a1);
            alunos.Add(2, a2);
            alunos.Add(3, a3);

            Imprimir(alunos);

            //REMOVENDO LUCAS
            alunos.Remove(2);

            Imprimir(alunos);

            //ADICIONANDO MAIS UM ELEMENTO
            alunos.Add(4, new Aluno("Pedro"));

            Imprimir(alunos);
            //DICIONARIO COMUM, O ELEMENTO NOVO "PEDRO" OCUPARIA O LUGAR DO ELEMENTO REMOVIDO "LUCAS"
            //NO SORTED LIST, OS ELEMENTOS SÃO ORDENADOS PELA CHAVE, POR ISSO QUE O NOVO ELEMENTO FOI PARA O FINAL DA ORDEM
        }

        static void Imprimir(IDictionary<int, Aluno> dicionario)
        {
            foreach(var d in dicionario)
            {
                Console.WriteLine(d.Value.Nome);
            }
            Console.WriteLine();
        }
    }
}
