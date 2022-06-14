using System;

namespace _4_Criando_Excecoes
{
    class ContaCorrente
    {
        public string Titular { get;  private set; }
        public int Agencia { get; private set; }
        public int Numero { get; private set; }

        public ContaCorrente(string titular, int agencia, int numero)
        {
            // Verifico se qualquer um dos argumentos passados ao construtor são inválidos
            if(titular == null || agencia == 0 || numero == 0)
            {
                // Lançando uma exceção
                Exception excecao = new Exception("Parâmetros de criação de conta são inválidos");
                throw excecao;

                /*
                 Lançando uma exceção mais específica para o exemplo

                ArgumentException argumentoExcecao = new ArgumentException("Dados de criação de conta são inválidos");
                throw argumentoExcecao;
                 */
            }
            else
            {
                this.Titular = titular;
                this.Agencia = agencia;
                this.Numero = numero;
            }
        }
    }
}
