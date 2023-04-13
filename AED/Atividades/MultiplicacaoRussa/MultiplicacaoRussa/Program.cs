using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicacaoRussa
{
    internal class Program
    {
        static int multiplicacaoRussa (int A, int B, int R)
        {
            int produto = R;
            if (A < 1 || B < 1) // Condição de parada
                return produto;
            else
            {
                if (A % 2 != 0)
                {
                    produto += B;                    
                }
                return multiplicacaoRussa(A / 2, B * 2, produto);
            }            
        }
        static void Main(string[] args)
        {
            int A;
            int B;
            int R = 0;

            Console.Write("Digite o multiplicador: ");
            A = int.Parse(Console.ReadLine());

            Console.Write("Digite o multiplicando: ");
            B = int.Parse(Console.ReadLine());

            Console.WriteLine($"O produto de {A} e {B} é: {multiplicacaoRussa(A,B,R)}");
            Console.ReadKey();
        }
    }
}
