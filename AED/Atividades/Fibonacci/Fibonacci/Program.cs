using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int termos, penultimo = 0, ultimo = 1, atual;

            Console.WriteLine("Sequência Fibonacci");
            Console.Write("Digite a quantidade de termos: ");
            termos = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write($"{penultimo}");

            if (termos > 1)
                Console.Write(", " + ultimo);
            if (termos > 2)
                for (int i = 3; i <= termos; i++)
                {
                    atual = penultimo + ultimo;
                    Console.Write(", " + atual);
                    penultimo = ultimo;
                    ultimo = atual;
                }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
