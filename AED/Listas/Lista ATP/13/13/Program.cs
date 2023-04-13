
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13
{
    internal class Program
    {
        static int[] RetornaVetor(int[,] M)
        {
            int[] V = new int[6];
            int cont = 0;
            
                for (int i = 0; i < M.GetLength(0); i++)
                    for (int j = 0; j < M.GetLength(1); j++)
                        if (i != j)
                        {
                            V[cont] = M[i, j];
                            cont++;
                        }

            return (V);
        }

        static void Main(string[] args)
        {
            int[,] M = new int[3, 3];

            Random r = new Random();

            //Colocando valores na Matriz
            for (int i = 0; i < M.GetLength(0); i++)
                for (int j = 0; j < M.GetLength(1); j++)
                    M[i, j] = r.Next(0,100);

            //Exibindo Matriz
            Console.WriteLine("Matriz");
            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                    Console.Write($"{M[i, j],4}");
                Console.WriteLine();
            }

            int[] V = RetornaVetor(M);


            Console.WriteLine("\nVetor");
            for (int i = 0; i < V.Length; i++)
                Console.Write($"{V[i],4}");

            Console.ReadKey(); 
        }
    }
}
