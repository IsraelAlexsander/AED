using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
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
        private Elemento Inicio;
        private Elemento Fim;
        private Elemento Aux;
        private Elemento Anterior;

        public int Tamanho;

        public Lista()
        {
            Inicio = null;
            Fim = null;

            Tamanho = 0;
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
                Aux = Inicio;
                Anterior = null;

                while (Aux != null && Novo.Num > Aux.Num)
                {
                    Anterior = Aux;             
                    Aux = Aux.Proximo;             
                }

                if (Anterior == null)           
                {
                    Novo.Proximo = Inicio;         
                    Inicio = Novo;              
                }
                else if (Aux == null)           
                {
                    Fim.Proximo = Novo;            
                    Fim = Novo;                 
                    Fim.Proximo = null;            
                }
                else                            
                {
                    Anterior.Proximo = Novo;       
                    Novo.Proximo = Aux;            
                }            
            }
            
        }
        
        public void exibir()
        {
            Aux = Inicio;

            while (Aux != null)
            {
                Console.Write($"{Aux.Num,6}");        
                Aux = Aux.Proximo;                            
            }
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
            

            Console.WriteLine("Lista");
            minhaLista.exibir();

            Console.ReadKey();
        }
    }
}
