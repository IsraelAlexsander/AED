using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 1000; i++)
            {
                int somaDivisores = 0;

                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                        somaDivisores += j;
                }

                if (somaDivisores == i)
                    Console.WriteLine($"O número {i} é perfeito");
            }

            Console.ReadKey();
        }
    }
}
