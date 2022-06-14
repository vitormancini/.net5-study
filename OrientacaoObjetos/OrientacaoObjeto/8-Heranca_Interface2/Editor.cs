using System;

namespace _8_Heranca_Interface2
{
    class Editor : Funcionario
    {
        // Como a classe implementa o contrato da herença Funcionario, deve obrigatóriamente conter seus métodos e atributos
        public int Idade { get; set; }
        public string Nome { get; set; }

        public void Falar()
        {
            Console.WriteLine("O editor está falando...");
        }
    }
}

