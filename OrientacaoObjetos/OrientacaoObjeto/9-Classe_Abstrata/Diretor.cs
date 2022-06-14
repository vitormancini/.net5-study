using System;

namespace _9_Classe_Abstrata
{
    class Diretor : Funcionario
    {
        public Diretor(string nome, string cpf) : base(nome, cpf)
        {
            Console.WriteLine("DIRETOR SENDO CRIADO");
        }

        public override double calcularBonificacao() //Diretor tem uma bonificação diferente, por isso sobreescrevo o método
        {
            double bonificacao = this.Salario * 0.15;
            calcularTotalBonificacao(bonificacao);
            return bonificacao;
        }
    }
}
