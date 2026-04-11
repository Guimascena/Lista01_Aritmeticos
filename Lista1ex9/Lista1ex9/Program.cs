using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1ex9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double diametro = 0, raio, area;

            Console.WriteLine("Digite o diâmetro do círciulo:");
            diametro = double.Parse(Console.ReadLine());

            raio = diametro / 2;

            area = Math.PI * Math.Pow(raio, 2);

            Console.WriteLine($"Área do círculo: {area}");

        }
    }
}
