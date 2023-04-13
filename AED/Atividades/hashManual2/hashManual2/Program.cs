using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hashManual2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            //int Nr;
            //int i;

            //bool achou;

            //int[] Vetor = { 2, 3, 6, 8, 0, 1, 7, 9, 4, 5 };

            //Console.WriteLine("2, 3, 6, 8, 0, 1, 7, 9, 4, 5");

            //Console.Write("\nElemento procurado: ");
            //Nr = int.Parse(Console.ReadLine());

            //i = 0;
            //achou = false;

            //while(i <= 9 && !achou)
            //{
            //    if (Vetor[i] == Nr)
            //    {
            //        achou = true;
            //    }
            //    else
            //    {
            //        i++;
            //    }
            //}

            //if (!achou)
            //{
            //    Console.WriteLine("\nElemento não encontrado!");
            //}
            //else
            //{
            //    Console.WriteLine($"\nElemento encontrado na posição {i + 1}");
            //}

            //Console.ReadKey();
            #endregion

            int Nr;
            int i;

            bool achou;

            int[] Vetor = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.WriteLine("0, 1, 2, 3, 4, 5, 6, 7, 8, 9");

            Console.Write("\nElemento procurado: ");
            Nr = int.Parse(Console.ReadLine());

            i = 0;
            achou = false;

            while ((i <= Nr && i <= 9) && !achou)
            {
                if (Vetor[i] == Nr)
                {
                    achou = true;
                }
                else
                {
                    i++;
                }
            }

            if (!achou)
            {
                Console.WriteLine("\nElemento não encontrado!");
            }
            else
            {
                Console.WriteLine($"\nElemento encontrado na posição {i + 1}");
            }

            Console.ReadKey();
        }
    }
}
