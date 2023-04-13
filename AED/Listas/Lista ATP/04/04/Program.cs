using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int n = int.Parse(Console.ReadLine());

            int cont = 0;

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    cont++;
            }

            if (cont > 2)
                Console.WriteLine($"O número {n} não é primo");
            else
                Console.WriteLine($"O número {n} é primo");

            Console.ReadKey();
        }
    }
}
