using System;
using Caelum.Stella.CSharp.Inwords;

namespace _3_Moedas
{
    class Program
    {
        static void Main(string[] args)
        {
            //INSTALAREMOS O PACOTE CAELUM.STELLA.CSHARP PARA VALIDAÇÕES BRASILEIRAS

            //NUMEROS POR EXTENSO
            double valor = 75;
            string numeroPorExtenso = new Numero(valor).Extenso();

            //VALOR POR EXTENSO DE MOEDAS BRASILEIRAS
            string extensoBRL = new MoedaBRL(valor).Extenso();

            //TIPO MONEY
            Money moeda = 10.00; //R$10,00

            double valor1 = 25.00;
            double valor2 = 15.50;

            Money total = valor1 + valor2; //R$40,50

            //ALTERANDO A MOEDA
            Money euro = new Money(Currency.EUR, 1000);
            Money dolar = new Money(Currency.USD, 1000);
        }
    }
}
