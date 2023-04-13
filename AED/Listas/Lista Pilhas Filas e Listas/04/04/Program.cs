using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
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

    class Lista
    {
        Elemento Inicio;
        Elemento Fim;
        Elemento Aux;

        public Lista()
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

        public void exibir()
        {
            Aux = Inicio;

            if (Inicio == null)
                Console.WriteLine("Vazia");
            else
            {
                while (Aux != null)
                {
                    Console.Write($"{Aux.Num,04}");
                    Aux = Aux.Proximo;
                }
            }            
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Lista Par = new Lista();
            Lista Impar = new Lista();

            int n;

            Console.WriteLine("Digite um número: ");
            string numero = Console.ReadLine();
            
            for (int i = 0; i < numero.Length; i++)
            {
                n = int.Parse(numero[i].ToString());

                if (n % 2 == 0)
                    Par.inserir(n);
                else
                    Impar.inserir(n);
            }

            Console.WriteLine("Lista par");
            Par.exibir();
            Console.WriteLine("\nLista Impar");
            Impar.exibir();

            Console.ReadKey();

        }
    }
}
