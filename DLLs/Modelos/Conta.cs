using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Conta
    {
        public Cliente Titular { get; private set; }
        public int Agencia { get; private set; }
        public int Numero { get; private set; }

        public Conta(Cliente titular, int agencia, int numero)
        {
            if(titular == null || agencia <= 0 || numero <= 0)
            {
                throw new ArgumentException();
            }
            else
            {
                this.Titular = titular;
                this.Agencia = agencia;
                this.Numero = numero;
            }
        }
    }
}
