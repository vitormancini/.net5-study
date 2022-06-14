using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Sistema_Locadora_Filmes
{
    class Movie
    {
        public static int IdController { get; private set; }
        public int Id { get; private set; }
        public string Title { get; private set; }
        public int Duration { get; private set; }
        public string Director { get; private set; }
        public int Year { get; private set; }

        public static List<Movie> movieList = new List<Movie>();

        public Movie(string title, int duration, string director, int year)
        {
            if(String.IsNullOrEmpty(title))
            {
                throw new ArgumentException("Título não deve estar vazio", nameof(title));
            }
            if (String.IsNullOrEmpty(director))
            {
                throw new ArgumentException("Diretor não deve estar vazio", nameof(director));
            }

            this.Id = IdController;
            this.Title = title;
            this.Duration = duration;
            this.Director = director;
            this.Year = year;

            IdController++;
        }

        public static void RegisterMovie(int id, string title, int duration, string director, int year)
        {
            if (String.IsNullOrEmpty(title))
            {
                throw new ArgumentException("Título não deve estar vazio", nameof(title));
            }
            if (String.IsNullOrEmpty(director))
            {
                throw new ArgumentException("Diretor não deve estar vazio", nameof(director));
            }

            string filePath = "Filmes.csv";
            string contentToRegister = $"{id},{title},{duration},{director},{year}\n";

            using(var file = new FileStream(filePath, FileMode.Append))
            {
                using(var writer = new StreamWriter(file, Encoding.UTF8))
                {
                    writer.Write(contentToRegister);
                }
            }
            Console.WriteLine("FILME CADASTRADO COM SUCESSO\n");
        }

        public static void ShowMovies(int quantityToShow)
        {
            if(quantityToShow > movieList.Count)
            {
                quantityToShow = movieList.Count;
            }
            for(int i = 0; i < quantityToShow; i++)
            {
                Console.WriteLine(movieList[i]);
            }
        }

        public static void DeleteMovie(int id)
        {
            Movie movieToDelete = movieList.Find(m => m.Id == id);
            if(movieToDelete == null)
            {
                Console.WriteLine($"NÃO FOI ENCONTRADO NENHUM FILME COM O ID {id}\n");
            }
            else
            {
                movieList.Remove(movieToDelete);
                Console.WriteLine($"FILME {id} EXCLUÍDO COM SUCESSO\n");
            }
        }

        public override string ToString()
        {
            return $"ID: {Id}, Título: {this.Title}, Duração: {this.Duration}, Diretor: {this.Director}, Ano: {this.Year}";
        }
    }
}
