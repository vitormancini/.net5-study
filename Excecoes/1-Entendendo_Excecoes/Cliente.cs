using System;

namespace _1_Entendendo_Excecoes
{
    class Cliente
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string  Profissao { get; set; }

        public Cliente(string nome, string cpf, string profissao)
        {
            this.Nome = nome;
            this.CPF = cpf;
            this.Profissao = profissao;
        }
    }
}
