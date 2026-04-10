using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int b;
            int h;
            int a;

            Console.WriteLine("Informe a base do retângulo:");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a altura do retângulo:");
            h = int.Parse(Console.ReadLine());

            a = b * h;

            Console.WriteLine("A area do retângulo é:");
            Console.WriteLine(a);

        }
    }
}
