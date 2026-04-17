using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICA___EJERCICIO_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su edad: ");
            int edad = int.Parse(Console.ReadLine());

            int falta = Math.Abs(edad - 18);

            if (edad >= 18)
            {
                Console.WriteLine("Acceso permitido...");
                Console.WriteLine("Bienvenido...");

            }
            else 
            {
                Console.WriteLine("Acceso denegado...");
                Console.WriteLine($"Te faltan {falta} año(s)");
            }
            Console.ReadKey();
        }
    }
}
