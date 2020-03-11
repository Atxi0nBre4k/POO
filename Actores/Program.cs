using System;
using System.Collections.Generic;
namespace Pelicula
{
    class Actor
    {
        private string Nombre;
        private int AñoNacimiento;
        public Actor (string Nombre, int AñoNacimiento)
        {
            this.Nombre = Nombre;
            this.AñoNacimiento = AñoNacimiento;
        }
        public void setNombre(string n)
        {
            this.Nombre = n;
        }
        public string getNombre()
        {
            return Nombre;
        }
        public void setAñoNacimiento(int a)
        {
            this.AñoNacimiento = a;
        }
        public int getAñoNacimiento()
        {
            return AñoNacimiento;
        }

    }
    class Pelicula
    {
        private string Titulo;
        private int Año;
        private List <Actor> Actores;
        public Pelicula (string Titulo, int Año)
        {
            this.Titulo = Titulo;
            this.Año = Año;
            Actores = new List<Actor>();
        }
        public void setTitulo(string t)
        {
            this.Titulo = t;
        }
        public string getTitulo()
        {
            return Titulo;
        }
        public void setAño(int an)
        {
            this.Año = an;
        }
        public int getAño()
        {
            return Año;
        }
        public void AgregarActor( Actor Ac)
        {
            Actores.Add(Ac);
        }
        public void ImprimeActores()
        {
            Console.WriteLine(Titulo + " " + Año);
            foreach( Actor Ac in Actores)
            {
                Console.WriteLine(Ac.getNombre() + " "+Ac.getAñoNacimiento());
            }
        }

        class Program
        {
            static void Main(String[] args)
            {
                Pelicula p1 = new Pelicula ("-El niño de pijama de rayas", 2008);
                p1.AgregarActor(new Actor ("Asa Butterfield ",1997));
                p1.AgregarActor(new Actor ("Jack Scanlon ",1998));
                p1.AgregarActor(new Actor ("Vera Farmiga", 1973));
                p1.AgregarActor(new Actor ("David Thewlis", 1963));
                Pelicula p2 = new Pelicula ("-Ready Player One", 2018);
                p2.AgregarActor(new Actor ("Tye Sheridan ", 1996));
                p2.AgregarActor(new Actor ("Olivia Cooke", 1993));
                p2.AgregarActor(new Actor ("Ben Mendelsohn", 1969));
                p2.AgregarActor(new Actor ("Simon Pegg", 1970));
                Pelicula p3 = new Pelicula ("-Your name", 2016);
                p3.AgregarActor(new Actor ("Ryūnosuke Kamiki ", 1993));
                p3.AgregarActor(new Actor ("Stephanie Sheh", 1977));
                Pelicula p4 = new Pelicula ("-La chica que saltaba a traves del tiempo", 2006);
                p4.AgregarActor(new Actor ("Takuya Ishida ", 1987));
                p4.AgregarActor(new Actor ("Riisa Naka", 1989));
                p4.AgregarActor(new Actor ("Mitsutaka Itakura", 1976));
                p4.AgregarActor(new Actor ("Yuki Sekido", 1991));
                Pelicula p5 = new Pelicula ("-1917", 2019);
                p5.AgregarActor(new Actor ("George MacKay ", 1992));
                p5.AgregarActor(new Actor ("Dean-Charles Chapman", 1997));
                p5.AgregarActor(new Actor ("Richard Madden", 1986));
                p5.AgregarActor(new Actor ("Benedict Cumberbatch", 1976));

                p1.ImprimeActores();
                p2.ImprimeActores();
                p3.ImprimeActores();
                p4.ImprimeActores();
                p5.ImprimeActores();
            }
        }

    }
}
