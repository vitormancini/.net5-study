using System;

namespace _7_Heranca_Interface1
{
    // A classe Gerente está herdando as características da classe Funcionario
    class Gerente : Funcionario
    {
        //Sobrecarga de construtor
        public Gerente(string cpf) : base(cpf) //Passando o cpf para a super classe (que é obrigatório)
        {
            Console.WriteLine("CRIANDO GERENTE");
        }

        // Sobreescrita do método getBonificacao de Funcionario
        public override double getBonificacao()
        {
            return this.Salario + base.getBonificacao(); 
        }
    }
}


