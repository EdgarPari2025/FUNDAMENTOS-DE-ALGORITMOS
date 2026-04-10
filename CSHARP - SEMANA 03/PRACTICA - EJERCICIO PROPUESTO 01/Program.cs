using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICA___EJERCICIO_PROPUESTO_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la cantidad de habitaciones: ");
            int habitaciones = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de patios: ");
            int patios = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de baños: ");
            int baños = int.Parse(Console.ReadLine());

            double total = habitaciones * 30 + patios * 10 + baños * 15;

            Console.WriteLine($"El alquiler mensual es: {total}");
            Console.ReadKey();
        }
    }
}
