using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICA___EJERCICIO_PROPUESTO_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double cargo_fijo = 5;
            Console.WriteLine("Diga los kWh consumidos: ");
            double kwhora = double.Parse(Console.ReadLine());

            double sub_total = cargo_fijo + kwhora * 0.55;
            double igv = sub_total * 0.18;
            double total = sub_total + igv;

            Console.WriteLine($"El sub total sin igv es: {sub_total}");
            Console.WriteLine($"El igv es: {igv}");
            Console.WriteLine($"El pago total es: {total}");
            Console.ReadKey();
        }
    }
}
