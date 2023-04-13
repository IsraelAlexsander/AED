using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equação_2_Grau
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Eq2Grau MinhaEquacao = new Eq2Grau();

            Console.Write("a: ");
            MinhaEquacao.a = double.Parse(Console.ReadLine());

            Console.Write("b: ");
            MinhaEquacao.b = double.Parse(Console.ReadLine());

            Console.Write("c: ");
            MinhaEquacao.c = double.Parse(Console.ReadLine());

            MinhaEquacao.CalcDelta();
            

            if (MinhaEquacao.Delta < 0)
                Console.WriteLine("Não existem raízes");
            else
            {
                MinhaEquacao.CalcRaiz();

                Console.Write($"Raiz 1 = {MinhaEquacao.Raiz1}\n");
                Console.Write($"Raiz 2 = {MinhaEquacao.Raiz2}");
            }

            Console.ReadKey();
        }
    }
}
