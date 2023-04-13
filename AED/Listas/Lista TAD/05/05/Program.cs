using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    internal class Program
    {        
        static void Main(string[] args)
        {
            Console.Title = "Inventario";
            Menu meuMenu = new Menu();

            meuMenu.exibir(new Dados());
        }
    }
}
