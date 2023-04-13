using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorteio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lista MinhaLista = new Lista();

            Console.Write("Digite o número de alunos: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Digite o nome {i}º do Aluno: ");
                string nome = Console.ReadLine();                

                MinhaLista.Inserir(nome);
            }

            MinhaLista.Mostra();

            Console.WriteLine();

            MinhaLista.Sortear();

            Console.ReadKey();
        }
    }
}
