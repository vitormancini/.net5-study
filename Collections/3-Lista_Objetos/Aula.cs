using System;

namespace _3_Lista_Objetos
{
    //PARA QUE SEJA POSSÍVEL ORDENAR UMA LISTA DE OBJETOS, PRECISAMOS IMPLEMENTAR A INTERFACE IComparable
    class Aula : IComparable
    {
        public string Titulo { get; private set; }
        public int Duracao { get; private set; }

        public Aula(string titulo, int duracao)
        {
            this.Titulo = titulo;
            this.Duracao = duracao;
       }

        //MÉTODO NECESSÁRIO QUANDO A CLASSE IMPLEMENTA IComparable
        public int CompareTo(object obj)
        {
            //ORDRENANDO O TITULO DAS AULAS POR ORDEM ALFABÉTICA
            Aula that = obj as Aula;
            return this.Titulo.CompareTo(that.Titulo);
        }
    }
}
