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
            Console.WriteLine("Escriba el monto :");
            double monto = double.Parse(Console.ReadLine());

            double haciaarriba = Math.Ceiling(monto);
            double haciaabajo = Math.Floor(monto);
            int truncado = (int)monto;
            double redondeado = Math.Round(monto, 2);

            Console.WriteLine($"Monto original: {monto}");
            Console.WriteLine($"Monto redondeado hacia arriba: {haciaarriba}");
            Console.WriteLine($"Monto redondeado hacia abajo: {haciaabajo}");
            Console.WriteLine($"Monto truncado: {truncado}");
            Console.WriteLine($"Monto redondeado: {redondeado}");
            Console.ReadKey();
        }
    }
}
