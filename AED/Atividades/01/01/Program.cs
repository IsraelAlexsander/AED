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
            int P1, P2, soma, Quadrado;

            for (int i = 1000; i <= 9999; i++)
            {
                P1 = i / 100;
                P2 = i % 100;

                soma = P1+ P2;
                Quadrado = soma * soma;

                if (Quadrado == i)
                    Console.WriteLine($"O número {i} possui essa caracteristica...");
            }

            Console.ReadKey();
        }
    }
}
