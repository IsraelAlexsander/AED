using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07
{
    class Elemento
    {
        public int Num;
        public Elemento Proximo;

        public Elemento()
        {
            Num = 0;
            Proximo = null;
        }
    }

    class Fila
    {
        Elemento Inicio;
        Elemento Fim;
        Elemento Aux;

        public Fila()
        {
            Inicio = null;
            Fim = null;
        }

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
                Fim = Novo;
                Fim.Proximo = null;
            }
        }

        public int inserirNaFila() //Insere elemento na fila resultante
        {
            Aux = Inicio;
            Inicio = Inicio.Proximo;
            return Aux.Num;
        }

        public void exibir()
        {
            Aux = Inicio;

            if (Aux == null)
                Console.WriteLine("Fila vazia");
            else            
                while (Aux != null)
                {
                    Console.Write($"{Aux.Num,4}");
                    Aux = Aux.Proximo;
                }            
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Fila Fila1 = new Fila();
            Fila Fila2 = new Fila();
            Fila FilaR = new Fila();

            Random r = new Random();

            for (int i = 0; i < 10; i++)
            {
                Fila1.inserir(r.Next(1, 51));
                Fila2.inserir(r.Next(1, 51));
            }

            Console.Write("Fila 1: ");
            Fila1.exibir();
            Console.Write("\n\nFila 2: ");
            Fila2.exibir();
            Console.ReadKey();

            for (int i = 0; i < 10; i++)
            {
                FilaR.inserir(Fila1.inserirNaFila());
                FilaR.inserir(Fila2.inserirNaFila());
            }

            Console.Write("\n\nFila resultante: ");
            FilaR.exibir();
            Console.ReadKey();
        }        
    }
}
