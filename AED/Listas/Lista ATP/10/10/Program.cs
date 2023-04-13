using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double ArvoreA = 0.8;
            double ArvoreB = 1.3;
            int contaAno = 0;

            while (ArvoreA <= ArvoreB)
            {
                ArvoreA += 0.12;
                ArvoreB += 0.08;
                contaAno++;
            }

            Console.WriteLine($"A Arvore A será maior que a Arvore B em {contaAno} anos");

            Console.ReadKey();
        }
    }
}
