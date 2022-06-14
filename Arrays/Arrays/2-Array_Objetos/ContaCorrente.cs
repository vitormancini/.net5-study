using System;

namespace _2_Array_Objetos
{
    class ContaCorrente
    {
        public string Titular { get; private set; }
        public int Agencia { get; private set; }
        public int Numero { get; private set; }
        public double Saldo { get; private set; } //Lembrando que por padrão a variável é inicializada igual a 0

        public ContaCorrente(string titular, int agencia, int numero)
        {
            this.Titular = titular;
            this.Agencia = agencia;
            this.Numero = numero;
        }

        public void Depositar(double valor)
        {
            this.Saldo = this.Saldo + valor;
        }

        //Argumento params: podemos enviar para o método vários argumento de uma só vez
        public void RetornaConta(params ContaCorrente[] contas)
        {
            Console.WriteLine("Retornando contas a partir do método RetornaConta");

            foreach(ContaCorrente conta in contas)
            {
                Console.WriteLine($"Titular: {conta.Titular}");
            }
        }
    }
}
