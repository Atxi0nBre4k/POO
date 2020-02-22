using System;

namespace Pelicula
{
    class Pelicula
    {
        private string titulo;
        private Int16 año;
        private string pais;
        private string director;
        
        public void SetTitulo (string t)
        {
            titulo = t;
        }
        public void SetAño (Int16 a)
        {
            año = a;
        }

        public string GetTitulo()
        {
            return titulo;
        }

        public Int16 GetAño()
        {
            return año;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Pelicula p1 = new Pelicula();
            p1.SetTitulo("Baby Driver");
            p1.SetAño(2017);
            Console.WriteLine("{0}({1})", p1.GetTitulo(), p1.GetAño());
            Pelicula p2 = new Pelicula();
            p2.SetTitulo("Once Upon a Time in Hollywood");
            p2.SetAño(2019);
            Console.WriteLine("{0}({1})", p2.GetTitulo(), p2.GetAño());
            
        }
    }
}
