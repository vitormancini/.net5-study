using System;

namespace _2_Array_Objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciando um array que armazena objetos do tipo ContaCorrente
            ContaCorrente[] contas = new ContaCorrente[] 
            {
                new ContaCorrente("Vítor", 123, 4567),
                new ContaCorrente("Lucas", 698, 3205),
                new ContaCorrente("Maria", 895, 0154)
            };

            //Não podemos declarar um array de objetos como declaramos array de inteiros, por exemplo
            //ContaCorrente[] contas = new ContaCorrente[3]
            //Dessa forma, caso não preenchessemos todo o array teríamos uma NullReferenceException

            contas[0].Depositar(1000.00);

            contas[1].Depositar(1500.00);

            contas[2].Depositar(500.00);

            //Iterando sobre o array
            for(int i = 0; i < contas.Length; i++)
            {
                Console.WriteLine($"Conta[{i}] => Titular: {contas[i].Titular} --- Agencia: {contas[i].Agencia} --- Número: {contas[i].Numero} --- Saldo: {contas[i].Saldo}");
            }

            //Iterando utilizando o foreach
            foreach(ContaCorrente conta in contas)
            {
                Console.WriteLine($"Conta => Titular: {conta.Titular} --- Agencia: {conta.Agencia} --- Número: {conta.Numero} --- Saldo: {conta.Saldo}");
            }

            //Chamando o método RetornaConta, que utiliza o recurso params
            ContaCorrente listaContas = new ContaCorrente("Lista", 555, 66666);
            listaContas.RetornaConta(
                new ContaCorrente("José", 444, 6666),
                new ContaCorrente("Pedro", 444, 6666),
                new ContaCorrente("Camila", 444, 6666),
                new ContaCorrente("João", 444, 6666)
                );
        }
    }
}
