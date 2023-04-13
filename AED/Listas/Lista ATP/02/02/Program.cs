using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite a quantidade de termos a ver: ");
            int t = int.Parse(Console.ReadLine());
            while (t <= 2)
            {
                Console.WriteLine("Valor invalida. Digite um valor maior que 2.");
                Console.Write("Digite a quantidade de termos a ver: ");
                t = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }
            int a = 1, b = 0, c = 0;

            for (int i = 1; i <= t; i++)
            {
                Console.Write($"{a}");
                if (i != t)
                    Console.Write(" - ");

                c = b;
                b = a;
                a = b + c;
            }

            Console.ReadKey();
        }
    }
}
