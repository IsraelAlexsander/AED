using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversaoBase2Pilha
{
    internal class Program
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

        class PilhaBinaria
        {
            Elemento Topo;
            Elemento Aux;

            public PilhaBinaria()
            {
                Topo = null;
            }

            public void Inserir(int Valor)
            {
                Elemento Novo = new Elemento();

                Novo.Num = Valor;

                Novo.Proximo = Topo;
                Topo = Novo;
            }

            public void Converter(int Valor)
            {
                while(Valor >= 1)
                {
                    int x = Valor % 2;
                    Inserir(x);
                    Valor = Valor / 2;
                }
            }
            public void Esvaziar()
            {
                Topo = null;
            }

            public void Mostrar(int Valor)
            {
                Console.Write($"Conversão de {Valor} para Binário:  ");

                Aux = Topo;

                while (Aux != null)
                {
                    Console.Write($"{Aux.Num}");
                    Aux = Aux.Proximo;
                }

                Esvaziar();
            }
        }
        static void Main(string[] args)
        {
            PilhaBinaria MinhaPilha = new PilhaBinaria();

            Console.Write("Digite o valor que deseja converter: ");
            int x = int.Parse(Console.ReadLine());

            MinhaPilha.Converter(x);
            MinhaPilha.Mostrar(x);
            Console.ReadKey();
            Console.Clear();

            Console.Write("Digite o valor que deseja converter: ");
            x = int.Parse(Console.ReadLine());

            MinhaPilha.Converter(x);
            MinhaPilha.Mostrar(x);
            Console.ReadKey();

        }
    }
}
