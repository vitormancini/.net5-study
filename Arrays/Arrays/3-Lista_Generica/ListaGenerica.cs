using System;

namespace _3_Lista_Generica
{
    class ListaGenerica<T>
    {
        private T[] itens = new T[10];
        private int indiceAtual;

        public void Adicionar(T novoObjeto)
        {
            if(indiceAtual > 10)
            {
                throw new Exception("A capacidade máxima do array foi excedida");
            }
            else
            {
                itens[indiceAtual] = novoObjeto;
                indiceAtual++;
            } 
        }

        public void ExibirLista()
        {
            for(int i = 0; i < indiceAtual; i++)
            {
                Console.WriteLine($"Objeto[{i}]: {itens[i]}");
            }
        }
    }
}
