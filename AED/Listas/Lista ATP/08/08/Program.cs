using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] R = new int[10];
            int[] S = new int[10];
            int[] V = new int[20];
            int cont = 0;

            //Vetor R
            Console.WriteLine("Vetor R");
            for (int i = 0; i < R.Length; i++)
            {
                Console.Write($"Digite o {i + 1}º valor: ");
                R[i] = int.Parse(Console.ReadLine());                
            }

            Console.Clear();

            //Vetor S
            Console.WriteLine("Vetor S");
            for (int i = 0; i < S.Length; i++)
            {
                Console.Write($"Digite o {i + 1}º valor: ");
                S[i] = int.Parse(Console.ReadLine());               
            }

            for (int i = 0; i < R.Length; i++)
            {
                bool existe = false;

                for (int j = 0; j < S.Length; j++)
                {
                    if (R[i] == S[j])
                        existe = true;
                }

                if (!existe)
                {
                    bool existe1 = false;

                    for (int j = 0; j < V.Length; j++)
                    {
                        if (R[i] == V[j])
                            existe1 = true;

                        if (!existe1)
                        {
                            V[cont] = R[i];
                            cont++;
                        }
                    }
                        
                }



            }
            Console.Clear();

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

            for (int i = 0; i < cont; i++)
            {
                Console.Write(V[i]);
                if (i != cont - 1)
                    Console.Write(", ");
            }

            Console.ReadKey();
        }
    }
}
