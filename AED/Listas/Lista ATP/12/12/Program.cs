using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    internal class Program
    {                
        static void ContaMultiplos(int[] V)
        {
            int[] R = new int[V.Length];
            int cont = 0;

            for (int i = 0; i < V.Length; i++)
            {                
                if (V[i] % 3 == 0)
                {
                    bool existe = false;

                    for (int j = 0; j < R.Length; j++)
                    {
                        if (V[i] == R[j]) //Verificar elementos repetidos
                            existe = true;                        
                    }

                    if (existe == false)
                    {
                        R[cont] = V[i];
                        cont++;
                    }
                }
            }
            Console.WriteLine($"O Vetor tem {cont} multiplos de 3");
            for (int i = 0; i < cont; i++)
                Console.Write($"{R[i],4}");

        }
        static void Main(string[] args)
        {
            int[] V = new int[10];

            Random r = new Random();


            Console.WriteLine("Vetor");
            for (int i = 0; i < V.Length; i++)
            {
                V[i] = r.Next(0, 101);
                Console.Write($"{V[i],4}");
            }

            Console.WriteLine("\n");

            ContaMultiplos(V);

            Console.ReadKey();

        }
    }
}
