using System;

namespace Pelicula
{
    class Pelicula
    {
        private string titulo;
        private Int16 año;
        private string pais;
        private string director;
        public Pelicula(string titulo, Int16 año)
        {
            this.titulo = titulo;
            this.año = año;
        }
        public void imprime()
        {
            Console.WriteLine(titulo,año);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Pelicula p1 = new Pelicula ("Baby Driver", 2013);
            p1.imprime();

            Pelicula p2 = new Pelicula ("Once Upon a Time in Hollywood", 2019);
            p2.imprime();
        }
    }
}
