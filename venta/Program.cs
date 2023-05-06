using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace venta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total = 0; // total de la venta
            bool finalizarVenta = false; // variable que indica si el usuario desea finalizar la venta

            Console.WriteLine("Bienvenido a la caja de ventas");

            while (!finalizarVenta)
            {
                Console.WriteLine("Ingrese el nombre del producto: ");
                string producto = Console.ReadLine();

                Console.WriteLine("Ingrese el precio del producto: $");
                int precio = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la cantidad: ");
                int cantidad = int.Parse(Console.ReadLine());

                int subtotal = precio * cantidad; // subtotal de la venta

                Console.WriteLine("Producto: " + producto);
                Console.WriteLine("Precio: $" + precio);
                Console.WriteLine("Cantidad: " + cantidad);
                Console.WriteLine("Subtotal: $" + subtotal);

                total += subtotal; // actualizamos el total de la venta

                Console.WriteLine("¿Desea agregar otro producto? (s/n)");
                string respuesta = Console.ReadLine();

                finalizarVenta = respuesta.Equals("n", StringComparison.OrdinalIgnoreCase); // verificamos si el usuario desea finalizar la venta
            }

            Console.WriteLine("El total de la venta es de: $" + total);
            Console.WriteLine("Gracias por su compra");
            Console.ReadLine();
        }
    }
    
}
