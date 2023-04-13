using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicarComAdicaoRecursivo
{
    internal class Program
    {
        static int multiplicarSomando (int A, int B, int M, int S)
        {
            int soma = S;

            if (M > B)
                return soma;
            else                           
                return (A + multiplicarSomando(A, B, ++M, soma));            
        }
        static void Main(string[] args)
        {
            int A;
            int B;
            int M = 1;
            int S = 0;

            Console.Write("Digite o multiplicador: ");
            A = int.Parse(Console.ReadLine());

            Console.Write("Digite o multiplicando: ");
            B = int.Parse(Console.ReadLine());

            Console.WriteLine($"O produto de {A} e {B} é : {multiplicarSomando(A,B,M,S)}");

            Console.ReadKey();
        }
    }
}
