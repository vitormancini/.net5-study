namespace _2_Metodos
{
    class ContaCorrente
    {
        public string titular;
        public int agencia;
        public int numero;
        public double saldo = 1000;

        // Método da classe
        public bool Sacar(double valor)
        {
            if(this.saldo < valor)
            {
                return false;
            }
            else
            {
                this.saldo -= valor;
                return true;
            }
        }

        // Método que não retorna nada (void)
        public void Depositar(double valor)
        {
            this.saldo += valor;
        }
    }
}
