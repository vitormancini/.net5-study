using System;

namespace _6_Parametros_Excecoes
{
    class SaldoInsuficienteException : Exception
    {
        public SaldoInsuficienteException(string message) : base(message)
        {

        }

        public SaldoInsuficienteException() { }
    }
}
