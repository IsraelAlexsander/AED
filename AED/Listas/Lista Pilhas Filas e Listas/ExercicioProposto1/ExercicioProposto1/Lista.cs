using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioProposto1
{
    internal class Lista
    {
        Elemento Inicio;
        Elemento Fim;
        Elemento Aux;
        Elemento Anterior;

        public Lista()
        {
            Inicio = null;
            Fim = null;
        }

        public void inserirInicio()
        {
            Elemento Novo = new Elemento();
            Novo.professor.lerDados();            

            if (Inicio == null)
            {
                Inicio = Novo;
                Fim = Novo;
            }
            else
            {
                Novo.Proximo = Inicio;
                Inicio = Novo;
            }
            Console.WriteLine("\nProfessor cadastrado\n");
            Console.ReadKey();
        }

        public void inserirFinal()
        {
            Elemento Novo = new Elemento();
            Novo.professor.lerDados();

            if (Inicio == null)
            {
                Inicio = Novo;
                Fim = Novo;
            }
            else
            {
                Fim.Proximo = Novo;
                Fim = Novo;                
            }
            Console.WriteLine("\nProfessor cadastrado\n");
            Console.ReadKey();
        }

        public void listar()
        {
            Aux = Inicio;

            if (Aux == null)
                Console.WriteLine("Lista vazia");
            else
            {
                while (Aux != null)
                {
                    Console.WriteLine($"Nome: {Aux.professor.nome}");
                    Console.WriteLine($"Telefone: {Aux.professor.telefone}");
                    Console.WriteLine($"E-mail: {Aux.professor.mail}\n");
                    Aux = Aux.Proximo;
                }
            }
            Console.ReadKey();            
        }

        public void remover(string nome)
        {
            Aux = Inicio;
            Anterior = null;            

            if (Inicio == null)
            {
                Console.WriteLine("\nLista vazia\n");                                
            }
            else
            {
                while (Aux != null && Aux.professor.nome != nome)
                {
                    Anterior = Inicio;
                    Aux = Aux.Proximo;                    
                }
                

                if (Aux != null)
                {
                    if (Aux == Inicio)
                    {
                        Inicio = Inicio.Proximo;                        
                    }
                    else
                    {
                        Anterior.Proximo = Aux.Proximo;
                    }
                    Console.WriteLine("\nProfessor removido.\n");
                }
                else
                {
                    Console.WriteLine("Professor não encontrado.");
                }
            }            
            Console.ReadKey();
        }

        public void esvaziar()
        {
            Inicio = null;
            Fim = null;
            Console.WriteLine("Lista esvaziada");
            Console.ReadKey();
        }

        public void procurar(string nome)
        {
            Aux = Inicio;
            Anterior = null;

            while (Aux != null && Aux.professor.nome != nome)
            {
                Anterior = Inicio;
                Aux = Aux.Proximo;
            }

            if (Aux != null)
            {
                Console.WriteLine($"\nNome: {Aux.professor.nome}");
                Console.WriteLine($"Telefone: {Aux.professor.telefone}");
                Console.WriteLine($"E-mail: {Aux.professor.mail}\n");
            }
            else
            {
                Console.WriteLine("\nProfessor não encontrado");
            }
            Console.ReadKey();
        }
    }
}
