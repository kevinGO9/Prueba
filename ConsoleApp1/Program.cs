using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int saldo = 1000; // saldo inicial del cajero

            while (true)
            {
                Console.WriteLine("Bienvenido al cajero automático");
                Console.WriteLine("1. Consultar saldo");
                Console.WriteLine("2. Retirar dinero");
                Console.WriteLine("3. Salir");

                Console.Write("Ingrese una opción: ");
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Su saldo actual es de: $" + saldo);
                        break;
                    case 2:
                        Console.Write("Ingrese la cantidad que desea retirar: $");
                        int cantidad = int.Parse(Console.ReadLine());

                        if (cantidad > saldo)
                        {
                            Console.WriteLine("No tiene suficiente saldo para realizar la transacción");
                        }
                        else
                        {
                            saldo -= cantidad;
                            Console.WriteLine("Retire su dinero");
                            Console.WriteLine("Su saldo actual es de: $" + saldo);
                        }
                        break;
                    case 3:
                        Console.WriteLine("Gracias por utilizar nuestros servicios");
                        return;
                    default:
                        Console.WriteLine("Opción inválida, intente de nuevo");
                        break;
                }

                Console.WriteLine(); // línea en blanco para separar las iteraciones
            }
        }
    }
}
