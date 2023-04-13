using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Recursivo
{
    internal class Program
    {
        static long Fibonacci(long n)
        {
            if (n < 2)
                return n;
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de termos que deseja ver: ");
            long n = long.Parse(Console.ReadLine());

            long nTermo = Fibonacci(n);
            Console.WriteLine($"O {n}º termo de Fibonacci é: {nTermo}");
            Console.ReadKey();
        }
    }
}
