using System;

namespace _9_Classe_Abstrata
{
    class Program
    {
        static void Main(string[] args)
        {
            //O código abaixo não compila, pois não posso intanciar uma classe abstrata
            //Funcionario funcionario = new Funcionario();

            //Criando um dois professores
            Professor professor1 = new Professor("Professor1", "CPF do Professor1");
            professor1.Salario = 3000;

            Professor professor2 = new Professor("Professor2", "CPF do Professor2");
            professor2.Salario = 3200;

            Console.WriteLine("\nSalário do professor1 com bonificação: " + (professor1.calcularBonificacao() + professor1.Salario));
            Console.WriteLine("Salário do professor2 com bonificação: " + (professor2.calcularBonificacao() + professor2.Salario));

            //Criando um diretor
            Diretor diretor = new Diretor("Diretor", "CPF do diretor");
            diretor.Salario = 5000;

            Console.WriteLine("\nSalário do diretor com bonificação: " + (diretor.calcularBonificacao() + diretor.Salario));

            //Total de funcionários criados
            Console.WriteLine("\nTotal de funcionários criados: " + Funcionario.quantidadeFuncionarios);

            //Total de bonificação concedido
            Console.WriteLine("Total de bonificação concedido: " + Funcionario.totalBonificacao);
        }
    }
}
