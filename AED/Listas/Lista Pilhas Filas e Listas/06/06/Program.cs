using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    internal class Program
    {
        class Elemento
        {
            public char Letra;
            public Elemento Proximo;

            public Elemento()
            {                
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

            public void inserir(char letra)
            {
                Elemento Novo = new Elemento();
                Novo.Letra = letra;

                if (Topo == null)
                {
                    Topo = Novo;
                    Topo.Proximo = null;
                }
                else
                {
                    Novo.Proximo = Topo;
                    Topo = Novo;
                }
            }

            public void apagar()
            {               
                Topo = Topo.Proximo;                               
            }

            public void exibir()
            {
                Console.Clear();
                Console.WriteLine("Pilha");
                Aux = Topo;
                while (Aux != null)
                {
                    Console.WriteLine(Aux.Letra);
                    Aux = Aux.Proximo;
                }
                if (Topo == null)
                {
                    Console.WriteLine("Vazia");
                }
            }
        }
        static void Main(string[] args)
        {
            Pilha minhaPilha = new Pilha();

            Console.Write("Digite uma palavra: ");
            string palavra = Console.ReadLine();

            for (int i = 0; i < palavra.Length; i++)
            {
                minhaPilha.inserir(palavra[i]);
            }

            minhaPilha.exibir();            
            
            for (int i = 0; i < palavra.Length; i++)
            {
                Console.WriteLine("Aperte backspace para apagar...");
                if (Console.ReadKey().Key == ConsoleKey.Backspace)
                {
                    minhaPilha.apagar();
                    minhaPilha.exibir();
                }
            }            
            Console.ReadKey();
        }
    }
}
