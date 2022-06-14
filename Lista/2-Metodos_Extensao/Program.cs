using System;
using System.Collections.Generic;

namespace _2_Metodos_Extensao
{
    class Program
    {
        static void Main(string[] args)
        {
            //PODEMOS CRIAR UMA LISTA E UM MÉTODO ADICIONAL ATRAVÉS DE UMA CLASSE ESTÁTICA, QUE NOS PERMITE ADICIONAR VÁRIOS ELEMENTOS DE UMA SÓ VEZ
            List<int> idades = new List<int>();

            idades.Add(1);
            idades.Add(2);
            idades.Add(3);
            idades.Add(4);

            // ADICIONANDO VÁRIOS ELEMENTOS DE UMA SÓ VEZ ATRAVÉS DA NOSSA CLASSE ESTÁTICA DE EXTENSÃO, CHAMANDO O MÉTODO GENÉRICO
            idades.AdicionarVarios<int>(5, 6, 7, 8);

            foreach(int i in idades)
            {
                Console.WriteLine(i);
            }
        }
    }
}
