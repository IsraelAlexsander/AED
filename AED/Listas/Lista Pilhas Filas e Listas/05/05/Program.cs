using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    class Elemento
    {
        public int Num;
        public Elemento Proximo;
        public Elemento Anterior;

        public Elemento()
        {
            Num = 0;
            Proximo = null;
            Anterior = null;
        }
    }

    class Lista
    {
        private Elemento Inicio;
        private Elemento Fim;
        private Elemento Aux;

        public void inserir(int Valor)
        {
            Elemento Novo = new Elemento();

            Novo.Num = Valor;

            if (Inicio == null)
            {
                Inicio = Novo;
                Fim = Novo;
            }
            else
            {
                Fim.Proximo = Novo;
                Novo.Anterior = Fim;
                Fim = Novo;
                Fim.Proximo = Inicio;
                Inicio.Anterior = Fim;
            }
        }

        public void exibirDoInicio()
        {
            Aux = Inicio;

            do
            {
                Console.Write($"{Aux.Num,4:00}");
                Aux = Aux.Proximo;

            } while (Aux != Inicio);
        }

        public void exibirDoFinal()
        {
            Aux = Fim;

            do
            {
                Console.Write($"{Aux.Num,4:00}");
                Aux = Aux.Anterior;
            } while (Aux != Fim);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Lista minhaLista = new Lista();

            Random r = new Random();

            for (int i = 0; i < 10; i++)
            {
                minhaLista.inserir(r.Next(1, 51));
            }

            Console.Write("Exibir do Incio: ");
            minhaLista.exibirDoInicio();
            Console.Write("\n\nExibir do Final: ");
            minhaLista.exibirDoFinal();

            Console.ReadKey();

        }
    }
}
