﻿using System;

namespace _4_Escrita_Leitura_Binaria
{
    class ContaCorrente
    {
        public string Titular { get; private set; }
        public int Numero { get; private set; }
        public int Agencia { get; private set; }
        public double Saldo { get; private set; }

        public ContaCorrente(string titular, int agencia, int numero, double saldo)
        {
            this.Titular = titular;
            this.Agencia = agencia;
            this.Numero = numero;
            this.Saldo = saldo;
        }
    }
}
