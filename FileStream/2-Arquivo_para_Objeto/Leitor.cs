using System;
using System.Collections.Generic;
using System.IO;

namespace _2_Arquivo_para_Objeto
{
    class Leitor
    {
        public string LerArquivo()
        {
            var enderecoDoArquivo = "arquivo.txt";
            string conteudo = String.Empty;

            using (var fluxodoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
            {
                using (var leitor = new StreamReader(fluxodoArquivo))
                {
                    while (!leitor.EndOfStream)
                    {
                        var linha = leitor.ReadLine();
                        conteudo = conteudo + linha + "\n";
                    }
                }
            }
            return conteudo;
        }

        //MÉTODO QUE CONVERTE O CONTEÚDO DO ARQUIVO (STRING) EM UM OBJETO ContaCorrente
        public List<ContaCorrente> ConverterStringParaContaCorrente(string conteudo)
        {
            List<ContaCorrente> listaDeContas = new List<ContaCorrente>();

            //QUEBRANDO O CONTEÚDO POR LINHAS
            string[] linhas = conteudo.Split('\n');

            for(int i = 0; i < linhas.Length - 1; i++)
            {
                string[] conta = linhas[i].Split(' ');

                string titular = conta[0];
                //DEVEMOS CONVERTER O CONTEÚDO, QUE É UMA STRING, PARA AS VARIÁVEIS CORRESPONDENTES DE CADA PROPRIEDADE DA CLASSE ContaCorrente
                int agencia = int.Parse(conta[1]);
                int numero = int.Parse(conta[2]);
                double saldo = double.Parse(conta[3].Replace('.', ','));

                //INSTANCIANDO A CONTA COM O VALOR DA LINHA CORRESPONDENTE
                ContaCorrente novaConta = new ContaCorrente(titular, agencia, numero, saldo);

                //ADICIONANDO A CONTA NA LISTA
                listaDeContas.Add(novaConta);
            }

            return listaDeContas;
        }
    }
}
