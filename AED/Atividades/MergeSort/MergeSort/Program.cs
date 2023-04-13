using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] X = new int[100000];

            Random x = new Random();

            for(int i = 0; i < 100000; i++)
            {
                //X[i] = x.Next(0, 51);
                X[i] = i;
            }

            //mostra(X);

            Stopwatch sw = new Stopwatch();
            sw.Start();

            merge(X, 0, X.Length-1);

            sw.Stop();

            TimeSpan ts = sw.Elapsed;

            Console.WriteLine();

            //mostra(X);

            Console.WriteLine($"Tempo: {ts.TotalMilliseconds.ToString()}\n");

            Console.ReadKey();

        }

        static void mostra(int[] X)
        {
            for (int i = 0; i < X.Length; i++)
            {
                Console.Write($"{X[i],6}");
            }
            Console.ReadKey();
        }
        
        static void merge(int[] X, int inicio, int fim)
        {
            int meio;

            if (inicio < fim)
            {
                meio = (inicio + fim) / 2;

                merge(X, inicio, meio);
                merge(X, meio + 1, fim);

                intercala(X, inicio, fim, meio);
            }
        }

        static void intercala(int[] X, int inicio, int fim, int meio)
        {
            int pos;

            int inicioVetorA, inicioVetorB;

            int[] Aux = new int[100000];

            inicioVetorA = inicio;
            inicioVetorB = meio + 1;

            pos = inicio;


            while (inicioVetorA <= meio && inicioVetorB <= fim)
            {
                if (X[inicioVetorA] < X[inicioVetorB])
                {
                    Aux[pos] = X[inicioVetorA];
                    inicioVetorA++;
                }
                else
                {
                    Aux[pos] = X[inicioVetorB];

                    inicioVetorB++;
                }

                pos++;
            }

            for (int i = inicioVetorA; i <= meio; i++)
            {
                Aux[pos] = X[i];
                pos++;
            }

            for (int i = inicioVetorB; i <= fim; i++)
            {
                Aux[pos] = X[i];
                pos++;
            }

            for(int i = inicio; i <= fim; i++)
            {
                X[i] = Aux[i];
            }
        }
    }
}
