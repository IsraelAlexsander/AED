using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    internal class Program
    {
        static int calcular(int n, int i = 2, int s = 1)
        {
            int soma = s;

            if (n == 1)
                return 1;

            if (i <= n)
            {
                if (i % 2 == 0)
                    soma = soma + i;
                else
                    soma = soma - i;

                return calcular(n, ++i, soma);
            }

            return soma;
        }

        static void Main(string[] args)
        {
            Console.Write("Digite o valor de n: "); 
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"O resultado é: {calcular(n)}");

            Console.ReadKey();

        }
    }
}
