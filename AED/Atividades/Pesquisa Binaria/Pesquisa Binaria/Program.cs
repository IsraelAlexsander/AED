using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pesquisa_Binaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Nr;
            int Inicio;
            int Fim;
            int Meio;

            bool achou;

            int[] Vetor = { 12, 25, 34, 41, 47, 57, 67, 72, 82, 96 };

            Console.WriteLine("12, 25, 34, 41, 47, 57, 67, 72, 82, 96\n\n");

            Console.Write("\nElemento procurado: ");
            Nr = int.Parse(Console.ReadLine());

            achou = false;

            Inicio = 0;
            Fim = 9;
            Meio = (Inicio + Fim) / 2;

            while(Inicio <= Fim)
            {
                if (Vetor[Meio] == Nr)
                    achou = true;

                else
                {
                    if (Nr < Vetor[Meio])
                        Fim = Meio - 1;
                    else if (Nr > Vetor[Meio])
                        Inicio = Meio + 1;

                    Meio = (Inicio + Meio) / 2;
                }
            }

            if (!achou)
                Console.WriteLine("\n\nElemento não encontrado");
            else
                Console.WriteLine($"\n\nElemento encontrado na posição {Meio + 1}");

            Console.ReadKey();
        }
    }
}
