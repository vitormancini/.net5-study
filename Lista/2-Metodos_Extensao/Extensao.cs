using System.Collections.Generic;

namespace _2_Metodos_Extensao
{
    public static class Extensao   //CLASSE ESTÁTICA, POIS NÃO PRECISA SER INSTANCIADA E SEUS MÉTODOS SERÃO ESTÁTICOS
    {
        public static void AdicionarVarios<T>(this List<T> listaInteiros, params T[] itens)   // MÉTODO GENÉRICO
        {
            foreach(T i in itens)
            {
                listaInteiros.Add(i);
            }
        }
    }
}
