using System;

namespace _2_Variaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("AULA 2 - CRIANDO VARIÁVEIS\n");

            //-----------Variáveis do tipo int armazenam números inteiros-----------------------------

            int idade = 27;  

            Console.WriteLine("Valor da variável idade: " + idade);

            //----------- Variáveis do tipo double armazenam números decimais------------------

            double salario = 1250.25; 

            Console.WriteLine("Valor da variável salário: " + salario);

            // Uma variável do tipo double pode receber uma variável do tipo int, mas uma variável int não pode receber uma variável double

            //----------------Convertendo uma variável double para int (casting). Perdemos as casas decimais--------------------
            double numeroDecimal = 10.22;
            int numeroDecimalConvertido = (int)numeroDecimal;

            Console.WriteLine("Número decimal convertido para inteiro: " + numeroDecimalConvertido);

            //-----------Variáveis do tipo float precisamos indicar um f no final----------------

            float altura = 1.81f; 

            Console.WriteLine("Valor da variável altura: " + altura);

            //-----------Variáveis do tipo char armazenam caracteres---------------

            char letra = 'a';
            char letraConvertida = (char)65;

            Console.WriteLine("Letra convertida: " + letraConvertida);

            //----------Variáveis do tipo string armazenam textos-----------------

            string nome = "Vítor Mancini Rodrigues";

            Console.WriteLine("Minha string: " + nome);

            string cursos = @"Cursos disponíveis:
                * Java
                * C#
                * Python
                ";

            Console.WriteLine(cursos);
        }
    }
}
