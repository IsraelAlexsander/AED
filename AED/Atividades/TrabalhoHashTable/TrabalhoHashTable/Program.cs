using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoHashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Clinica Odontológica";            

            Menu meuMenu = new Menu(new Operacoes(), new Dados());
            meuMenu.Mostrar();            
        }
    }
}
