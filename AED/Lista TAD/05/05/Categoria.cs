using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    internal class Categoria
    {        
        public int codigo { get; private set; }
        public string descricao { get; private set; }        

        public void lerCategoria(int codigoCat)
        {
            Console.Write("Descrição da categoria: ");
            descricao = Console.ReadLine();

            Console.Write("Codigo de categoria: ");
            codigo = codigoCat;
        }                 
    }
}
