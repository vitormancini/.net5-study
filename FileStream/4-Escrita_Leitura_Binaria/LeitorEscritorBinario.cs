using System;
using System.IO;

namespace _4_Escrita_Leitura_Binaria
{
    abstract class LeitorEscritorBinario
    {
        public static void EscritorBinario()
        {
            // ESCREVENDO UM CONTEÚDO BINÁRIO DENTRO DE UM ARQUIVO DE TEXTO
            using (var fs = new FileStream("arquivoBinario.txt", FileMode.Create))
            {
                using(var escritor = new BinaryWriter(fs))
                {
                    escritor.Write("Vítor Mancini");
                    escritor.Write(123);
                    escritor.Write(4567);
                    escritor.Write(1500.50);
                }
            }
        }

        public static ContaCorrente LeitorBinario()
        {
            //LENDO O CONTEÚDO DO ARQUIVO ESCRITO COM CONTEÚDO BINÁRIO
            using(var fs = new FileStream("arquivoBinario.txt", FileMode.Open))
            {
                using(var leitor = new BinaryReader(fs))
                {
                    string titular = leitor.ReadString();
                    int agencia = leitor.ReadInt32();
                    int numero = leitor.ReadInt32();
                    double saldo = leitor.ReadDouble();

                    ContaCorrente conta = new ContaCorrente(titular, agencia, numero, saldo);

                    return conta;
                }
            }
        }
    }
}
