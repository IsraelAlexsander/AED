using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07
{
    internal class Program
    {
        static int[] criaVetor()
        {
            int[] V = new int[10];

            Random r = new Random();

            Console.WriteLine("Vetor");
            for (int i = 0; i < 10; i++)
            {
                V[i] = r.Next(0,51);
                Console.Write($"{V[i],4}");
            }

            Console.WriteLine("\n");

            return (V);
        }

        static int contaPares(int[] V, int i = 0, int cont = 0)
        {
            if (i < V.Length)
            {
                if (V[i] % 2 == 0)
                    cont++;

                return (contaPares(V, ++i, cont));
            }

            return (cont);
        }
        static void Main(string[] args)
        {
            Console.WriteLine($"O número elementos pares no vetor é: {contaPares(criaVetor())}");

            Console.ReadKey();
        }
    }
}
