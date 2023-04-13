using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilhas_Listas
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

    class Pilha
    {
        Elemento Topo;
        Elemento Aux;

        public Pilha()
        {
            Topo = null;
        }

        public void Inserir(int Valor)
        {
            Elemento Novo = new Elemento();

            Novo.Num = Valor;

            Novo.Prox = Topo;
            Topo = Novo;
        }

        public void Mostrar()
        {
            Console.Clear();

            Console.WriteLine("Topo");

            Aux = Topo;

            while (Aux != null)
            {
                Console.WriteLine($"{Aux.Num,6}");

                Aux = Aux.Prox;
            }

            Console.ReadKey();
        }

        public void RetiraElemento()
        {
            //Console.Clear();

            //Console.WriteLine($"{Topo.Num} foi retirado da pilha");

            Topo = Topo.Prox;

            //Console.ReadKey();
        }
        
        public int RecebeTopo()
        {
            return Topo.Num;
        }
    }

    class Fila
    {
        private Elemento Inicio;
        private Elemento Fim;
        private Elemento Aux;

        public Fila()
        {
            Inicio = null;
            Fim = null;
        }

        public void Inserir(int Valor)
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
                Fim.Prox = Novo;
                Fim = Novo;
            }
        }

        public void MostrarFila()
        {
            //Console.Clear();

            Aux = Inicio;

            while (Aux != null)
            {
                Console.Write($"{Aux.Num,6}");

                Aux = Aux.Prox;
            }

            Console.ReadKey();
        }

        public void RetiraElemento()
        {
            Console.Clear();
            Console.WriteLine($"O elemento {Inicio.Num} saiu da fila...");

            Inicio = Inicio.Prox;
            
            Console.ReadKey();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Fila MinhaFIla = new Fila();
            Pilha MinhaPilha = new Pilha();
            #region Programa
            //Console.WriteLine("Fila");



            //MinhaFIla.Inserir(1);
            //MinhaFIla.Inserir(2);
            //MinhaFIla.Inserir(3);
            //MinhaFIla.Inserir(4);

            //MinhaFIla.MostrarFila();
            //MinhaFIla.RetiraElemento();
            //MinhaFIla.MostrarFila();
            //MinhaFIla.RetiraElemento();
            //MinhaFIla.MostrarFila();
            //MinhaFIla.RetiraElemento();
            //MinhaFIla.MostrarFila();
            //MinhaFIla.RetiraElemento();
            //MinhaFIla.MostrarFila();

            //Console.Clear();

            //Console.WriteLine("Pilha");


            //MinhaPilha.Inserir(1);
            //MinhaPilha.Inserir(2);
            //MinhaPilha.Inserir(3);
            //MinhaPilha.Inserir(4);
            //MinhaPilha.Inserir(5);
            //MinhaPilha.Inserir(6);

            //MinhaPilha.Mostrar();

            //MinhaPilha.RetiraElemento();

            //MinhaPilha.Mostrar();

            //MinhaPilha.RetiraElemento();

            //MinhaPilha.Mostrar();

            //MinhaPilha.RetiraElemento();

            //MinhaPilha.Mostrar();

            //MinhaPilha.RetiraElemento();

            //MinhaPilha.Mostrar();

            //MinhaPilha.RetiraElemento();

            //MinhaPilha.Mostrar();

            //MinhaPilha.RetiraElemento();
            #endregion

            Random r = new Random();

            for (int i = 1; i < 9; i++)
            {                
                MinhaPilha.Inserir(r.Next(1,51));
            }
            Console.WriteLine("Pilha");
            MinhaPilha.Mostrar();

            for (int i = 1; i < 9; i++)
            {
                MinhaFIla.Inserir(MinhaPilha.RecebeTopo());
                MinhaPilha.RetiraElemento();
            }

            Console.WriteLine("Fila");
            MinhaFIla.MostrarFila();
        }
    }
}
