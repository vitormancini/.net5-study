using System;

namespace _3_Lista_Generica
{
    class Program
    {
        static void Main(string[] args)
        {
            //Podemos instanciar uma lista que aceite todo o tipo de objetos
            ListaGenerica<Pessoa> listaDePessoas = new ListaGenerica<Pessoa>();
            ListaGenerica<Carro> listaDeCarros = new ListaGenerica<Carro>();
            ListaGenerica<int> listaDeInteiros = new ListaGenerica<int>();

            //Adicionando elementos na lista do tipo Pessoa
            Pessoa p1 = new Pessoa("Vítor");
            Pessoa p2 = new Pessoa("João");
            Pessoa p3 = new Pessoa("Maria");

            Carro c1 = new Carro("Fusca");
            Carro c2 = new Carro("Ferrari");
            Carro c3 = new Carro("Vectra");

            try
            {
                listaDePessoas.Adicionar(p1);
                listaDePessoas.Adicionar(p2);
                listaDePessoas.Adicionar(p3);

                listaDeCarros.Adicionar(c1);
                listaDeCarros.Adicionar(c2);
                listaDeCarros.Adicionar(c3);

                listaDeInteiros.Adicionar(5);
                listaDeInteiros.Adicionar(6);
                listaDeInteiros.Adicionar(7);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            //Exibindo a lista
            listaDePessoas.ExibirLista();

            Console.WriteLine();

            listaDeCarros.ExibirLista();

            Console.WriteLine();

            listaDeInteiros.ExibirLista();
        }
    }
}
