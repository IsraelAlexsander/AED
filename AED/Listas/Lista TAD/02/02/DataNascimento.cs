using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    internal class DataNascimento
    {
        public int dia { get; set; }
        public int mes { get; set; }
        public int ano { get; set; }


        public void lerDataNascimento()
        {
            Console.Write("Dia: ");
            dia = int.Parse(Console.ReadLine());

            Console.Write("Mês: ");
            mes = int.Parse(Console.ReadLine());

            Console.Write("Ano: ");
            ano = int.Parse(Console.ReadLine());
        }
        public void exibirDataNascimento()
        {
            Console.WriteLine($"Data de nascimento: {dia}/{mes}/{ano}");
        }
    }
}
