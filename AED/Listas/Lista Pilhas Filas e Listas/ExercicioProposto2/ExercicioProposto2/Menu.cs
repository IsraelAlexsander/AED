using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExercicioProposto2
{
    internal class Menu
    {
        Fila minhaFila = new Fila();

        public void exibir()
        {
            int opcao;

            do
            {
                Console.Write("Atendimento atual: ");
                minhaFila.senhaAtual();
                Console.Write("Pessoas na fila: ");
                minhaFila.filaAtual();
                Console.WriteLine();
                Console.WriteLine("Retirar senha - 1");
                Console.WriteLine("Atendimento - 2");
                Console.WriteLine("Sair - 3");
                Console.Write("Opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:                        

                        minhaFila.entrarNaFila();

                        break;

                    case 2:                        

                        minhaFila.sairDaFila();

                        break;

                    case 3:

                        Console.WriteLine("\n\nSaindo...");
                        Thread.Sleep(2000);

                        break;

                    default:

                        Console.Clear();
                        Console.WriteLine("Opção invalida...");
                        Thread.Sleep(2000);

                        break;
                }
            }while(opcao != 3);
        }
    }
}
