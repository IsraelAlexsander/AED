using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestePrimo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inicio:            
            Console.WriteLine("Digite um valor para teste: ");
            int n = int.Parse(Console.ReadLine());

            int divisores = 0;

            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                    divisores++;
            }

            if (divisores <= 2)
                Console.WriteLine("É primo");
            else
                Console.WriteLine("Não é primo");

            Console.WriteLine("Deseja testar outro número? Digite 'S' para sim");
            
            if (Console.ReadKey().Key == ConsoleKey.S)
            {
                Console.Clear();
                goto Inicio;
            }
        }
    }
}
