using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    internal class Dados
    {
        private ArrayList categorias;
        private ArrayList produtos;

        int totalCategorias;

        public Dados()
        {
            categorias = new ArrayList();
            produtos = new ArrayList();
            totalCategorias = 0;
        }

        public void adicionarCategoria(Categoria novaCategoria)
        {
            novaCategoria.lerCategoria(++totalCategorias);
            categorias.Add(novaCategoria);            
        }

        public void adicionarProduto(Produto novoProduto)
        {
            novoProduto.lerProduto();
            produtos.Add(novoProduto);
        }

        public void listarCategorias()
        {
            foreach (Categoria x in categorias)
            {
                Console.WriteLine($"Descrição: {x.descricao}");
                Console.WriteLine($"Código: {x.codigo}");

            } 
        }

        public void relatorio()
        {
            foreach (Produto x in produtos)
            {
                Console.WriteLine();
                Console.WriteLine($"Nome do produto: {x.nome}");
                Console.WriteLine($"Descriçã de categoria: {verificaCategoria(x.codigoCategoria)}");
                Console.WriteLine($"Preço unitario: {x.preco}");
                Console.WriteLine($"Quantidade em estoque: {x.quantidade}");
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        public string verificaCategoria(int i)
        {
            foreach (Categoria x in categorias)
            {
                if (i == x.codigo)
                {
                    return x.descricao;
                }
            }
            return "";
        }

        public void inventario()
        {
            foreach (Produto x in produtos)
            {
                Console.WriteLine($"{x.nome}: {x.quantidade * x.preco} reais\n");
            }

            Console.ReadKey();
        }
    }
}
