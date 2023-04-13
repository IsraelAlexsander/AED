using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08
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

    class Pilha
    {
        private Elemento Topo;
        private Elemento Aux;

        public Pilha()
        {
            Topo = null;            
        }

        public void inserir(int Valor)
        {
            Elemento Novo = new Elemento();
            Novo.Num = Valor;

            if (Topo == null)
            {
                Topo = Novo;                
            }
            else
            {
                Novo.Proximo = Topo;
                Topo = Novo;
            }
        }

        public void exibir()
        {
            Aux = Topo;

            while(Aux!= null)
            {
                Console.Write(Aux.Num);
                Aux = Aux.Proximo;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Pilha minhaPilha = new Pilha();

            Console.Write("Digite um número na base 10: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write($"{n} na base 2 é: ");
            
            if (n == 0)
                Console.Write(0);
            else
            {
                while (n >= 1)
                {
                    minhaPilha.inserir(n % 2);
                    n = n / 2;
                }
            }

            minhaPilha.exibir();
            Console.ReadKey();
        }
    }
}
