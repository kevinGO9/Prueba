using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solucion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radio;
            double area;

            Console.WriteLine("Ingrese el radio del círculo: ");
            radio = double.Parse(Console.ReadLine());

            area = Math.PI * Math.Pow(radio, 2);

            Console.WriteLine("El área del círculo es: " + area);
            Console.ReadLine();
        }
    }
}
