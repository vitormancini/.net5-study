using System;

namespace _2_Arquivo_para_Objeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Leitor leitor = new Leitor();

            string conteudoString = leitor.LerArquivo();

            var lista = leitor.ConverterStringParaContaCorrente(conteudoString);

            Console.WriteLine("Contas correntes instanciadas a partir do arquivo de texto:\n");

            foreach(ContaCorrente c in lista)
            {
                Console.WriteLine($"Titular: {c.Titular} - Agencia: {c.Agencia} - Numero: {c.Numero} - Saldo: {c.Saldo}");
            }
        }
    }
}
