using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoHashTable
{
    public class Paciente
    {
        public string RG { get; set; }
        public string Nome { get; set; }
        public string Nasciemento { get; set; }
        public string Telefone { get; set; }

        public void lerDados()
        {
            Console.Write("Nome: ");
            Nome = Console.ReadLine();

            Console.Write("RG: ");
            RG = Console.ReadLine();

            Console.Write("Nascimento: ");
            Nasciemento = Console.ReadLine();

            Console.Write("Telefone: ");
            Telefone = Console.ReadLine();            
        }

        public void mostrarDados()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"RG: {RG}");
            Console.WriteLine($"Nascimento: {Nasciemento}");
            Console.WriteLine($"Telefone: {Telefone}");
            Console.WriteLine();
        }
    }
}
