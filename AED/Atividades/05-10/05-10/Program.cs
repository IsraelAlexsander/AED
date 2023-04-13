using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_10
{ //Apontador
    class Pessoa
    {
        public string Nome { get; set; }
        public Pessoa Proxima;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa x = new Pessoa();
            Pessoa y = new Pessoa();
            Pessoa z = new Pessoa();

            x.Nome = "Denise";
            y.Nome = "Angela";
            z.Nome = "Patrícia";

            x.Proxima = y; // String tem valor, objeto têm referência
            y.Proxima= z;
            z.Proxima = x;

            Pessoa Aux;

            Aux = x;

            do
            {
                Console.WriteLine(Aux.Nome);

                Aux = Aux.Proxima;
            } while (Aux != x);

            Console.ReadKey();
        }
    }
}
