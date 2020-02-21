using System;

namespace Pelicula
{
    class Pelicula
    {
        public string titulo;
        public Int16 año;
        public string pais;
        public string director;
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Pelicula p1 = new Pelicula();
            p1.SetTitulo("Baby Driver");
            p1.SetAño(2017);

            Pelicula p2 = new Pelicula();
            p1.SetTitulo("One Upon a Time in Hollywood");
            p1.SetAño(2019);
        }
    }
}
