using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double p1 = 0, p2 = 0, p3 = 0, p4 = 0, p5 = 0;
            double total, pagamento, troco;

            Console.WriteLine("Digite o valor do produto 1:");
            p1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do produto 2:");
            p2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do produto 3:");
            p3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do produto 4:");
            p4 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do produto 5:");
            p5 = double.Parse(Console.ReadLine());

            total = p1 + p2 + p3 + p4 + p5;

            Console.WriteLine("Digite o valor pago:");
            pagamento = double.Parse(Console.ReadLine());

            troco = pagamento - total;

            Console.WriteLine($"Troco: R$ {troco}");

        }
    }
}
