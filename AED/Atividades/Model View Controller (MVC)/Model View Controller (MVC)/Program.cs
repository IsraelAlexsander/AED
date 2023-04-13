using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Collections;

namespace Model_View_Controller__MVC_ //Aplicação Desaclopada  
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Sistema de Cadastro de Alunos";

            Menu MeuMenu = new Menu(new Operacoes(), new Dados());

            MeuMenu.MostraMenu();            
        }
    }
}
