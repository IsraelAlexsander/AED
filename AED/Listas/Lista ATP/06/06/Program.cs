using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] R = new int [10];
            int[] S = new int[10];
            int[] V = new int[20];
            int cont = 0;


            //Vetor R
            Console.WriteLine("Vetor R");
            for (int i = 0; i < R.Length; i++)
            {
                Console.Write($"Digite o {i + 1}º valor: ");
                R[i] = int.Parse(Console.ReadLine());

            //Vetor V
                bool existe = false;

                for (int j = 0; j < V.Length; j++)
                    if (R[i] == V[j])
                        existe = true;

                if (existe == false)
                {
                    V[cont] = R[i];
                    cont++;
                }
            }

            Console.Clear();

            //Vetor S
            Console.WriteLine("Vetor S");
            for (int i = 0; i < S.Length; i++)
            {
                Console.Write($"Digite o {i + 1}º valor: ");
                S[i] = int.Parse(Console.ReadLine());

            //Vetor V
                bool existe = false;

                for (int j = 0; j < V.Length; j++)
                    if (S[i] == V[j])
                        existe = true;

                if (existe == false)
                {
                    V[cont] = S[i];
                    cont++;
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

            for (int i = 0; i <= cont; i++)
            {
                Console.Write(V[i]);
                if (i != R.Length - 1)
                    Console.Write(", ");
            }

            Console.ReadKey();
        }
    }
}
