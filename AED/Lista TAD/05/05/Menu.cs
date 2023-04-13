using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _05
{
    internal class Menu
    {
        public Menu()
        {
            Dados meusDados = new Dados();
        }        

        public void exibir(Dados meusDados)
        {
            int opc;
            do
            {
                Console.Clear();

                Console.WriteLine("Adicionar Categoria - 1");
                Console.WriteLine("Adicionar Produto - 2");
                Console.WriteLine("Listar Categorias - 3");
                Console.WriteLine("Mostrar Relatorio - 4");
                Console.WriteLine("Mostrar Inventario - 5");
                Console.WriteLine("Sair - 6");

                Console.Write("Opção: ");
                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1: //Adiconar Categoria
                        Console.Clear();

                        Console.WriteLine("Adicionando uma nova categoria\n");
                        meusDados.adicionarCategoria(new Categoria());

                        break;

                    case 2: //Adicionar Produto
                        Console.Clear();
                        Console.WriteLine("Adicionando um novo produto\n");
                        meusDados.adicionarProduto(new Produto());

                        break;

                    case 3: //Listar Categorias
                       Console.Clear();

                        Console.WriteLine("Lista de categorias");
                        meusDados.listarCategorias();
                        Console.ReadKey();

                        break;

                    case 4: //Mostrar Relatorio
                        Console.Clear();

                        Console.WriteLine("Relatorio");

                        meusDados.relatorio();

                        break;

                    case 5: //Mostrar Inventario
                        Console.Clear();

                        Console.WriteLine("Inventario\n");
                        meusDados.inventario();                        

                        break;

                    case 6: //Sair
                        Console.WriteLine("Saindo do programa...");
                        Thread.Sleep(2000);

                        break;

                    default:
                        Console.WriteLine("Opção invalida...");
                        Thread.Sleep(2000);

                        break;
                }
            } while (opc != 6);
        }
    }
}
