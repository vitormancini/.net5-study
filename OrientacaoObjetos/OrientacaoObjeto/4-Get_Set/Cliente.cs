using System;

namespace _3_Namespace
{
    class Cliente
    {
        public string nome { get; set; } //O compilador cria um método privado nome e dois métodos publicos para o get e set desse método
        public string cpf;
        public string profissao;

        // Outra forma de se fazer os métodos acessores get e set
        public string telefone
        {
            get
            {
                return telefone;
            }
            set
            {
                if(value != null)
                {
                    telefone = value; //Value é uma palavra reservada do C# para referenciar o parâmetro recebido na instanciação da classe
                }
            }
        }
    }
}
