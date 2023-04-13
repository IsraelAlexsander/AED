using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    internal class Aluno
    {
        public string nome { get; set; }
        public string mail { get; set; }
        public string telefone { get; set; }

        public DataNascimento nascimento = new DataNascimento();

        public void lerDados()
        {
            Console.Write("Nome do aluno: ");
            nome = Console.ReadLine();

            Console.Write("Digite o e-mail: ");
            mail = Console.ReadLine();

            Console.WriteLine("Digite a data de nascimento: ");
            nascimento.lerDataNascimento();

            Console.Write("Digite o telefone: ");
            telefone = Console.ReadLine();
            Console.Clear();
        }

        public void mostrarDados()
        {
            Console.WriteLine();
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"E-mail: {mail}");
            nascimento.exibirDataNascimento();
            Console.WriteLine($"Telefone: {mail}");
            Console.WriteLine();            
        }
    }   
}
