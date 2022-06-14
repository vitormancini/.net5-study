
namespace _3_Lista_Generica
{
    class Carro
    {
        public string Modelo { get; set; }

        public Carro(string modelo)
        {
            this.Modelo = modelo;
        }

        public override string ToString()
        {
            return this.Modelo;
        }
    }
}
