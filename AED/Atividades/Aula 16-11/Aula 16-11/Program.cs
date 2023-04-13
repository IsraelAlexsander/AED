using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_16_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            int Nr;
            bool achou;

            int[] V = new int[1000000];

            for (i = 0; i < 100000; i++)
            {
                V[i] = i + 1;

                Console.Write($"Criando vetor de inteiros... {i} elementos...\r"); //Escreve por cima
            }

            Console.WriteLine("Busca sequencial");
            Console.Write("Digite um número: ");
            Nr = int.Parse(Console.ReadLine());

            i = 0;
            achou = false;

            Stopwatch sw = new Stopwatch();

            sw.Start();

            while(i <= 99999 && !achou && Nr >= V[i])
            {
                if (V[i] == Nr)                
                    achou = true;                
                else
                    i++;
            }
            if (achou)            
                Console.WriteLine($"\nElemento encontrado no vetor na posição {i + 1}...");            
            else
                Console.WriteLine("\nElemento não encontrado...");

            sw.Stop();

            TimeSpan T = sw.Elapsed;

            Console.WriteLine($"\nTempo de pesquisa: {T.TotalMilliseconds.ToString()} milissegundos");            

            sw.Reset();

            achou = false;

            int inicio = 0;
            int fim = 99999;
            int meio = (inicio + fim) / 2;

            sw.Start();

            while(inicio <= fim && !achou)
            {
                if (V[meio] == Nr)
                    achou = true;
                else
                {
                    if (Nr < V[meio])
                        fim = meio - 1;
                    else
                        inicio = meio + 1;

                    meio = (inicio + fim) / 2;
                }
            }
            if (achou)
                Console.WriteLine($"\nElemento encontrado no vetor na posição {i + 1}...");
            else
                Console.WriteLine("\nElemento não encontrado...");

            sw.Stop();

            T = sw.Elapsed;

            Console.WriteLine($"\nTempo de pesquisa: {T.TotalMilliseconds.ToString()} milissegundos");
            Console.ReadKey();
        }
    }
}
