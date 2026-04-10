using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICA___EJERCICIO_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x1: ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("y1: ");
            double y1 = double.Parse(Console.ReadLine());
            Console.Write("x2: ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("y2: ");
            double y2 = double.Parse(Console.ReadLine());

            double dx = x1 - x2;
            double dy = y1 - y2;
            double distancia = Math.Sqrt(dx*dx + dy*dy);

            Console.WriteLine($"La distancia de los puntos es: {distancia:F2}");
            Console.ReadKey();

        }
    }
}
