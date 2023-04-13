using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_16_11_2 // Tabela Hash
{
    class Funcionario
    {
        public string codigo { get; set; }
        public string nome { get; set; }
        public string mail { get; set; }
        public string telefone { get; set; }
    }    
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable Cad = new Hashtable();

            Funcionario xFun;

            for (int i = 1; i <= 5; i++)
            {
                xFun = new Funcionario();

                Console.Write("\nCódigo do funcionário: ");
                xFun.codigo = Console.ReadLine();

                Console.Write("Nome: ");
                xFun.nome = Console.ReadLine();

                Console.Write("Mail: ");
                xFun.mail = Console.ReadLine();

                Console.Write("Telefone: ");
                xFun.telefone = Console.ReadLine();

                Cad.Add(xFun.codigo, xFun);
            }

            Console.Clear();

            foreach(Funcionario x in Cad.Values)
            {
                Console.WriteLine($"{x.nome} - {x.codigo}");
                Console.WriteLine($"Mail: {x.mail}");
                Console.WriteLine($"Telefone: {x.telefone}");
            }

            Console.ReadKey();

            string chaveProcura;

            Console.WriteLine("\n\nDigite o código do funcionário: ");
            chaveProcura = Console.ReadLine();

            if (Cad.ContainsKey(chaveProcura))
            {
                Console.WriteLine($"Chave encontrada no cadastro...");

                Funcionario F = (Funcionario)Cad[chaveProcura];

                Console.WriteLine($"\nNome: {F.nome}");
            }
            else
                Console.WriteLine("\nChave não encontrada");

            Console.ReadKey();

            Cad.Remove(chaveProcura);

            Console.Clear();

            foreach (Funcionario x in Cad.Values)
            {
                Console.WriteLine($"{x.nome} - {x.codigo}");
                Console.WriteLine($"Mail: {x.mail}");
                Console.WriteLine($"Telefone: {x.telefone}");
            }

            Console.ReadKey();            
        }        
    }
}
