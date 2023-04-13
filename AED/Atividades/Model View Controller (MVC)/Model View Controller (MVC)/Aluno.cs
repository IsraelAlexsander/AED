using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model_View_Controller__MVC_
{
    public class Aluno
    {
        public string codigo { get; set; }
        public string nome { get; set; }
        public string telefone { get; set; }
        public string mail { get; set; }

        public Aluno()
        {
            codigo = Guid.NewGuid().ToString().Substring(9,4).ToUpper(); //Identificador Global único
        }

        public void LerDados(bool MostraCodigo = true)
        {
            if (MostraCodigo)
                Console.WriteLine($"Código do Aluno: {codigo}");

            Console.Write("Nome do Aluno: ");
            nome = Console.ReadLine();

            Console.Write("Telefone: ");
            telefone = Console.ReadLine();

            Console.Write("Mail: ");
            mail = Console.ReadLine();
        }

        public void MostraDados()
        {
            Console.WriteLine($"Nome do aluno: {nome} ({codigo})");
            Console.WriteLine($"Telefone: {telefone}");
            Console.WriteLine($"E-Mail: {mail}\n");
        }
    }
}
