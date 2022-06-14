using System;

namespace _5_Construtores
{
    class ContaCorrente
    {
        public Cliente titular;
        public int agencia { get; set; }
        public int numero { get; set; }
        private double saldo;

        // Métodos get e set para saldo
        public double getSaldo()
        {
            return this.saldo;
        }

        public void setSaldo(double valor)
        {
            if(valor >= 0)
            {
                this.saldo = valor;
            }
        }
    }
}
