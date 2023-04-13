using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Collections;

namespace Model_View_Controller__MVC_
{
    internal class Menu
    {
        private Operacoes MinhaOperacao;
        private Dados MeusDados;

        public Menu(Operacoes O, Dados D)
        {
            MinhaOperacao = O;
            MeusDados = D;
        }
        public void MostraMenu()
        {            

            int opcao;

            string codPesq = "";

            do
            {
                Console.Clear();


                Console.WriteLine("1- Inserir");
                Console.WriteLine("2- Alterar");
                Console.WriteLine("3- Excluir");
                Console.WriteLine("4- Pesquisar");
                Console.WriteLine("5- Listar");
                Console.WriteLine("6- Ordenar");
                Console.WriteLine("7- Salvar Dados em Arquivo XML");
                Console.WriteLine("8- Ler dados de Arquivo XML");
                Console.WriteLine("9- Sair");

                Console.Write("\nOpção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        //Incluir

                        do
                        {
                            Console.Clear();

                            Console.WriteLine("Cadastramento de Aluno\n");


                            MinhaOperacao.Inserir(new Aluno(), MeusDados);

                            Console.WriteLine("\nInserir outro registro? (ESC Cancela...)");

                        } while (Console.ReadKey().Key != ConsoleKey.Escape); //Continua enquanto não apertar ESC

                        break;
                    case 2:
                        //Alterar
                        //
                        Console.Clear();

                        Console.WriteLine("Alteração de Dados de Aluno\n");

                        Console.Write("Codigo do Aluno:");
                        codPesq = Console.ReadLine();

                        MinhaOperacao.Alterar(codPesq, new Aluno(), new Aluno(), MeusDados);

                        break;
               
                    case 3:
                        //Excluir

                        Console.Clear();

                        Console.WriteLine("Exclusão de Aluno do Cadastro\n");

                        Console.Write("Codigo do Aluno:");
                        codPesq = Console.ReadLine();

                        MinhaOperacao.Excluir(codPesq, new Aluno(), MeusDados);

                        break;                
                    case 4:
                        //Pesquisar
                        Console.Clear();

                        Console.WriteLine("Pesquisa no Cadastro de Alunos\n");

                        Console.Write("Codigo do Aluno:");
                        codPesq = Console.ReadLine();

                        MinhaOperacao.Pesquisar(codPesq, new Aluno(), MeusDados);

                        break;               
                    case 5:
                        //Listar

                        Console.Clear();

                        Console.WriteLine("Listagem Geral do Cadastro de Alunos\n");

                        MinhaOperacao.Listar(MeusDados);

                        break;            
                    case 6:
                        //Ordenar

                        Console.Clear();

                        Console.WriteLine("Ordenação de Dados do Cadastro\n");

                        MinhaOperacao.Ordenar(MeusDados);

                        break;               
                    case 7:
                        //Salvar em Arquivo XML

                        Console.Clear();

                        Console.WriteLine("Salvar Cadastro em Arquivo XML\n");

                        MinhaOperacao.SalvarXML(MeusDados);

                        break;                
                    case 8:
                        //Ler Arquivo XML

                        Console.Clear();

                        Console.WriteLine("Ler dados de Arquivo XML\n");

                        MinhaOperacao.LerXML(MeusDados);

                        break;                
                    case 9:
                        //Sair

                        Console.WriteLine("\nSaída do Sistema...");
                        Thread.Sleep(5000);

                        break;
                    default:
                        Console.WriteLine("Opção invalida");
                        Thread.Sleep(2000);

                        break;
                }
            }while (opcao != 9);
        }
    }
}
