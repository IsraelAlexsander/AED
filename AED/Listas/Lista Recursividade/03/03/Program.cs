using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    internal class Program
    {
        static string inverter(string p, string cont = "", int i = 1)
        {
            string contrario = cont;

            if (i <= p.Length)
            {
                contrario = contrario + p[p.Length - i] + inverter(p, contrario, ++i);
            }

            return contrario;
        }

        static void Main(string[] args)
        {
            Console.Write("Digite uma palavra: ");
            string p = Console.ReadLine();

            string c = inverter(p);

            Console.WriteLine($"Inverso : {c}"); Console.ReadKey();
        }
    }
}
