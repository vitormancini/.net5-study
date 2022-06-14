using System;
using System.Collections;
using System.Collections.Generic;

namespace _5_Dicionarios
{
    class Program
    {
        static void Main(string[] args)
        {
            //PERMITE ASSOCIAR UMA CHAVE A UM VALOR (CHAVE, VALOR)
            //NÃO PERMITE ELEMENTOS COM MESMA CHAVE
            //NÃO POSSUI ORDENAÇÃO
            IDictionary<int, Aluno> dicionarioAlunos = new Dictionary<int, Aluno>();

            //CRIANDO ALUNOS
            Aluno a1 = new Aluno("Vítor", 27);
            Aluno a2 = new Aluno("Lucas", 18);
            Aluno a3 = new Aluno("Maria", 32);

            //ADICIONANDO ALUNOS NO DICIONÁRIO
            dicionarioAlunos.Add(123, a1);
            dicionarioAlunos.Add(456, a2);
            dicionarioAlunos.Add(789, a3);

            //BUSCAR UM ALUNO PELO NÚMERO DE MATRÍCULA
            Aluno alunoEncontrado = BuscarAlunoMatriculado(dicionarioAlunos, 456);

            Console.WriteLine($"Aluno encontrado: {alunoEncontrado.Nome}");
        }

        private static Aluno BuscarAlunoMatriculado(IDictionary<int, Aluno> dicionario, int numeroMatricula)
        {
            Aluno aluno = null;
            dicionario.TryGetValue(numeroMatricula, out aluno);
            return aluno;
            //COMO PODE OCORRER DE TENTARMOS ENCONTRAR UM ALUNO POR UM NÚMERO DE MATRÍCULA INEXISTENTE
            //É PRECISO REALIZAR A BUSCA DESSA FORMA
        }
    }
 }

