using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICA___EJERCICIO_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la nota de la practica 1 (nota de 0 a 20)");
            double p1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la nota de la practica 2 (nota de 0 a 20)");
            double p2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la nota de la practica 3 (nota de 0 a 20)");
            double p3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la nota del examen parcial (nota de 0 a 20)");
            double examen_parcial = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la nota del examen final (nota de 0 a 20)");
            double examen_final = double.Parse(Console.ReadLine());

            double prom_practica = (p1 + p2 + p3 - Math.Min(p1,Math.Min(p2,p3))) / 2;

            double prom_final = (examen_final + examen_parcial + prom_practica) / 3;

            if (p1 < 0 || p1 > 20 || p2 < 0 || p2 > 20 || p3 < 0 || p3 > 20 || examen_final < 0 || examen_final > 20 || examen_parcial < 0 || examen_parcial > 20)
            {
                Console.WriteLine("Nota(s) Invalida(s)");
                return;
            }
            if (prom_final >= 18)
            {
                Console.WriteLine("EXCELENTE !!!");
            }
            else if (prom_final >= 14)
            {
                Console.WriteLine("BUENO !!!");
            }
            else if (prom_final >= 10)
            {
                Console.WriteLine("REGULAR !!!");
            }
            else
            {
                Console.WriteLine("DEFICIENTE !!!");
            }
            Console.ReadKey();
        }
    }
}
