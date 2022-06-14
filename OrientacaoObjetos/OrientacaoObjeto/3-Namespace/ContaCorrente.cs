namespace _3_Namespace
{
    class ContaCorrente
    {
        public Cliente titular; // As classes Cliente e ContaCorrente estão dentro do mesmo Namespace (divisão lógica)
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

        // Método que não retorna nada
        public void Depositar(double valor)
        {
            this.saldo += valor;
        }
    }
}
