using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int l;
            int a;

            Console.WriteLine("Informe a aresta do quadrado:");
            l = int.Parse(Console.ReadLine());

            a = l * l;

            Console.WriteLine("A area do quadrado é:");
            Console.WriteLine(a);
           
        }
    }
}
