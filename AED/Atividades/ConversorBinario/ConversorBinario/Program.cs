using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorBinario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            string resultado = "";

            Console.Write("Digite um número: ");
            n = int.Parse(Console.ReadLine());

            while (n > 1)
            {
                resultado = (n % 2) + resultado; 

                n = n / 2;  
            }

            resultado = (n % 2) + resultado;

            Console.WriteLine($"Esse número na base 2 é: {resultado}");

            Console.ReadKey();
        }
    }
}
