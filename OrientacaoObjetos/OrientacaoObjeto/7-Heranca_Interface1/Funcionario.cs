using System;

namespace _7_Heranca_Interface1
{
    // A classe Funcionario servirá como uma classe mãe para a classes (super classe) que a herdarem (classe filhas)
    class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public double Salario { get; set; }

        public static int TotalFuncionarios { get; private set; }

        // Construtor
        public Funcionario(string cpf)
        {
            this.Cpf = cpf;
            Console.WriteLine("CRIANDO FUNCIONARIO");
            TotalFuncionarios++;
        }

        // O método que recebe sobreescrita deve ser declarado como virtual
        public virtual double getBonificacao()
        {
            return this.Salario * 0.1;
        }
    }
}

