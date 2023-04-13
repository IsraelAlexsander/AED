using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioProposto1
{
    internal class Professor
    {
        public string nome;
        public string telefone;
        public string mail;       

        public void lerDados()
        {            
            Console.Write("Nome: ");
            nome = Console.ReadLine();

            Console.Write("Telefone: ");
            telefone = Console.ReadLine();

            Console.Write("E-mail: ");
            mail = Console.ReadLine();            
        }
    }
}
