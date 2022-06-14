using System;
using System.Net.Http;

namespace _4_CEP
{
    class Program
    {
        static void Main(string[] args)
        {
            //CONSULTANDO CEPS NA API DO VIACEP
            string cep = "13291434";
            string url = "https://viacep.com.br/ws/" + cep + "/json/";

            //CASO QUEIRA RECEBER O RESULTADO NO FORMATO XML
            //string url = "https://viacep.com.br/ws/" + cep + "/xml/";
             
            string resultado = new HttpClient().GetStringAsync(url).Result;

            Console.WriteLine(resultado);
        }
    }
}
