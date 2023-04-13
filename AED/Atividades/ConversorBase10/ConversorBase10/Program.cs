using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorBase10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double exp = 0;
            double NB10 = 0;

            Console.Write("Digite um número na base 2: ");
            string NB2 = Console.ReadLine();

            for (int i = NB2.Length - 1; i >= 0; i--)
            {
                NB10 = NB10 + char.GetNumericValue(NB2[i]) * Math.Pow(2, exp++);
            }

            Console.WriteLine($"Este número na base 10 é: {NB10}");


            Console.ReadKey();
        }
    }
}
