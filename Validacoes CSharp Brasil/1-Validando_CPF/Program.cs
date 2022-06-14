using Caelum.Stella.CSharp.Validation;
using System;

namespace _1_Validando_CPF
{
    class Program
    {
        static void Main(string[] args)
        {
            //INSTALAREMOS O PACOTE CAELUM.STELLA.CSHARP PARA VALIDAÇÕES BRASILEIRAS

            //VALIDAÇÃO DE CPF
            string cpf1 = "41238905803";
            string cpf2 = "86288366757";
            string cpf3 = "22222222222";
            string cpf4 = "412.389.058-03";

            Console.WriteLine(ValidarCPF(cpf1));  //VALIDO
            Console.WriteLine(ValidarCPF(cpf2)); //VALIDO
            Console.WriteLine(ValidarCPF(cpf3)); //INVALIDO
            Console.WriteLine(ValidarCPF(cpf4)); //VALIDO

            Console.WriteLine();

            //VALIDAÇÃO DE CNPJ
            string cnpj1 = "58.623.065/0001-73";
            string cnpj2 = "58623065000173";
            string cnpj3 = "11111111111111";

            Console.WriteLine(ValidarCNPJ(cnpj1)); //VALIDO
            Console.WriteLine(ValidarCNPJ(cnpj2)); //VALIDO
            Console.WriteLine(ValidarCNPJ(cnpj3)); //INVALIDO

            Console.WriteLine();

            //VALIDAÇÃO DE TITULO ELEITORAL
            string titulo1 = "041375570132";
            string titulo2 = "774387480132";

            Console.WriteLine(ValidatTitulo(titulo1)); //INVALIDO
            Console.WriteLine(ValidatTitulo(titulo2)); //VALIDO
        }

        private static bool ValidarCPF(string cpf)
        {
            return new CPFValidator().IsValid(cpf);
        }

        private static bool ValidarCNPJ(string cnpj)
        {
            return new CNPJValidator().IsValid(cnpj);
        }

        private static bool ValidatTitulo(string titulo)
        {
            return new TituloEleitoralValidator().IsValid(titulo);
        }
    }
}
