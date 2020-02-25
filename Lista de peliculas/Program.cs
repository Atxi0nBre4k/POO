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

            foreach(string ListadePelicula in Lista)
            {
                Console.WriteLine(ListadePelicula);
            }
        }
    }
}
