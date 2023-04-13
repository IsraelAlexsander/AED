using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15
{
    internal class Program
    {
        static int Fatorial(int n)
        {
            int fat = 1;

            for (int i = 1; i <= n; i++)
            {
                fat *= i;
            }

            return (fat);
        }

        static int SuperFatorial(int n)
        {
            int superFat = 1;
            for (int i = 1; i <= n; i++)
            {
                superFat *= Fatorial(i);
            }

            return (superFat);
        }
        static void Main(string[] args)
        {
            Console.Write("Digite um valor: ");
            int n = int.Parse(Console.ReadLine());

            int superFatorial = SuperFatorial(n);

            Console.WriteLine($"O superfatorial de {n} é {superFatorial}");

            Console.ReadKey();
        }
    }
}
