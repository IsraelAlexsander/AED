using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaProvas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] notas = new int[10, 4];

            Random x = new Random(); //Cria uma variavel randomica

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    notas[i, j] = x.Next(0, 26); //sorteia um número de 0 a 25
                    Console.Write(notas[i,j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();            

            for (int i = 0; i < 10; i++)
            {
                int soma = 0;

                for (int j = 0; j < 4; j++)
                {
                    soma += notas[i, j];
                }

                Console.WriteLine($"Nota do Aluno {i+1:00}: {soma}");     //:00 formata o número. o 1 ficaria 01           
            }

            Console.WriteLine();

            for (int i = 0; i < 4; i++)
            {
                int somaP = 0;

                for (int j = 0; j < 10; j++)
                {
                    somaP += notas[j, i];
                }

                Console.WriteLine($"Media da prova {i}: {somaP/10}");     //:00 formata o número. o 1 ficaria 01           
            }

            Console.ReadKey();
        }
    }
}
