using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
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

    class Lista
    {
        private Elemento Inicio;
        private Elemento Fim;
        private Elemento Aux;
        public int Tamanho;

        public Lista()
        {
            Inicio = null;
            Fim = null;            
        }

        public void inserirInicio(char L)
        {
            Elemento Novo = new Elemento();

            Novo.Letra = L;

            if (Inicio == null)
            {
                Inicio = Novo;
                Fim = Novo;
            }
            else
            {
                Novo.Proximo = Inicio;
                Inicio = Novo;
            }
        }

        public void inserirFinal(char L)
        {
            Elemento Novo = new Elemento();

            Novo.Letra = L;

            if (Inicio == null)
            {
                Inicio = Novo;
                Fim = Novo;
            }
            else
            {
                Fim.Proximo = Novo;
                Fim = Novo;
            }
        }

        public void exibirLista()
        {
            Console.Clear();

            Console.WriteLine("Resultado da lista");

            Aux = Inicio;

            while (Aux != null)
            {
                Console.Write($"{Aux.Letra,6}");

                Aux = Aux.Proximo;
            }

            Console.ReadKey();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Lista minhaLista = new Lista();

            Console.Write("Digite a palavra a adicionar na lista: ");
            string palavra = Console.ReadLine();

            int opcao;

            for (int i = 0; i < palavra.Length; i++)
            {
                Console.Clear();
                Console.WriteLine($"Palavra: {palavra}");
                Console.WriteLine($"Inserir a letra {palavra[i]}:\tInicio - 1\tFinal - 2");
                opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                    minhaLista.inserirInicio(palavra[i]);
                else if (opcao == 2)
                    minhaLista.inserirFinal(palavra[i]);                         
            }

            Console.Clear();            
            minhaLista.exibirLista();
        }
    }
}
