using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayJagged
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Número de turmas: ");
            int NrTurmas = int.Parse(Console.ReadLine());

            string[][] Turmas = new string[NrTurmas][]; 

            for (int i = 0; i < NrTurmas; i++)
            {
                Console.Write($"Quantos alunos a turma {i + 1} tem? ");
                int NrAlunos = int.Parse(Console.ReadLine());

                Turmas[i] = new string[NrAlunos];

                for (int j = 0; j < NrAlunos; j++)
                {
                    Console.Write($"Nome {j+1}º aluno: ");
                    Turmas[i][j] = Console.ReadLine();
                }                
            }

            //Mostrar
            
            for (int i = 0; i < NrTurmas; i++)
            {
                Console.WriteLine($"\nTurma {i+1}");

                for (int j = 0; j < Turmas[i].GetLength(0); j++)
                {
                    Console.WriteLine(Turmas[i][j]);
                }
            }

            Console.ReadKey();
        }
    }
}
