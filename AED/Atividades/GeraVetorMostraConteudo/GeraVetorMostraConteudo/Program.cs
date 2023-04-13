using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeraVetorMostraConteudo
{    
    internal class Program
    {
        static void CriaVetor(int[] V, Random x, int indice, int tamanho)
        {
            if (indice < tamanho)
            {
                V[indice] = x.Next(1, 51);

                CriaVetor(V, x, indice + 1, tamanho);
            }
        }

        static void MostraVetor(int[]V, int indice, int tamanho)
        {
            if (indice < tamanho)
            {
                Console.WriteLine(V[indice]);

                MostraVetor(V, indice + 1, tamanho);
            }
        }

        static void Main(string[] args)
        {
            int[] Vetor = new int[10];

            Random x = new Random();

            CriaVetor(Vetor, x, 0, Vetor.Length);

            MostraVetor(Vetor, 0, Vetor.Length);

            Console.ReadKey();
        }        
    }   
}
