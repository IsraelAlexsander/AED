using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    internal class Produto
    {
        public string nome { get; set; }
        public int codigoCategoria { get; set; }
        public double preco { get; set; }
        public int quantidade { get; set; }


        public void lerProduto()
        {
            Console.Write("Nome do produto: ");
            nome = Console.ReadLine();

            Console.Write("Codigo de Categoria de Produto: ");
            codigoCategoria = int.Parse(Console.ReadLine());

            Console.Write("Preço do produto: ");
            preco = double.Parse(Console.ReadLine());

            Console.Write("Quantidade em estoque: ");
            quantidade = int.Parse(Console.ReadLine());
        }
    }
}
