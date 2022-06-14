using System;

namespace _9_Classe_Abstrata
{
    class Professor : Funcionario
    {
        public Professor(string nome, string cpf) : base(nome, cpf)
        {
            Console.WriteLine("PROFESSOR SENDO CRIADO");
        }

        public override double calcularBonificacao()
        {
            calcularTotalBonificacao(base.calcularBonificacao());
            return base.calcularBonificacao(); //Professor tem a bonificação padrão da classe Funcionario, por isso apenas chamo o método da classe pai
        }
    }
}
