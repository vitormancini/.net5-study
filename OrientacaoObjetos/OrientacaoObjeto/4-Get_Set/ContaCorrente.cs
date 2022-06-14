using System;

namespace _3_Namespace
{
    class ContaCorrente
    {
        public Cliente titular; // As classes Cliente e ContaCorrente estão dentro do mesmo Namespace (divisão lógica)
        public int agencia;
        public int numero;
        private double saldo;

       // Método que retorna o valor do saldo
       public double getSaldo()
        {
            return this.saldo;
        }

        // Método que define o valor de saldo
        public void setSaldo(double valor)
        {
            if(valor >= 0)
            {
                this.saldo = valor;
            }
        }
    }
}
