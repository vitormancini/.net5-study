using System;
using System.Globalization;

namespace _2_Data_Hora
{
    class Program
    {
        static void Main(string[] args)
        {
            //CRIANDO UMA VARIÁVEL DO TIPO DATA
            DateTime data = new DateTime(2022, 09, 12);

            Console.WriteLine(data);

            //IMPRIMINDO A DATA SEM AS HORAS
            Console.WriteLine(data.ToString("d"));

            //DATA NO PADRÃO BRASILEIRO
            Console.WriteLine(data.ToString("d"), new CultureInfo("pt-BR"));

            //CRIANDO UMA VARIÁVEL DO TIPO DATA INFORMANDO TAMBÉM AS HORAS
            data = new DateTime(2022, 09, 12, 08, 32, 26);

            Console.WriteLine(data);

            //IMPRIMINDO APENAS AS HORAS
            Console.WriteLine(data.ToString("HH:mm:ss"));

            //EXIBINDO DATA POR EXTENSO
            Console.WriteLine(data.ToString("D"), new CultureInfo("pt-BR")); //Monday, September 12, 2022
            Console.WriteLine(data.ToString("m"), new CultureInfo("pt-BR")); //September 12
            Console.WriteLine(data.ToString("Y"), new CultureInfo("pt-BR")); //September 2022
        }
    }
}
