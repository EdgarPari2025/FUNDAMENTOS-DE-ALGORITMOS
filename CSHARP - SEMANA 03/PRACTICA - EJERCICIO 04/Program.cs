using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICA___EJERCICIO_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el radio del circulo: ");
            double radio = double.Parse(Console.ReadLine());

            double area = 3.14 * Math.Pow(radio, 2);
            double perimetro = 2 * 3.14 * radio;

            Console.WriteLine($"El area del circulo es: {area}");
            Console.WriteLine($"El perimetro del circulo es: {perimetro}");
            Console.ReadKey();
        }
    }
}
