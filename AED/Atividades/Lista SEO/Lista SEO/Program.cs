using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Lista_SEO //Simplesmente encadeada ordenada
{
    internal class Program
    {
        class Elemento
        {
            public int Num;
            public Elemento Prox;

            public Elemento()
            {
                Num = 0;
                Prox = null;
            }
        }

        class Lista
        {
            Elemento Inicio;
            Elemento Fim;
            Elemento Aux;
            Elemento Anterior;

            public int Tamanho;

            public Lista()
            {
                Inicio = null;
                Fim = null;

                Tamanho = 0;
            }

            public void Inserir(int Valor)
            {
                Elemento Novo = new Elemento();

                Novo.Num = Valor;

                if(Inicio == null)
                {
                    Inicio = Novo;
                    Fim = Novo;
                }

                else
                {
                    Anterior = null;
                    Aux = Inicio;

                    while (Aux!= null && Novo.Num > Aux.Num)
                    {
                        Anterior = Aux;
                        Aux = Aux.Prox;                        
                    }

                    if (Anterior == null) //Menor número
                    {
                        Novo.Prox = Inicio;
                        Inicio = Novo;
                    }
                    else if (Aux == null) //Maior número
                    {
                        Fim.Prox = Novo;
                        Fim = Novo;
                    }
                    else //
                    {
                        Anterior.Prox = Novo;
                        Novo.Prox = Aux;
                    }
                }
                Tamanho++;
            }

            public void Mostra()
            {
                Console.Clear();

                if (Inicio == null)
                {
                    Console.WriteLine("A lista não possui elementos...\n\n");                    
                }
                else
                {
                    Console.WriteLine($"A lista possui {Tamanho} elementos...\n\n");

                    Aux = Inicio;

                    while (Aux != null) //for(Aux = Inicio; Aux != null; Aux = Aux.Prox);
                    {
                        Console.Write($"{Aux.Num,6}");  
                        Aux = Aux.Prox;
                    }                    
                }
                Console.ReadKey();
            }
        }
        static void Main(string[] args)
        {
            Lista MinhaLista = new Lista();

            MinhaLista.Inserir(7);
            MinhaLista.Inserir(8);
            MinhaLista.Inserir(2);
            MinhaLista.Inserir(9);
            MinhaLista.Inserir(6);

            MinhaLista.Mostra();
        }
    }
}
