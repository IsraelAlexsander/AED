using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverterString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite uma palavra: ");
            string palavra = Console.ReadLine().ToLower(); //To.Upper Deixa todos os caracteres em maiusculo
            string inverso = "";

            foreach (char letra in palavra)
            {
                inverso = letra + inverso;
            }

            Console.WriteLine($"O inverso da palavra é: {inverso}");

            Console.ReadKey();
        }
    }
}
