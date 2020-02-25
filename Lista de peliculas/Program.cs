using System;
using System.Collections.Generic;

namespace ListadePelicula
{
    class program
    {
        static void Main(string[] args)
        {
            List<string> Lista = new List<string>();

            Lista.Add("1.- El niño de pijama de rayas ");
            Lista.Add("2.- Ready Player One" );
            Lista.Add("3.- Your name");
            Lista.Add("4.- La chica que saltaba a traves del tiempo");
            Lista.Add("5.- 1917");
            foreach(string ListadePelicula in Lista)
            {
                Console.WriteLine(ListadePelicula);
            }
        }
    }
}
