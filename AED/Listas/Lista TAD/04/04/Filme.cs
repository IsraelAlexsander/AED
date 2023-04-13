using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    internal class Filme
    {        
        public string nome { get; set; }
        public int duracao { get; set; }
        public string diretor { get; set; }
        public string categoria { get; set; }

        public void lerDados()
        {
            Console.Write("Nome do filme: ");
            nome = Console.ReadLine();

            Console.Write("Duração do filme: ");
            duracao = int.Parse(Console.ReadLine());

            Console.Write("Diretor do filme: ");
            diretor = Console.ReadLine();

            Console.Write("Categoria do filme: ");
            categoria = Console.ReadLine();
        }

        public void mostrarDados()
        {
            Console.WriteLine();
            Console.WriteLine($"Nome do filme: {nome}");
            Console.WriteLine($"Duração: {duracao}");
            Console.WriteLine($"Diretor: {diretor}");
            Console.WriteLine($"Categoria: {categoria}");
            Console.WriteLine();
        }
    }
}
