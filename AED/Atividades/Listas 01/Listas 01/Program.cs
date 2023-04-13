using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Op;
            Lista minhaLista = new Lista();

            do
            {
                Console.Clear();

                Console.Title = "Lista Simplesmente Encadeada e Não ordenada\n";

                Console.WriteLine("Opções: \n");

                Console.WriteLine("1- Inserir no Início");
                Console.WriteLine("2- Inserir no Final");
                Console.WriteLine("3- Mostrar os Elementos da Lista");
                Console.WriteLine("4- Remover um Elemento da Lista");
                Console.WriteLine("5- Esvaziar a Lista");
                Console.WriteLine("6- Encontrar Posição de Elemento");

                Console.WriteLine("\n7- Sair\n");

                Console.Write("Digite sua opção: ");
                Op = int.Parse(Console.ReadLine());

                if (Op == 1)
                {
                    Console.Clear();

                    int x;

                    Console.Write("Digite um número: ");
                    x = int.Parse(Console.ReadLine());

                    minhaLista.inserirInicio(x);

                    Console.WriteLine($"\nElemento {x} inserido na lista... Tamanho: {minhaLista.Tamanho}");

                    Console.ReadKey();
                }

                if (Op == 2)
                {
                    Console.Clear();

                    int x;

                    Console.Write("Digite um número: ");
                    x = int.Parse(Console.ReadLine());

                    minhaLista.inserirFinal(x);

                    Console.WriteLine($"Elemento inserido na lista... Tamanho: {minhaLista.Tamanho}");
                    Console.ReadKey();
                }

                if (Op == 3)
                {
                    minhaLista.mostraLista();
                }

                if (Op == 4)
                {
                    Console.Clear();

                    int x;

                    Console.Write("Digite um número: ");
                    x = int.Parse(Console.ReadLine());

                    minhaLista.retiraElemento(x);

                    Console.WriteLine($"\nElemento retirado da lista... Tamanho: {minhaLista.Tamanho}");

                    Console.ReadKey();
                }

                if (Op == 5)
                {
                    Console.Clear();     

                    minhaLista.esvaziarLista();

                    Console.WriteLine("Lista esvaziada...");

                    Console.ReadKey();
                }

                if (Op == 6)
                {
                    Console.Clear();

                    int x;

                    Console.Write("Digite um número: ");
                    x = int.Parse(Console.ReadLine());

                    int posicao = minhaLista.encontrarPosicao(x);
                    
                    if (posicao == 0)
                    {
                        Console.WriteLine("Não existe este valor na lista...");
                    }
                    else
                    {
                        Console.WriteLine($"A posição do valor {x} na lista é: {posicao}");
                    }
                    Console.ReadKey();
                }

            }while(Op != 7);
        }
    }
}
