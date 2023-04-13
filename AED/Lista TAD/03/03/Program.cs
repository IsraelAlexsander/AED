using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Sistema de Cadastro";
            Menu meuMenu = new Menu(new Dados(), new Operacoes());
            meuMenu.mostraMenu();
        }
    }
}
