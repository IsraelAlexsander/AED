using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    internal class Program
    {

        static int[,] criaMatriz(int n)
        {
            int[,] M = new int[n, n];

            Random r = new Random();

            for (int i = 0; i < M.GetLength(0); i++)
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    M[i, j] = r.Next(0,51);
                }

            mostraMatriz(M);
            return M;
        }

        static void mostraMatriz(int[,] M)
        {
            Console.WriteLine($"\nMatriz {M.GetLength(0)} x {M.GetLength(1)}");
            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                    Console.Write($"{M[i, j],4}");
                Console.WriteLine();
            }
        }

        static int somarDiagonal(int[,] M, int i = 0, int j = 0, int soma = 0)
        {   
            if (i < M.GetLength(0) && j < M.GetLength(1))
            {
                if (i == j)
                {
                    soma += M[i, j];
                }

                if (j < M.GetLength(1) - 1)
                    return somarDiagonal(M, i, ++j, soma);
                else if (j == M.GetLength(0) - 1)
                    return somarDiagonal(M, ++i, 0, soma);
            }

            return soma;
        }

        static void Main(string[] args)
        {
            Console.Write("Digite a medida da matriz quadrada: ");
            int n = int.Parse(Console.ReadLine());

            int[,] M = criaMatriz(n);

            Console.WriteLine($"\nA soma da diagonal principal é: {somarDiagonal(M)}");

            Console.ReadKey();
        }
    }
}
