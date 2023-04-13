using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    internal class Aluno
    {
        public string nome { get; set; }
        public string mail { get; set; }
        public string dataNascimento { get; set; }
        public string telefone { get; set; }               

        public void lerDados()
        {
            Console.Write("Nome do aluno: ");
            nome = Console.ReadLine();

            Console.Write("Digite o e-mail: ");
            mail = Console.ReadLine();

            Console.Write("Digite a data de nascimento: ");
            dataNascimento = Console.ReadLine();

            Console.Write("Digite o telefone: ");
            telefone = Console.ReadLine();
            Console.Clear();
        }

        public void mostrarDados()
        {
            Console.WriteLine("Dados do aluno\n");
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"E-mail: {mail}");
            Console.WriteLine($"Data de nascimento: {mail}");
            Console.WriteLine($"Telefone: {mail}");
            Console.ReadKey();
        }

    }
}
