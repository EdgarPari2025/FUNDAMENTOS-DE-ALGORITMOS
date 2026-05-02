using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace PRACTICA___EJERCICIO_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===MENU DE OPERACIONES===");
            Console.WriteLine("1. Calcular el area de un circulo");
            Console.WriteLine("2. Calcular el area de un cuadrado");
            Console.WriteLine("3. Calcular el area de un triangulo");
            Console.WriteLine("4. Salir");
            Console.WriteLine("Seleccione una opcion del 1 al 4");

            int opcion = int.Parse(Console.ReadLine());

            switch (opcion) 
            {
                case 1:
                    Console.WriteLine("El area de un circulo es pi * r²");
                    break;
                case 2:
                    Console.WriteLine("El area de un cuadrado es lado²");
                    break;
                case 3:
                    Console.WriteLine("El area de un triangulo es base * altura / 2");
                    break;
                case 4:
                    Console.WriteLine("Salir del programa...");
                    break;
                default:
                    Console.WriteLine("Seleccione una opcion del 1 al 4");
                    break;
            }
            Console.ReadKey();

        }
    }
}
