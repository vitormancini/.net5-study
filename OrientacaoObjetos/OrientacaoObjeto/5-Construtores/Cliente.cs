using System;

namespace _5_Construtores
{
    class Cliente
    {
        public string nome { get; set; }
        public string cpf { get; set; }
        public string  profissao { get; set; }

        //Quando uma classe Cliente for instanciada, será obrigatório informar o nome desse cliente que está sendo criado
        //Fazemos isso com o uso de métodos construtores, que possuem o mesmo nome da classe a que pertencem

        public Cliente(string nome)
        {
            this.nome = nome;
        }
    }
}
