using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosComplexos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Complexos N1 = new Complexos();

            N1.PReal = 4;
            N1.PImg = -3;

            Complexos N2 = new Complexos();

            N2.PReal = 2;
            N2.PImg = 4;

            Complexos Result = new Complexos();

            Complexos Soma;
            Complexos Subtracao;

            Console.Write("Soma: ");

            Soma = Result.SomaComplexos(N1, N2);

            Soma.MostraComplexo();

            Console.Write("\nSubtração: ");

            Subtracao = Result.SubtracaoComplexos(N1, N2);

            Result.MostraComplexo();

            Console.ReadKey();
        }
    }
}
