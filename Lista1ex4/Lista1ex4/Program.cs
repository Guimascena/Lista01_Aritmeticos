using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int b;
            int a;

            Console.WriteLine("Digite o valor da base do triângulo:");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da altura do triângulo:");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("A área do triângulo é {0}", (b*a)/2);
        }
    }
}
