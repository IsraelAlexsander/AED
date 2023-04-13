using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TrabalhoHashTable
{
    internal class Menu
    {
        private Operacoes MinhasOperacoes;
        private Dados MeusDados;

        public Menu(Operacoes O, Dados D)
        {
            MinhasOperacoes = O;
            MeusDados = D;
        }

        public void Mostrar()
        {
            int opcao;            

            string RGPesquisa = "";

            do
            {
                Console.Clear();

                Console.WriteLine("Cadastro de Pacientes de uma Clínica Odontológica\n\n");

                Console.WriteLine("1 - Cadastrar Paciente");
                Console.WriteLine("2 - Listar Pacientes");
                Console.WriteLine("3 - Pesquisar Paciente");
                Console.WriteLine("4 - Excluir Paciente");
                Console.WriteLine("5 - Salvar Dados em Arquivo XML");
                Console.WriteLine("6 - Ler dados de Arquivo XML");
                Console.WriteLine("7 - Sair");

                Console.Write("\nOpção: ");
                opcao = int.Parse(Console.ReadLine());

                Console.Clear();

                switch (opcao)
                {
                    case 1:     
                        // Cadastrar Paciente                        
                        Console.WriteLine("Cadastro de paciente\n");

                        MinhasOperacoes.inserir(new Paciente(), MeusDados);
                        Console.WriteLine("\nPaciente cadastrado");

                        Thread.Sleep(500);

                        break;
                    case 2:    
                        // Listar Pacientes
                        Console.WriteLine("Listagem de pacientes\n");

                        MinhasOperacoes.listar(MeusDados);

                        Console.ReadKey();

                        break;
                    case 3:
                        //Pesquisar Paciente
                        Console.WriteLine("Pesquisar Paciente");

                        Console.Write("Digite o RG do Paciente: ");
                        RGPesquisa = Console.ReadLine();

                        MinhasOperacoes.pesquisar(RGPesquisa, new Paciente(), MeusDados);

                        Console.ReadKey();

                        break;
                    case 4:
                        //Excluir Paciente
                        Console.WriteLine("Excluir Paciente");

                        Console.Write("Digite o RG do Paciente: ");
                        RGPesquisa = Console.ReadLine();
                        MinhasOperacoes.excluir(RGPesquisa, new Paciente(), MeusDados);

                        Console.ReadKey();

                        break;
                    case 5:
                        // Salvar XML
                        Console.WriteLine("Salvar Cadastros em Arquivo XML");

                        MinhasOperacoes.salvarXML(MeusDados);

                        Console.ReadKey();

                        break;
                    case 6:
                        // Ler XML
                        Console.WriteLine("Ler Cadastros em Arquivo XML");

                        MinhasOperacoes.lerXML(MeusDados);

                        Console.ReadKey();

                        break;
                    case 7:
                        //Sair

                        Console.WriteLine("\nSaída do Sistema...");

                        Thread.Sleep(1000);

                        break;
                    default:

                        Console.WriteLine("Opção invalida");
                        Thread.Sleep(1000);

                        break;
                }                
            } while (opcao != 7);
        }
    }
}
