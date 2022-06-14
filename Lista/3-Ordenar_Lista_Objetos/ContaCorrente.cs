using System;

namespace _3_Ordenar_Lista_Objetos
{
    class ContaCorrente : IComparable
    {
        public string Titular { get; private set; }
        public int Numero { get; private set; }
        public int Agencia { get; private set; }
        public double Saldo { get; private set; }

        public ContaCorrente(string titular, int agencia, int numero)
        {
            this.Titular = titular;
            this.Agencia = agencia;
            this.Numero = numero;
        }

        public void Depositar(double valor)
        {
            if(valor <= 0)
            {
                throw new ArgumentException(nameof(valor));
            }

            this.Saldo += valor;
        }

        // IMPLEMENTAÇÃO DO MÉTODO CompareTo() PERTENCENTE A INTERFACE IComparable
        public int CompareTo(object obj)
        {
            // RETORNAR NEGATIVO QUANDO A INSTÂNCIA PRECEDE O OBJ
            // RETORNAR ZERO QUANDO NOSSA INSTÂNCI E OBJ FOREM EQUIVALENTES 
            // RETORNAR POSITIVO E DIFERENTE DE ZERO QUANDO A PRECEDÊNCIA FOR DE OBJ

            ContaCorrente outraConta = obj as ContaCorrente;

            if(outraConta == null)
            {
                return -1;
            }

            // ORDENANDO POR SALDO

            if(this.Saldo < outraConta.Saldo)
            {
                return -1;
            }
            else if(this.Saldo == outraConta.Saldo)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
}
