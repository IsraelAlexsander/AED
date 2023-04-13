using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosOrdenacao01
{
    internal class Program //Bouble Sort
    {
        static void Main(string[] args)
        {
            int[] X = { 4, 9, 7, 2, 8, 5, 1, 3, 0, 6 };
            int Aux;

            Console.WriteLine("Vetor");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{X[i],6}");
            }

            Console.WriteLine("\n");
            Console.ReadKey();

            #region Algoritimo Padrão

            for (int i = 1; i < 10; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (X[j] > X[j + 1])
                    {
                        Aux = X[j];
                        X[j] = X[j + 1];
                        X[j + 1] = Aux;
                    }
                }
            }

            Console.WriteLine("Vetor Ordenado");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{X[i],6}");
            }

            Console.WriteLine("\n");
            Console.ReadKey();
            #endregion

            #region Versão 2
            for (int i = 1; i < 10; i++)
            {
                for (int j = 9; j >= i; j--)
                {
                    if (X[j] < X[j - 1])
                    {
                        Aux = X[j];
                        X[j] = X[j - 1];
                        X[j - 1] = Aux;
                    }
                }
            }

            Console.WriteLine("Vetor Ordenado II");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{X[i],6}");
            }
            #endregion

            Console.ReadKey();
        }
    }
}
