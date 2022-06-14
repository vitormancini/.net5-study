using System;
using System.Text.RegularExpressions;

namespace ExpressoesRegulares
{
    class Program
    {
        static void Main(string[] args)
        {
            //BUSCANDO UM NÚMERO DE TELEFONE DENTRO DE UMA STRING
            string texto = "Meu nome é Vítor, entre em contato pelo número 1999744-4684";

            string padraoTelefone = "[0-9]{7,9}-[0-9]{4}";

            //MÉTODO Regex.IsMatch(): retorna true se encontrar o padrão e false se não encontrar
            Console.WriteLine("Método Regex.IsMatch(): " + Regex.IsMatch(texto, padraoTelefone));

            //CAPTURANDO O RESULTADO
            Match resultado = Regex.Match(texto, padraoTelefone);
            Console.WriteLine("Número de telefone encontrado: " + resultado.Value);
        }
    }
}
