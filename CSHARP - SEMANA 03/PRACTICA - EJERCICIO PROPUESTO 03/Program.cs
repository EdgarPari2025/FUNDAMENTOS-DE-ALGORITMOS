using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICA___EJERCICIO_PROPUESTO_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la temperatura en grados Celcius °C: ");
            double celcius = double.Parse(Console.ReadLine());

            double fahrenheit = celcius * (9.0 / 5) + 32;
            double kelvin = celcius + 273.15;

            Console.WriteLine($"La temperatura en grados Fahrenheit es: {fahrenheit}");
            Console.WriteLine($"La temperatura en grados Kelvin es: {kelvin}");
            Console.ReadKey();
        }
    }
}
