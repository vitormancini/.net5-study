using System;
using System.IO;
using System.Text;

namespace _3_Criando_CSV
{
    class Escritor
    {
        public void CriarArquivo()
        {
            string caminhoArquivo = "contasExportadas.csv";

            // CRIANDO O ARQUIVO CSV
            var contaComoString = "Vítor Mancini,123,4567,1500.25";

            //FileMode.CreateNew NÃO PERMITE CRIAR UM NOVO ARQUIVO CASO UM ARQUIVO COM O MESMO NOME JÁ EXISTA
            using (var fluxoDeArquivo = new FileStream(caminhoArquivo, FileMode.Create))
            {
                using(var escritor = new StreamWriter(fluxoDeArquivo, Encoding.UTF8))
                {
                    escritor.Write(contaComoString);

                    //CASO EU DESEJE ESCREVER LINHA POR LINHA:
                    //escritor.WriteLine(contaComoString);
                    //escritor.Flush();
                }
            }

            Console.WriteLine("Arquivo criado com sucesso!");
        }
    }
}
