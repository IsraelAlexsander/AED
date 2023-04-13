using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetorABCD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            int[] b = new int[5];
            int[] c = new int[5];
            int contA = 0;

            Console.WriteLine("Digite os elementos de A");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"A({i}): ");
                a[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Digite os elementos de B");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"B({i}): ");
                b[i] = int.Parse(Console.ReadLine());
            }
            

            for (int i = 0; i < 5; i++)
            {
                 contA = 0;

                for (int j = 0; j < 5; j++)
                {
                    if (a[i] != b[j])
                    {
                        contA++;
                    }
                }

                if (contA == 5)
                    c[i] = a[i];
            }

            Console.WriteLine("Valores de A que não estão em B");
            for (int i = 0; i < contA; i++)
            {
                Console.WriteLine(c[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
