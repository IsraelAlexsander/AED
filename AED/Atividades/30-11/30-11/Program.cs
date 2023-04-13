using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_11
{
    internal class Program
    {
        #region Parte 1
        //static int calcPot(int x, int y)
        //{
        //    int R = 1; // 1

        //    for (int i = 1; i <= y; i++) // 2(n+1)
        //    {
        //        R = R * x; // n
        //    }
        //    return R; // 1
        //} // Função de custo === 1 + 2(n+1) + n + 1 = 3n + 4

        //static void Main(string[] args)
        //{
        //    int x, y;

        //    x = 2;
        //    y = 5;

        //    Console.WriteLine($"2^5 = {calcPot(2,5)}\n\n");
        //}
        #endregion
        static void Main(string[] args)
        {
            int[,] Matriz = new int[3, 3];

            Random x = new Random();

            int soma = 0;

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    Matriz[i, j] = x.Next(0, 51);

            mostra(Matriz);

            Console.ReadKey();

            soma = somaPares(Matriz);
            Console.WriteLine($"Soma = {soma}\n");

        }
        static void mostra(int[,] M)
        {
            for (int i = 0; i < M.GetLength(0); i++)         // 2(n + 1)
            {
                Console.WriteLine("\n");                     // n

                for (int j = 0; j < M.GetLength(1); j++)     // n(2n + 2)           
                    Console.WriteLine($"{M[i,j],6}");        // n²          
            }
                
        } // Função de custo === 3n² + 5n + 2

        static int somaPares(int[,] M)
        {
            int R = 0;                           // 1

            for (int i = 0; i < 2; i++)          //2n+2
            {
                for (int j = 0; j < 2; j++)      // n(2n+2)
                {
                    if (M[i,j] % 2 == 0)         // n²
                    {
                        R += M[i, j];            // Melhor caso = 0      Pior caso = n²
                    }
                }
            }
            return R;                            // 1
        }
    }//Função de custo -> Melhor caso: 3n² + 4n + 4     Pior caso: 4n² + 4n + 4
}
