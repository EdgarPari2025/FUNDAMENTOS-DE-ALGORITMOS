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
            Console.WriteLine("Ingrese la categoria (A - B - C)");
            string categoria = Console.ReadLine().ToUpper();

            Console.WriteLine("Ingrese la cantidad de años (de 0 a más)");
            int anios = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de horas trabajadas (de 0 a más)");
            double horas = double.Parse(Console.ReadLine());

            double tarifa_hora = 0;
            double bonificacion = 0;

            if (categoria == "A")
            {
                tarifa_hora = 33.50;
            }
            else if (categoria == "B")
            {
                tarifa_hora = 29.80;
            }
            else if (categoria == "C")
            {
                tarifa_hora = 25.70;
            }
            else
            {
                Console.WriteLine("Opcion Invalida...");
            }

            if (anios <= 3)
            {
                bonificacion = 0;
            }
            else if(anios <= 10)
            {
                bonificacion = 0.10;
            }
            else if (anios <= 17)
            {
                bonificacion = 0.20;
            }
            else
            {
                bonificacion = 0.30;
            }

            double sueldo_final = tarifa_hora * horas * (1 + bonificacion);

            Console.WriteLine($"El sueldo final es: {sueldo_final}");
            Console.ReadKey();
        }
    }
}
