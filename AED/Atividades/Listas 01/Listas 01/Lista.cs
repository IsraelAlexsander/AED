using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_01
{
    public class Elemento
    {
        public int num;
        public Elemento prox;

        public Elemento()
        {
            num = 0;
            prox = null;
        }
    }

    internal class Lista
    {
        private Elemento Inicio;
        private Elemento Fim;
        private Elemento Anterior;
        private Elemento Aux;

        public int Tamanho;

        public Lista()
        {
            Inicio = null;
            Fim = null;

            Tamanho = 0;
        }

        public void inserirInicio(int Valor)
        {
            Elemento novo = new Elemento();

            novo.num = Valor;

            if (Inicio == null)
            {
                Inicio = novo;
                Fim = novo;
            }
            else
            {
                novo.prox = Inicio;
                Inicio = novo;
            }

            Tamanho++;
        }

        public void inserirFinal(int Valor)
        {
            Elemento novo = new Elemento();

            novo.num = Valor;

            if (Inicio == null)
            {
                Inicio = novo;
                Fim = novo;
            }
            else
            {
                Fim.prox = novo;
                Fim = novo;
            }

            Tamanho++;
        }

        public void mostraLista()
        {
            Console.Clear();

            Console.WriteLine($"Elementos na lista: {Tamanho}");

            Aux = Inicio;

            while (Aux != null)
            {
                Console.Write($"{Aux.num,6}");

                Aux = Aux.prox;
            }

            Console.ReadKey();
        }

        public void retiraElemento(int Valor)
        {
            Console.Clear();

            Aux = Inicio;

            Anterior = null;

            while (Aux != null)
            {
                if (Aux.num == Valor)
                {
                    if (Aux == Inicio)
                    {
                        Inicio = Aux.prox;

                        Aux = Inicio;

                        Tamanho--;
                    }
                    else if (Aux == Fim)
                    {
                        Anterior.prox = null;

                        Fim = Anterior;

                        Aux = null;

                        Tamanho--;
                    }
                    else
                    {
                        Anterior.prox = Aux.prox;

                        Aux = Aux.prox;

                        Tamanho--;
                    }
                }
                else
                {
                    Anterior = Aux;

                    Aux = Aux.prox;
                }
            }


        }

        public void esvaziarLista()
        {
            Inicio = null;

            Tamanho = 0;
        }

        public int encontrarPosicao(int Valor)
        {
            Console.Clear();

            Aux = Inicio;
            Anterior = null;

            int pos = 0;

            while (Aux != null)
            {
                if (Aux.num == Valor)
                {
                    return ++pos;
                }
                else
                {                    
                    Aux = Aux.prox;

                    pos++;
                }
            }
            return pos = 0 ;
        }
    }
}
