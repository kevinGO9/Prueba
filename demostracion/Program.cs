using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demostracion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, resultado;

            Console.Write("Ingrese el primer número: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            resultado = num1 - num2;

            Console.WriteLine("La resta de {0} y {1} es: {2}", num1, num2, resultado);

            Console.ReadKey();
        }
    }
}
