using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maiorNoVetorRecursividade
{
    internal class Program
    {
        static int descobrirMaior(int[] V, int M, int I, int F)
        {
            int maior = M;

            if (I > F)
                return maior;
            else
            {
                if (V[I] > maior)
                    maior = V[I];

                return descobrirMaior(V, maior, ++I, F);
            }

        }

        static void Main(string[] args)
        {
            int[] vetor = { 2, 3, 4, 5, 6 };

            int maior = vetor[0];
            int inicio = 1;
            int final = vetor.Length - 1;

            Console.WriteLine($"{descobrirMaior(vetor, maior, inicio, final)}");

            Console.ReadKey();
        }
    }
}
