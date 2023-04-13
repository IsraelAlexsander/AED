using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09
{
    internal class Program
    {

        static int contaDivisores(int n, int i = 1, int cont = 0)
        {
            if (i <= n)
            {
                if (n % i == 0)
                    cont++;

                return contaDivisores(n, ++i, cont);
            }

            return (cont);
        }
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"O número {n} têm {contaDivisores(n)} divisores");

            Console.ReadKey();
        }
    }
}
