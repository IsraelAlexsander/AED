using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_DENO //Duplamente Encadeada Não Ordenada
{
    class Elemento
    {
        public int Núm;
        public Elemento Próx;
        public Elemento Ant;

        public Elemento()
        {
            Núm = 0;
            Próx = null;
            Ant = null;
        }
    }
    class Lista
    {
        private Elemento Início;
        private Elemento Fim;
        private Elemento Aux;

        public int Tamanho;

        public Lista()
        {
            Início = null;
            Fim = null;

            Tamanho = 0;
        }

        public void InserirInício(int Valor)
        {
            Elemento Novo = new Elemento();

            Novo.Núm = Valor;

            if (Início == null)
            {
                Início = Novo;
                Fim = Novo;
            }
            else
            {
                Novo.Próx = Início;
                Início.Ant = Novo;
                Início = Novo;
            }

            Tamanho++;
        }

        public void InserirFinal(int Valor)
        {
            Elemento Novo = new Elemento();

            Novo.Núm = Valor;

            if (Início == null)
            {
                Início = Novo;
                Fim = Novo;
            }
            else
            {
                Fim.Próx = Novo;
                Novo.Ant = Fim;
                Fim = Novo;
            }

            Tamanho++;
        }

        public void MostraListaINIFIM()
        {
            Console.Clear();

            Console.WriteLine($"Total de Elementos: {Tamanho}\n\n");

            Aux = Início;

            while (Aux != null)
            {
                Console.Write($"{Aux.Núm,6}");

                Aux = Aux.Próx;
            }

            Console.ReadKey();
        }

        public void MostraListaFIMINI()
        {
            Console.Clear();

            Console.WriteLine($"Total de Elementos: {Tamanho}\n\n");

            Aux = Fim;

            while (Aux != null)
            {
                Console.Write($"{Aux.Núm,6}");

                Aux = Aux.Ant;
            }

            Console.ReadKey();
        }

        public void RetiraElemento(int Valor)
        {
            Aux = Início;

            while (Aux != null)
            {
                if (Aux.Núm == Valor)
                {
                    if (Aux == Início)
                    {
                        Início = Aux.Próx;
                        Início.Ant = null;

                        Aux = Aux.Próx;

                        Tamanho--;
                    }
                    else if (Aux == Fim)
                    {
                        Fim = Fim.Ant;
                        Fim.Próx = null;

                        Aux = Aux.Próx;

                        Tamanho--;
                    }
                    else
                    {
                        Aux.Ant.Próx = Aux.Próx;
                        Aux.Próx.Ant = Aux.Ant;

                        Aux = Aux.Próx;

                        Tamanho--;
                    }
                }
                else
                {
                    Aux = Aux.Próx;
                }
            }
        }

    }    

    class Program
    {
        static void Main(string[] args)
        {
            Lista MinhaLista = new Lista();

            MinhaLista.InserirInício(50);
            MinhaLista.InserirInício(45);
            MinhaLista.InserirInício(67);
            MinhaLista.InserirInício(32);

            MinhaLista.InserirFinal(34);
            MinhaLista.InserirFinal(52);
            MinhaLista.InserirFinal(27);

            MinhaLista.MostraListaINIFIM();

            MinhaLista.MostraListaFIMINI();

            MinhaLista.RetiraElemento(50);
            MinhaLista.RetiraElemento(27);
            MinhaLista.RetiraElemento(32);

            MinhaLista.MostraListaINIFIM();            

        }
    }
}
