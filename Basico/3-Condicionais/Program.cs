using System;

namespace _3_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("AULA 3 - CONDICIONAIS IF/ELSE\n");

            int idade = 16;
            bool acompanhado = true; // Variável do tipo bool armazena true ou false

            // O usuário apenas pode acessar o sistema se sua idade for maior ou igual a 18. Se for menor que 18, pode entrar simente se estiver acompanhado;

            if (idade >= 18)
            {
                Console.WriteLine("Acesso permitido! Você é maior de idade");
            }
            else if (idade < 18 && acompanhado == true)
            {
                Console.WriteLine("Acesso permitido! Você é menor de idade, mas está acompanhado");
            }
            else 
            {
                Console.WriteLine("Acesso negado! Você é menor de idade e não está acompanhado");
            }
        }
    }
}


