using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double soma1 = 0;            
            double soma2 = 100;          

            Console.Write("Digite o valor de N: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 2; i <= n; i++)
            {
                Console.Write($"{i-1}/{i}");
                if (i != n)
                    Console.Write(" + ");
                soma1 = soma1 + (double)(i - 1)/(double)i;
            }
            
            Console.WriteLine($"\nA soma total é: {soma1}\n");

            Console.ReadKey();

            Console.Write(soma2);
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write($" - {i}");
                    soma2 = soma2 -i;
                }
                else
                {
                    Console.Write($" + {i}");
                    soma2 = soma2 + i;
                }
            }

            Console.WriteLine($"\nO resultado total é: {soma2}\n\n");

            Console.ReadKey();
        }
    }
}
