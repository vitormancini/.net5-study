using System;

namespace _8_Heranca_Interface2
{
    public interface Funcionario
    {
        // As interfaces não exigem implementação do métodos, servem apenas como um contrato com as classes que a implementam
        public string Nome { get; set; }
        public int Idade { get; set; }

        public void Falar();
    }
}
