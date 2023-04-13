using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrizTransposta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Número de linhas: ");
            int linha = int.Parse(Console.ReadLine());

            Console.WriteLine("Número de colunas: ");
            int coluna = int.Parse(Console.ReadLine());

            int[,] matrix = new int[linha,coluna];
            int[,] transposta = new int[coluna,linha];

            Random x = new Random();

            //Matrix

            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = x.Next();


            // Transposta

            for (int i = 0; i < transposta.GetLength(0); i++)
                for (int j = 0; j < transposta.GetLength(1); j++)
                {
                    transposta[i, j] = matrix[j,i];
                }

            Console.WriteLine("Matrix");

            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.WriteLine($"{matrix[i,j ]}");

            for (int i = 0; i < transposta.GetLength(0); i++)
                for (int j = 0; j < transposta.GetLength(1); j++)
                    Console.WriteLine($"{matrix[i,j]}");
            Console.ReadKey();
        }
    }
}
