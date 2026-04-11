using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cotacao = 0, dolares = 0, reais;

            Console.WriteLine("Digite a cotação do dólar:");
            cotacao = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de dólares:");
            dolares = double.Parse(Console.ReadLine());

            reais = cotacao * dolares;

            Console.WriteLine($"Valor em reais: R$ {reais}");

        }
    }
}
