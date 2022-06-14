using System;

namespace _7_Heranca_Interface1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciando uma classe Diretor e acessando os métodos herdados de Funcionario
            Gerente gerente = new Gerente("123456789");

            gerente.Nome = "João";
            gerente.Salario = 4000;

            Console.WriteLine("Nome do diretor: " + gerente.Nome);
            Console.WriteLine("CPF do diretor: " + gerente.Cpf);
            Console.WriteLine("Salario do diretor: " + gerente.Salario);
            Console.WriteLine("Bonificação do salário: " + gerente.getBonificacao());

            Console.WriteLine("Total de funcionários: " + Funcionario.TotalFuncionarios);
        }
    }
}
