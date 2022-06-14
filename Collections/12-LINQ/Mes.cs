using System;

namespace _12_LINQ
{
    class Mes
    {
        public string Nome { get; private set; }
        public int Dias { get; private set; }

        public Mes (string nome, int dias)
        {
            this.Nome = nome;
            this.Dias = dias;
        }
    }
}
