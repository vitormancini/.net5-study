using System;

namespace Metodos_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string url1 = "moedaorigem=Real&moedaDestino=dolar";
            string url2 = "";

            //MÉTODO Substring(): captura uma string especificada a partir de um determinado index (inclusivo)
            string nova_url = url1.Substring(10);
            Console.WriteLine("Método Substring(): " + nova_url);

            //MÉTODO IsNullOrEmpty(): verifica se uma string é nula ou vazia
            Console.WriteLine("Verificando se url1 é nula ou vazia: " + String.IsNullOrEmpty(url1));
            Console.WriteLine("Verificando se url2 é nula ou vazia: " + String.IsNullOrEmpty(url2));

            //MÉTODO IndexOf(): retorna o índice da primeira ocorrência da letra ou expressão dentro de uma string
            //Caso não exista a letra ou expressão, retorna -1
            Console.WriteLine("Índice do caractere 'a' dentro da string url1: " + url1.IndexOf('a'));
            Console.WriteLine("Índice do caractere 'O' dentro da string url2: " + url2.IndexOf('O'));

            //CONVERTENDO UMA STRING PARA MAIÚSCULA
            Console.WriteLine("Método ToUpper(): " + url1.ToUpper());

            //CONVERTENDO UMA STRING PARA MINÚSCULA
            Console.WriteLine("Método ToUpper(): " + url1.ToLower());

            //MÉTODO CompareTo(): COMPARANDO STRINGS
            //RETORNA 0 QUANDO AS STRINGS FOREM IGUAIS E 1 QUANDO AS STRINGS FOREM DIFERENTES
            Console.WriteLine("Método CompareTo(): " + url1.CompareTo(url2));

            //MÉTODO Contains(): Verifica se uma string possui uma determinada expressão
            //Retrona true se encontrar e false se não encontrar
            Console.WriteLine("A string url1 possui a expressão Real: " + url1.Contains("Real"));
            Console.WriteLine("A string url2 possui a expressão Real: " + url2.Contains("Real"));

            //MÉTODO StartsWith(): retorna true se uma string começar com uma determinada letra ou expressão e retorna false se não começar
            Console.WriteLine("A string url1 inicia com a expressão 'mo': " + url1.StartsWith("mo"));
            Console.WriteLine("A string url2 inicia com a expressão 'mo': " + url2.StartsWith("mo"));

            //MÉTODO EndsWith(): retorna true se uma string terminar com uma determinada letra ou expressão e retorna false se não terminar
            Console.WriteLine("A string url1 termina com a expressão 'dolar': " + url1.EndsWith("dolar"));
            Console.WriteLine("A string url2 termina com a expressão 'dolar': " + url2.EndsWith("dolar"));

            //MÉTODO Replace(): substitui uma letra ou palavra por outra dentro da string
            Console.WriteLine("Substituindo a palavra 'dolar' por 'euro': " + url1.Replace("dolar", "euro"));

            //MÉTODO Split(): a string será dividida em uma determinada letra ou expressão e o resultado será um array de strings
            string[] arrayStrings = url1.Split('a');
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("Método Split(): " + arrayStrings[i]);
            } 

            //MÉTODO Trim(): remove os espaços do começo e do fim da string
            string texto = "  olá pessoal da Dell ";
            Console.WriteLine("Tamanho original do texto: " + texto.Length + " - Novo tamanho: " + texto.Trim().Length);
        }
    }
}
