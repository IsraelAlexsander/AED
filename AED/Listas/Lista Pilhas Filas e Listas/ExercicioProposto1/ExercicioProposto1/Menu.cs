using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExercicioProposto1
{
    internal class Menu
    {
        Lista minhaLista = new Lista();

        public void exibir()
        {
            int opc;
            do
            {
                Console.WriteLine("Inserir novo professor no Inicio - 1");
                Console.WriteLine("Inserir novo professor no Fim - 2");
                Console.WriteLine("Listar professores - 3");
                Console.WriteLine("Remover professor - 4");
                Console.WriteLine("Esvaziar lista - 5");
                Console.WriteLine("Procurar professor - 6");
                Console.WriteLine("Sair = 7");

                Console.Write("Opção: ");
                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        Console.Clear();

                        Console.WriteLine("Cadastro de professor\n");
                        minhaLista.inserirInicio();     
                        
                        Console.Clear();

                        break;

                    case 2:
                        Console.Clear();

                        Console.WriteLine("Cadastro de professor\n");
                        minhaLista.inserirFinal();
                        
                        Console.Clear();

                        break;

                    case 3:
                        Console.Clear();

                        Console.WriteLine("Lista dos professores\n");
                        minhaLista.listar();

                        Console.Clear();

                        break;

                    case 4:
                        Console.Clear();

                        Console.Write("Remover Professor: ");
                        minhaLista.remover(Console.ReadLine());

                        Console.Clear();

                        break;

                    case 5:
                        Console.Clear();
                        
                        minhaLista.esvaziar();

                        Console.Clear();

                        break;

                    case 6:
                        Console.Clear();

                        Console.Write("Digite o nome do professor: ");
                        minhaLista.procurar(Console.ReadLine());

                        Console.Clear();

                        break;

                    case 7:
                        Console.Clear();

                        Console.WriteLine("Saindo...");
                        Thread.Sleep(2000);

                        break;
                }
            } while (opc != 7);
        }
    }
}
