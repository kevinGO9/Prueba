using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa el primer número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Ingresa el segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            int suma = num1 + num2;
            int multiplicacion = num1 * num2;

            Console.WriteLine("La suma de los números es: " + suma);
            Console.WriteLine("La multiplicación de los números es: " + multiplicacion);

            Console.ReadLine();
        }
    }
}
