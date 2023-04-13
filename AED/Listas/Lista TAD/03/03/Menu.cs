using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _03
{
    internal class Menu
    {
        private Dados meusDados;
        private Operacoes minhaOperacao;

        public Menu(Dados D, Operacoes O)
        {
            meusDados = D;
            minhaOperacao = O;
        }

        public void mostraMenu()
        {
            int opc;

            do
            {
                Console.Clear();

                Console.WriteLine("Inserir - 1");
                Console.WriteLine("Listar - 2");
                Console.WriteLine("Sair - 3");

                Console.Write("Opção: ");
                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:

                        Console.Clear();
                        Console.WriteLine("Cadastro de aluno");

                        minhaOperacao.Inserir(new Aluno(), meusDados);

                        break;

                    case 2:

                        Console.Clear();
                        Console.WriteLine("Listagem dos alunos");

                        minhaOperacao.Listar(meusDados);

                        break;

                    case 3:
                        Console.WriteLine("\nSaída do Sistema...");
                        Thread.Sleep(5000);

                        break;

                    default:
                        Console.WriteLine("Opção invalida");
                        Thread.Sleep(2000);

                        break;
                }
            } while (opc != 3);
        }
    }
}
