using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompararString
{
    internal class Program
    {
        static bool CompararString(string frase1, string frase2, int i)
        {
            bool teste = (frase1[i] == frase2[i]);

            if (i == frase1.Length - 1)
                return teste;
            else
                return teste && CompararString(frase1, frase2, ++i);
        }
        static void Main(string[] args)
        {
            Console.Write("Digite uma frase: ");
            string frase1 = Console.ReadLine();

            Console.Write("Digite outra frase: ");
            string frase2 = Console.ReadLine();

            if (CompararString(frase1, frase2, 0))
                Console.WriteLine("As frases são iguais");
            else
                Console.WriteLine("As frases são diferentes");

            Console.ReadKey();
        }
    }
}
