using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_3_11_4
{
    class Produto
    {
        public string NomeProduto { get; set; }
        public double PrecoProduto { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<Stack<Produto>> MinhaFila = new Queue<Stack<Produto>>();

            Stack<Produto> MinhaPilha;

            Produto xProduto;

            MinhaPilha = new Stack<Produto>();
            xProduto = new Produto();
            xProduto.NomeProduto = "Caderno Espiral Super Max";
            xProduto.PrecoProduto = 34.80;
            MinhaPilha.Push(xProduto);

            xProduto = new Produto();
            xProduto.NomeProduto = "Pasta ZIP - Com furinhos";
            xProduto.PrecoProduto = 65.40;
            MinhaPilha.Push(xProduto);

            xProduto = new Produto();
            xProduto.NomeProduto = "Jogo de Canetas WhitePlux";
            xProduto.PrecoProduto = 23.70;
            MinhaPilha.Push(xProduto);

            MinhaFila.Enqueue(MinhaPilha);

            // 

            MinhaPilha = new Stack<Produto>();
            xProduto = new Produto();
            xProduto.NomeProduto = "Água Mineral São Lourenço";
            xProduto.PrecoProduto = 10.40;   
            MinhaPilha.Push(xProduto);

            xProduto = new Produto();
            xProduto.NomeProduto = "Cerveja Skol";
            xProduto.PrecoProduto = 6.50;
            MinhaPilha.Push(xProduto);

            MinhaFila.Enqueue(MinhaPilha);

            foreach (Stack<Produto> Pilha in MinhaFila)
            {
                Console.WriteLine("Dados da Pilha: \n");

                foreach (Produto x in Pilha)
                {
                    Console.WriteLine($"\t{x.NomeProduto} - R${x.PrecoProduto:F2}");
                }

                Console.WriteLine("\n");
            }

            Console.ReadKey();
        }
    }
}
