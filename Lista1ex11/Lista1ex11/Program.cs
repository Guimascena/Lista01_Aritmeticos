using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 0, y = 0, resultado;

            Console.WriteLine("Digite o valor de X:");
            x = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de Y:");
            y = double.Parse(Console.ReadLine());

            resultado = Math.Pow(x, y);

            Console.WriteLine($"Resultado de X elevado a Y: {resultado}");

        }
    }
}
