using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaDivisoresRecursividade
{
    internal class Program
    {
        static int contaDiv(int div, int n)
        {
            int qnt = 0;

            if (div <= n)
            {
                if (n % div == 0)
                {
                    qnt = qnt + 1 + (contaDiv(div + 1, n));
                }
                else
                {
                    qnt = qnt + 0 + contaDiv(div + 1, n);
                }
            }

            return (qnt);
        }

        static void Main(string[] args)
        {
            int n;
            int div;

            Console.Write("Digite o valor de n: ");
            n = int.Parse(Console.ReadLine());

            div = contaDiv(1, n);

            Console.WriteLine($"\nQuantidade de divisores: {div}");

            Console.ReadKey();
        }
    }
}
