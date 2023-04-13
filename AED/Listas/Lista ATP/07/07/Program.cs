using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] R = new int[10];
            int[] S = new int[10];
            int[] V = new int[20];


            //Vetor R
            Console.WriteLine("Vetor R");

            for (int i = 0; i < R.Length; i++)
            {
                Console.Write($"Digite o {i + 1}º termo: ");
                R[i] = int.Parse(Console.ReadLine());
            }

            Console.Clear();

            //Vetor S 
            Console.WriteLine("Vetor S");

            for (int i = 0; i < S.Length; i++)
            {
                Console.Write($"Digite o {i + 1}º termo: ");
                S[i] = int.Parse(Console.ReadLine());
            }

            Console.Clear();

            //Vetor V
            int x = 0;
            for (int i = 0; i < R.Length; i++)
                for (int j = 0; j < S.Length; j++)
                    if (R[i] == S[j])
                    {
                        bool existe = false;
                        
                        for (int k = 0; k < V.Length; k++)
                        {
                            if (R[i] == V[k])
                                existe = true; 

                            if (existe == false)
                            {
                                V[x] = R[i];
                                x++;
                            }
                                
                        }
                    }

            Console.Write("Vetor R: ");
            for (int i = 0; i < R.Length; i++)
            {
                Console.Write(R[i]);
                if (i != R.Length - 1)
                    Console.Write(", ");
            }

            Console.Write("\nVetor S: ");
            for (int i = 0; i < S.Length; i++)
            {
                Console.Write(S[i]);
                if (i != R.Length - 1)
                    Console.Write(", ");
            }

            Console.Write("\nVetor V: ");

            for (int i = 0; i <= x; i++)
            {
                Console.Write(V[i]);
                if (i != R.Length - 1)
                    Console.Write(", ");
            }

            Console.ReadKey();
        }
    }
}
