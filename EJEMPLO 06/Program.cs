using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJEMPLO_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dni, apellido;
            int tipo_gasolina;
            double cantidad_galones, precio = 0, monto_pagar;
            double total_recaudado = 0;
            string opcion = "SI";

            while (opcion.ToUpper() == "SI")
            {
                precio = 0;

                Console.WriteLine("===== REGISTRO DE VENTA DE GASOLINA =====");

                Console.Write("Ingrese el DNI del cliente: ");
                dni = Console.ReadLine();

                Console.Write("Ingrese el apellido del cliente: ");
                apellido = Console.ReadLine();

                Console.WriteLine("\nTipos de gasolina disponibles:");
                Console.WriteLine("84 -> S/ 8.20 por galón");
                Console.WriteLine("90 -> S/ 10.50 por galón");
                Console.WriteLine("97 -> S/ 15.30 por galón");

                Console.Write("Ingrese el tipo de gasolina (84, 90 o 97): ");
                tipo_gasolina = int.Parse(Console.ReadLine());

                Console.Write("Ingrese la cantidad de galones: ");
                cantidad_galones = double.Parse(Console.ReadLine());

                if (tipo_gasolina == 84)
                {
                    precio = 8.20;
                }
                else if (tipo_gasolina == 90)
                {
                    precio = 10.50;
                }
                else if (tipo_gasolina == 97)
                {
                    precio = 15.30;
                }
                else
                {
                    Console.WriteLine("Tipo de gasolina no válido.");
                    precio = 0;
                }

                monto_pagar = cantidad_galones * precio;

                total_recaudado = total_recaudado + monto_pagar;

                Console.WriteLine("\n===== BOLETA DE VENTA =====");
                Console.WriteLine("DNI: " + dni);
                Console.WriteLine("Apellido: " + apellido);
                Console.WriteLine("Tipo de gasolina: " + tipo_gasolina);
                Console.WriteLine("Precio por galón: S/ " + precio);
                Console.WriteLine("Cantidad de galones: " + cantidad_galones);
                Console.WriteLine("Monto a pagar: S/ " + monto_pagar);

                Console.Write("\n¿Desea registrar otro cliente? (SI o NO): ");
                opcion = Console.ReadLine();

                Console.WriteLine();
            }

            Console.WriteLine("===== RESUMEN FINAL =====");
            Console.WriteLine("Total recaudado por la gasolinera: S/ " + total_recaudado);
            Console.ReadKey();
        }
    }
}
