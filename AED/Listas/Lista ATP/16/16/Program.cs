using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] V = new int[10];
            int[] R = new int[10];
            int cont = 0;

            Random x = new Random();

            for (int i = 0; i < V.Length - 1; i++)
            {
                V[i] = x.Next(0, 11);
                Console.Write($"{V[i],4}");
            }

            Console.WriteLine();

            for (int i = 0; i < 9; i++)
            {
                for (int j = i + 1; j < 10; j++)
                {
                    if (V[i] == V[j])
                    {
                        bool existe = false;
                        for (int k = j + 1; k < cont; k++)
                        {                            
                            if (V[i] == R[k])
                                existe = true;
                        }

                        if (existe == false)
                        {
                            R[cont] = V[i];
                            cont++;
                        }
                    }
                }
            }

            Console.Write("Elementos repetidos no vetor: ");
            if (cont == 0)
                Console.WriteLine("Nenhum");
            else
            {
                for (int i = 0; i < cont; i++)
                {
                    Console.Write($"{R[i],4}");
                }
            }

            Console.ReadKey();

        }
    }
}
