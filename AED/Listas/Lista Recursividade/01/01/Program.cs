using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    internal class Program
    {
        static int[] geraVetor()
        {
            int[] V = new int[20];

            Random r = new Random();

            Console.Write("Vetor: ");
            for (int i = 0; i < V.Length; i++)
            {
                V[i] = r.Next(0,11);
                Console.Write($"{V[i]}");
                if (i < V.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            return V;
                
        }

        static int SomaVetor(int[] V, int i = 0)
        {
            int soma = 0;
            
            if (i < V.Length)
            {
                soma += V[i] + SomaVetor(V, ++i);
            }

            return soma;
                
        }
        static void Main(string[] args)
        {            
            int[] V = geraVetor();

            Console.WriteLine($"\n\nA soma dos elementos do vetor é: {SomaVetor(V)}");

            Console.ReadKey();
        }
    }
}
