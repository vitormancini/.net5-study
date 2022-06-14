using System;

namespace _3_Lista_Generica
{
    class Pessoa
    {
        public string Nome { get; private set; }

        public Pessoa(string nome)
        {
            this.Nome = nome;
        }

        public override string ToString()
        {
            return this.Nome;
        }
    }
}
