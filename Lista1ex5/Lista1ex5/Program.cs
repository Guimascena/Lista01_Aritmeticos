using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double soma = 0;
            int i = 1;

            while (i < 5)
            {
                Console.WriteLine("Digite a nota {0}:", i);
                soma += double.Parse(Console.ReadLine());
                i++;
            }

            Console.WriteLine("A média é {0}", soma / 4);
        }
    }
}
