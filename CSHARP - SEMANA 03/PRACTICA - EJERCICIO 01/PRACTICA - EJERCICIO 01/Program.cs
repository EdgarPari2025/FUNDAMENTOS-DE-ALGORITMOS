using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICA___EJERCICIO_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la nota 1: ");
            int nota1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la nota 2: ");
            int nota2 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la nota 3: ");
            int nota3 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la nota 4: ");
            int nota4 = int.Parse(Console.ReadLine());

            int suma = nota1 + nota2 + nota3 + nota4;

            double promedio = suma / 4;

            Console.WriteLine($"La suma de notas es {suma}");
            Console.WriteLine($"El promedio de notas es {promedio}");
            Console.ReadKey();
        }
    }
}
