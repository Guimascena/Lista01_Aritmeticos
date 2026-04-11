using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double m1 = 0, m2 = 0, media;

            Console.WriteLine("Digite o primeiro valor:");
            m1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor:");
            m2 = double.Parse(Console.ReadLine());

            media = Math.Sqrt(m1 * m2);

            Console.WriteLine($"A média geométrica é: {media}");
        }
    }
}
