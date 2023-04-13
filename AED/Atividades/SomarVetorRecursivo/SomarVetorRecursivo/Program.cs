using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomarVetorRecursivo
{
    internal class Program
    {
        static int somarVetor(int[] V, int I, int F, int S)
        {
            int Soma = S;

            if (I > F)
                return S;
            else
            {
                Soma += V[I] + somarVetor(V, ++I, F, S);
            }
            return Soma;
        }

        static void Main(string[] args)
        {
            int[] v = {1,2,3,4,5};
            int inicio = 0;        
            int final = v.Length - 1;
            int soma = 0;

            Console.WriteLine(somarVetor(v, inicio, final, soma));
            Console.ReadKey();
        }
    }
}
