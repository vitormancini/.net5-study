using System;

namespace Sistema_Locadora_Filmes
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie m1 = new Movie("Filme1", 120, "Autor1", 1900);
            Movie m2 = new Movie("Filme2", 120, "Autor2", 1900);

            Movie.RegisterMovie(m1.Id, m1.Title, m1.Duration, m1.Director, m1.Year);
            Movie.RegisterMovie(m2.Id, m2.Title, m2.Duration, m2.Director, m2.Year);
        }
    }
}
