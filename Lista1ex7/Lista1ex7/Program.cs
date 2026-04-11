using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double milhas = 0, km;

            Console.WriteLine("Digite a quantidade em milhas marítimas:");
            milhas = double.Parse(Console.ReadLine());

            km = milhas * 1.852;

            Console.WriteLine($"Em quilômetros: {km}");
        }
    }
}
