using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICA___EJERCICIO_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la nota del estudiante (0 - 20): ");
            double nota = double.Parse(Console.ReadLine());

            if (nota < 0 || nota > 20)
            {
                Console.WriteLine("VALOR INVALIDO, Ingrese una nota de 0 a 20");
            }
            else if(nota <= 5)
            {
                Console.WriteLine("Su calificacion es DEFICIENTE");
            }
            else if (nota <= 10)
            {
                Console.WriteLine("Su calificacion es REGULAR");
            }
            else if (nota <= 14)
            {
                Console.WriteLine("Su calificacion es BUENO");
            }
            else
            {
                Console.WriteLine("Su calificacion es EXCELENTE");
            }
            Console.ReadKey();
        }
    }
}
