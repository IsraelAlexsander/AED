using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    internal class Program
    {
        static bool Palindromo(string n)
        {
            bool teste;            

            if (n.Length <= 1)
                return (teste = true);

            else
                if (n[0] == n[n.Length - 1])
                return Palindromo(n.Substring(1, n.Length - 2));
            else
                return (teste = false);
        }

        static void Main(string[] args)
        {
            Console.Write("Digite um número entre 1000 e 9999: ");
            string n = Console.ReadLine();

            bool palindromo = Palindromo(n);

            if (palindromo)
                Console.WriteLine($"O número {n} é Palindromo");
            else
                Console.WriteLine($"O número {n} não é Palindromo");

            Console.ReadKey();
        }
    }
}
