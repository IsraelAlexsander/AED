using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14
{
    internal class Program
    {
        static string[] ReceberNomes()
        {
            string[] Nomes = new string[10];
            
            for (int i = 0; i < Nomes.Length; i++)
            {
                Console.Write($"Nome {i + 1}º aluno: ");
                Nomes[i] = Console.ReadLine();
                Console.WriteLine();
            }

            Console.Clear(); 
            return (Nomes);
        }

        static int[,] ReceberNotas(string[] Nomes)
        {
            int[,] Provas = new int[Nomes.Length, 3];            

            for (int i = 0; i < Provas.GetLength(0); i++)
            {                
                Console.WriteLine($"Aluno: {Nomes[i]}");
                for (int j = 0; j < Provas.GetLength(1); j++)
                {
                    Console.Write($"{j + 1}º Prova: ");
                    Provas[i, j] = int.Parse(Console.ReadLine());
                }

                Console.Clear();
                Console.WriteLine();
            }

            Console.Clear();
            return (Provas);
        }

        static void MostrarNotas(string[] Nomes, int[,] Provas)
        {
            int[] NotaFinal = new int[Nomes.Length];

            for (int i = 0; i < Provas.GetLength(0); i++)
            {
                NotaFinal[i] = 0;
                Console.WriteLine($"Aluno: {Nomes[i]}");

                for (int j = 0; j < Provas.GetLength(1); j++)
                {
                    Console.Write($"Prova {j + 1}: ");
                    Console.WriteLine(Provas[i,j]);
                    NotaFinal[i] += Provas[i, j];                    
                }

                Console.WriteLine($"Nota Final: {NotaFinal[i]}");
                Console.WriteLine();
                
            }

            Reprovados(NotaFinal, Nomes);
        }

        static void MediaProva(int[,] Prova)
        {            
            for (int i = 0; i < Prova.GetLength(1); i++)
            {
                double totalProva = 0;

                for (int j = 0; j < Prova.GetLength(0); j++)
                {
                    totalProva += Prova[j, i];
                }

                Console.WriteLine($"A média da prova {i + 1}: {totalProva / Prova.GetLength(0)}");
            }    
        }

        static void Reprovados(int[] notaFinal, string[] Nomes)
        {
            Console.WriteLine("Alunos com nota final menor que 60");

            for (int i = 0; i < notaFinal.Length; i++)
                if (notaFinal[i] < 60)
                    Console.WriteLine($"{Nomes[i]}");
        }
        
        static void Main(string[] args)
        {
            string[] Nomes = ReceberNomes();
            int[,] Provas = ReceberNotas(Nomes);

            MostrarNotas(Nomes, Provas);

            Console.WriteLine();

            MediaProva(Provas);            

            Console.ReadKey();
        }
    }
}
