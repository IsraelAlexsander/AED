using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    internal class Program
    {
        static int[] geraVetor()
        {
            int[] V = new int[20];
            
            Random r = new Random();

            Console.WriteLine("Vetor");
            for (int i = 0; i < V.Length; i++)
            {
                V[i] = r.Next(0,51);
                Console.Write(V[i]);

                if (i < V.Length - 1)
                {
                    Console.Write(", ");
                }
            }

            return V;
        }

        static int MaiorElemento(int[] V, int i = 0, int maior = int.MinValue)
        {
            if (i < V.Length)
            {
                if (maior < V[i])
                    maior = V[i];
                return (MaiorElemento(V, ++i, maior));
            }
            else
                return maior;
        }
        static void Main(string[] args)
        {
            int[] V = geraVetor();

            Console.WriteLine($"\n\nO maior elemento do Vetor é: {MaiorElemento(V)}");

            Console.ReadKey();
        }
    }
}
