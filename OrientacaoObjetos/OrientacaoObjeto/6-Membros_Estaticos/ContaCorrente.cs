using System;

namespace _6_Membros_Estaticos
{
    class ContaCorrente
    {
        public string titular { get; set; }
        public int agencia { get; set; }
        public int numero { get; set; }
        private double saldo;

        // Atributos e métodos estáticos são exclusivos da classe, e não do objeto. Ou seja, todas as intâncias da classe compartilham
        public static int qtdContas { get; private set; }
        
        // Método construtor: sempre que uma classe ContaCorrente for instanciada, incremento o atributo qtdContas
        public ContaCorrente()
        {
            qtdContas++;
        }

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
