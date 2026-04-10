using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICA___EJERCICIO_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el precio unitario: ");
            double precio_unitario = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de productos: ");
            int cantidad = int.Parse(Console.ReadLine());

            double sub_total = precio_unitario * cantidad;
            double igv = sub_total * 0.18;
            double monto_total = sub_total + igv;

            Console.WriteLine($"El monto sin igv es: {sub_total}");
            Console.WriteLine($"El igv es: {igv}");
            Console.WriteLine($"El monto total es: {monto_total}");
            Console.ReadKey();


        }
    }
}
