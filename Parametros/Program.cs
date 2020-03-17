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
         
           static void Sumar(int a, int b, out res)
           {
               res = a + b;
           }
             static int Sumar(int a, int b)
           {
               return a + b;
           }
       }
       static void Main(string[] args)
       {
           int x = 2;
           int  y= 4;
           int r = Sumar(x,y);
           int r2;
           Sumar(r,x, out r2);
           Console.WriteLine(r2);
           Console.WriteLine(suma(x,y));
           
           Persona p = new Persona();
           Console.WriteLine(p.nombre);
           Anonimo.Ocultar(p);
           Console.WriteLine(p.nombre);

       }
   } 
}
