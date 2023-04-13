using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    internal class Program
    {
        static int potenciaRecursiva(int x, int y, int i = 1)
        {
            int pot = 1;
            if (i <= y)
                pot = x * potenciaRecursiva(x, y, ++i);

            return pot;
        }

        static void Main(string[] args)
        {
            Console.Write("Digite o valor da base: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor da potência: ");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine($"{x} ^ {y} = {potenciaRecursiva(x,y)}");

            Console.ReadKey();
        }
    }
}
