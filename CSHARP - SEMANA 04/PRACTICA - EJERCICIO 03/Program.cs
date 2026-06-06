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
            Console.WriteLine("Ingrese el peso en kg: ");
            double peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la altura en metros: ");
            double altura = double.Parse(Console.ReadLine());

            double imc = Math.Round(peso / (Math.Pow(altura, 2)), 2);

            Console.WriteLine($"El IMC es: {imc}");

            if (imc < 18.5)
            {
                Console.WriteLine("Esta bajo de peso");
            }
            else if (imc < 25)
            {
                Console.WriteLine("Esta normal");
            }
            else if (imc < 30)
            {
                Console.WriteLine("Esta con sobre peso");
            }
            Console.ReadKey();

        }
    }
}
