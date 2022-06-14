using System;

namespace _9_Classe_Abstrata
{
    abstract class Funcionario // Uma classe abstrata não permite ser instanciada, apenas serve como modelo para as outras classes
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; set; }

        public static int quantidadeFuncionarios { get; private set; }
        public static double totalBonificacao { get; private set; }

        public Funcionario(string nome, string cpf)
        {
            this.Nome = nome;
            this.CPF = cpf;
            quantidadeFuncionarios++;
            Console.WriteLine("FUNCIONÁRIO SENDO CRIADO");
        }

        public virtual double calcularBonificacao()// Método que será sobrescrito pela classe que herdar a classe Funcionario
        {
            return this.Salario * 0.1;
        }

        protected void calcularTotalBonificacao(double bonificacao)
        {
            totalBonificacao += bonificacao;
        }
    }
}
