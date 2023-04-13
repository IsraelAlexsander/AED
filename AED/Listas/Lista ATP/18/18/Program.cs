using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18
{
    internal class Program
    {

        static int[,] GeraMatriz(int n)
        {
            int[,] M = new int[n,n];

            Random random = new Random();

            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    M[i, j] = random.Next(0, 11);

            return (M);
        }


        static void MostraMatriz(int[,] Matriz)
        {
            for (int i = 0; i < Matriz.GetLength(0); i++)
            {
                for (int j = 0; j < Matriz.GetLength(1); j++)
                {
                    Console.Write($"{Matriz[i,j],4}");
                }
                Console.WriteLine();
            } 
        }


        static int[,] MatrizResultante(int[,] M)
        {
            int[,] Matriz = new int[M.GetLength(0),M.GetLength(1)];

            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    if (M[i,j] % 2 == 0)
                    {
                        Matriz[i,j] = M[i,j];
                    }
                    else
                    {
                        Matriz[i, j] = 0;
                    }
                }
            }

            return (Matriz);
        }


        static void Main(string[] args)
        {           
            Console.WriteLine("Digite a medida da matriz quadrada: ");
            int n = int.Parse(Console.ReadLine());

            int[,] M = GeraMatriz(n);
            int[,] R = MatrizResultante(M);

            Console.WriteLine("Matriz Normal");
            MostraMatriz(M);

            Console.WriteLine();                       

            Console.WriteLine("Matriz Resultante");
            MostraMatriz(R);

            Console.ReadKey();
        }
    }
}
