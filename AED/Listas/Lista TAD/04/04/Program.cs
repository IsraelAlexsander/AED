using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dados meusDados = new Dados();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Filme {i + 1}");
                meusDados.adicionarFilme(new Filme());
                Console.Clear();
            }

            Console.WriteLine("Lista dos filmes");
            meusDados.listarFilmes();

            Console.Clear();

            Console.WriteLine("Digite a categoria que deseja filtrar: ");
            string cat = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Filmes encontrados dessa categoria");
            meusDados.buscarCategoria(cat);

            Console.ReadKey();
        }
    }
}
