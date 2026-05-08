using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJEMPLO_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nacionalidad, nacionalidad_mas_alto = "";
            double estatura, estatura_mayor = 0, cantidad_peruanos = 0;
            string opcion = "SI";

            while (opcion.ToUpper() == "SI")
            {
                Console.WriteLine("===== REGISTRO DE DEPORTISTA =====");

                Console.Write("Ingrese la nacionalidad del deportista: ");
                nacionalidad = Console.ReadLine();

                Console.Write("Ingrese la estatura del deportista en metros: ");
                estatura = double.Parse(Console.ReadLine());

                if (nacionalidad.ToLower() == "peruano" ||
                    nacionalidad.ToLower() == "peruana" ||
                    nacionalidad.ToLower() == "peru" ||
                    nacionalidad.ToLower() == "perú")
                {
                    cantidad_peruanos++;
                }

                if (estatura > estatura_mayor)
                {
                    estatura_mayor = estatura;
                    nacionalidad_mas_alto = nacionalidad;
                }

                Console.Write("¿Desea registrar otro deportista? (SI o NO): ");
                opcion = Console.ReadLine();

                Console.WriteLine(" ");
            }

            Console.WriteLine("===== RESULTADOS =====");
            Console.WriteLine("La nacionalidad del deportista más alto es: " + nacionalidad_mas_alto);
            Console.WriteLine("La estatura más alta registrada es: " + estatura_mayor + " m");
            Console.WriteLine("Cantidad de deportistas peruanos: " + cantidad_peruanos);
            Console.ReadKey();
        }
    }
}
