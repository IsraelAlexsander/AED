using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoRascunho
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            int[] Y = new int[1000000];
            Random r = new Random();


            for (int i = 0; i < Y.Length; i++)
            {                
                Y[i] = r.Next(0,101);
            }


            Console.WriteLine("Iniciou");
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Merge(Y, 0, 1000000 - 1);
            sw.Stop();
            TimeSpan ts = sw.Elapsed;
            Console.WriteLine($"Tempo: {ts.TotalMilliseconds.ToString()}\n");

            //Console.WriteLine("\nVetor Ordenado (MERGE SORT): ");
            //for (int i = 0; i < 100; i++)
            //{
            //    Console.WriteLine($"{Y[i]}");
            //}

            Console.ReadKey();

        }

        static void Merge(int[] X, int Início, int Fim)
        {
            int Meio;           

            if (Início < Fim)   
            {
                Meio = (Início + Fim) / 2;

                Merge(X, Início, Meio);   
                Merge(X, Meio + 1, Fim);  

                Intercala(X, Início, Fim, Meio);  
            }
        }

        static void Intercala(int[] X, int Início, int Fim, int Meio)
        {
            int PosLivre, InícioVetorA, InícioVetorB, i;
            int[] Aux = new int[1000000];

            InícioVetorA = Início;
            InícioVetorB = Meio + 1;
            PosLivre = Início;

            while (InícioVetorA <= Meio && InícioVetorB <= Fim)
            {
                if (X[InícioVetorA] <= X[InícioVetorB])        
                {
                    Aux[PosLivre] = X[InícioVetorA];
                    InícioVetorA = InícioVetorA + 1;
                }
                else
                {
                    Aux[PosLivre] = X[InícioVetorB];           
                    InícioVetorB = InícioVetorB + 1;
                }

                PosLivre++;
            }

           
            for (i = InícioVetorA; i <= Meio; i++)
            {
                Aux[PosLivre] = X[i];
                PosLivre++;
            }

            
            for (i = InícioVetorB; i <= Fim; i++)
            {
                Aux[PosLivre] = X[i];
                PosLivre++;
            }

           
            for (i = Início; i <= Fim; i++)
            {
                X[i] = Aux[i];
            }
        }
    }
}
