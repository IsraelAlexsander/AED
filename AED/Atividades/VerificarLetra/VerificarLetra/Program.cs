using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificarLetra
{
    internal class Program
    {
        static bool ProcurarLetra(string frase, char letra, int indice)
        {            
            bool existe = (frase[indice] == letra);

            if (indice == frase.Length - 1)
                return false;
            else
                return existe || ProcurarLetra(frase, letra, indice + 1);
        }

        static void Main(string[] args)
        {
            string frase = "Filhos da PUC";
            Console.WriteLine(frase);

            Console.Write("Digite a letra que deseja procurar: ");
            char letra = char.Parse(Console.ReadLine());

            if (ProcurarLetra(frase, letra, 0))
                Console.WriteLine($"A letra '{letra}' existe");
            else
                Console.WriteLine($"A letra '{letra}' não existe");

            Console.ReadKey();

        }
    }
}
