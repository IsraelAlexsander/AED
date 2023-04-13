using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix_Jagged
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[][] Turmas;

            Console.Write($"Digite a quantidade de turmas: ");
            int nTurmas = int.Parse(Console.ReadLine());

            Turmas = new string[nTurmas][]; // Define o tamanho da primeira dimensão
            
            for (int i = 0; i < nTurmas; i++)
            {
                Console.Write($"Quantos alunos tem a turma {i + 1}: ");
                int nAlunos = int.Parse(Console.ReadLine());

                Turmas[i] = new string[nAlunos]; // Define o tamanho da segunda dimensão

                for (int j = 0; j < nAlunos; j++)
                {
                    Console.Write($"Digite o nome do {j+1}º aluno: ");
                    Turmas[i][j] = Console.ReadLine();
                }
            }

            Console.Clear();

            for (int i = 0; i < nTurmas; i++)
            {
                Console.WriteLine($"\nTurma {1+i}");

                for (int j = 0; j < Turmas[i].GetLength(0); j++)
                {
                    Console.WriteLine($"{Turmas[i][j]}");
                }
            }

            Console.ReadKey();
        }
    }
}
