using System;

namespace _6_Parametros_Excecoes
{
    class Conta
    {
        public string Titular { get; private set; }
        public int Agencia { get; private set; }
        public int Numero { get; private set; }
        public double Saldo { get; private set; }

        public static int QuantidadeContas { get; private set; }

        public static int TentativaSaquesInvalidos { get; private set; }

        public Conta(string titular, int agencia, int numero)
        {
            // Verificando se todos os parâmetros foram passados corretamente ao construtor
            if(titular == null || titular == "")
            {
                throw new ArgumentException("Valor iválido para criação de uma conta", nameof(titular));
            }
            if(agencia == null || agencia <= 0)
            {
                throw new ArgumentException("Valor iválido para criação de uma conta", nameof(agencia));
            }
            if (numero == null || numero <= 0)
            {
                throw new ArgumentException("Valor iválido para criação de uma conta", nameof(numero));
            }

            this.Titular = titular;
            this.Agencia = agencia;
            this.Numero = numero;
            QuantidadeContas++;
        }

        public void Depositar(double valor)
        {
            if(valor <= 0)
            {
                // Se caso tentarem depositar um valor negativo ou igual a 0, uma exceção é disparada informando qual o parâmetro está sendo enviado de forma inválida
                throw new ArgumentException("Valor inválido para o depósito", nameof(valor));
            }
            else
            {
                this.Saldo += valor;
            }
        }

        public void Sacar(double valor)
        {
            if(valor <= 0)
            {
                throw new ArgumentException("Valor inválido para o saque", nameof(valor));
            }
            else if(valor > this.Saldo)
            {
                // Se alguem tentar sacar um valor maior do que o saldo disponivel, minha exceção será lançada
                TentativaSaquesInvalidos++;
                SaldoInsuficienteException saldoInsuficienteException = new SaldoInsuficienteException("O valor de saque é maior do que o saldo disponível na conta");
                throw saldoInsuficienteException;
            }
            else
            {
                this.Saldo -= valor;
            }
        }
    }
}
