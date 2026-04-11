using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double c = 0, f;

            Console.WriteLine("Digite a temperatura em Celsius:");
            c = double.Parse(Console.ReadLine());

            f = (9.0 / 5.0) * c + 32;

            Console.WriteLine($"Temperatura em Fahrenheit: {f}");

        }
    }
}
