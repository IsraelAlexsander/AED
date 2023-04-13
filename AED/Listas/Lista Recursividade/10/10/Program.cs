using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    internal class Program
    {
        static bool testaPalindromo(string P)
        {
            bool teste;

            if (P.Length <= 1)
                return (teste = true);

            else
                if (P[0] == P[P.Length - 1])
                return testaPalindromo(P.Substring(1, P.Length - 2));
            else
                return (teste = false);

        }
        static void Main(string[] args)
        {
            Console.Write("Digite uma palavra: ");
            string P = Console.ReadLine();

            if (testaPalindromo(P))
                Console.WriteLine("É Palindromo");
            else
                Console.WriteLine("Não é Palindromo");

            Console.ReadKey();

        }
    }
}
