using System;
using System.Collections.Generic;
namespace Parametros
{
   class Persona
   {
       public string nombre;
       public string apellido;

       public Persona()
       {
           nombre = "Andres";
           apellido = "Escalante";
       }

       class Anonimo
       {
           public static void Ocultar(Persona p)
           {
               p.nombre = "******";
               p.apellido = "*********";
           }

           public static void Cambiar(ref Persona p)
           {
               p = new Persona();
               p.nombre = "Nuevo";
           }
       }

       class Program
       {
           static void Duplicador(int a)
           {
               a = a * 2;
           }
           static int Suma(int a, int b)
           {
               return a + b;
           }
           static void Suma( int a, int b, out int resta)
           {
               resta = a - b;
           }
       }
       static void Main(string[] args)
       {
           int x = 2, y= 4;
           int r = Suma(x,y);
           int r2;
           Suma(r,x, out r2);
           Console.WriteLine(r2);
           
           Persona p = new Persona();
           Console.WriteLine(p.nombre);
           Anonimo.Ocultar(p);
           Console.WriteLine(p.nombre);

       }
   } 
}
