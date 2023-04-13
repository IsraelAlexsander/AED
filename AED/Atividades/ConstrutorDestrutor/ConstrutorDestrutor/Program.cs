using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstrutorDestrutor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vetor V = new Vetor(5, 0, 10);

            V.Mostra();

            Console.Write($"\n\nA soma dos elementos é: {V.Soma()}");

            Console.ReadKey();

            V.Coloca(99, 2);
            
            Console.WriteLine();
            Console.WriteLine();

            V.Mostra();

            Console.WriteLine();

            Console.WriteLine($"\nO elemento 3 é: {V.Consulta(2)}");

            Console.ReadKey();
        }
    }
}
