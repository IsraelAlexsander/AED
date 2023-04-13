using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] provas = new int[20, 3];

            Random random = new Random();

            for (int i = 0; i < provas.GetLength(0); i++)
            {
                Console.WriteLine($"Aluno {i + 1}");
                for (int j = 0; j < provas.GetLength(1); j++)
                {                    
                    Console.Write($"{j}ª prova: ");
                    provas[i, j] = random.Next(0, 11);
                    Console.WriteLine(provas[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 0; i < provas.GetLength(0); i++)
            {
                int totalAluno = 0;

                for (int j = 0; j < provas.GetLength(1); j++)
                {
                    totalAluno += provas[i, j];
                }
                Console.WriteLine($"O total de pontos do aluno {i + 1} = {totalAluno}\n");
            }

            for (int i = 0; i < provas.GetLength(1); i++)
            {
                double totalProva = 0;

                for (int j = 0; j < provas.GetLength(0); j++)
                {
                    totalProva += provas[j, i];
                }
                Console.WriteLine($"A média da {i + 1} prova: {totalProva / 20}\n");
            }

            Console.ReadKey();
        }
    }
}
