
namespace _5_Dicionarios
{
    class Aluno
    {
        public string Nome { get; private set; }
        public int Idade { get; private set; }

        public Aluno(string nome, int idade)
        {
            this.Nome = nome;
            this.Idade = idade;
        }
    }
}
