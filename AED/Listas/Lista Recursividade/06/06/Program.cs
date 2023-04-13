using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    internal class Program
    {
        static int[,] criaMatriz(int x, int y)
        {
            int[,] M = new int[x, y];

            Random r = new Random();

            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    M[i, j] = r.Next(0, 51);
                    Console.Write($"{M[i, j],4}");
                }
                Console.WriteLine();
            }

            return M;
        }

        static bool par(int n)
        {
            if (n % 2 == 0)
                return true;
            else
                return false;
        }

        static int procuraMaior(int[,] M, int m, int i, int j)
        {                        
            if (i < M.GetLength(0) && j < M.GetLength(1))
            {

                if (par(M[i,j]))
                {
                    if (M[i,j] > m)
                        m = M[i,j];
                }

                if (j < M.GetLength(1) - 1)
                    return procuraMaior(M, m, i, ++j);
                else
                    return procuraMaior(M, m, ++i, 0);
            }

            return (m);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Digite as medidas da matriz: ");
            Console.Write("Linhas: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Colunas: ");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine();

            int[,] M = criaMatriz(x, y);

            int maior = procuraMaior(M, int.MinValue, 0, 0);

            Console.WriteLine($"\nO maior valor da Matriz é: {maior}");

            Console.ReadKey();
        }
    }
}
