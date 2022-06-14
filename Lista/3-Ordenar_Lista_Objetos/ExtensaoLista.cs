using System.Collections.Generic;

namespace _3_Ordenar_Lista_Objetos
{
    public static class ExtensaoLista
    {
        public static void AdicionarVarios<T>(this List<T> lista, params T[] itens)
        {
            foreach (T i in itens)
            {
                lista.Add(i);
            }
        }
    }
}
