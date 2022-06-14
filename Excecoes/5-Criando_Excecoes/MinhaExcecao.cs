using System;

namespace _5_Criando_Excecoes
{
    // Toda exceção deriva da super classe Exception
    class MinhaExcecao : Exception
    {
        public MinhaExcecao(string message) : base(message) // Passo a mensagem recebida para o construtor da super classe Exception
        {

        }

        // Sobrecarga de construtor
        public MinhaExcecao() { }
    }
}
