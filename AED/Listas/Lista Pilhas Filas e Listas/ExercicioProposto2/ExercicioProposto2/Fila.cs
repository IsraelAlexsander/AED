using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExercicioProposto2
{
    internal class Fila
    {
        private Elemento Inicio;
        private Elemento Fim;
        int Senha;
        int fila;

        public Fila()
        {
            Inicio = null;
            Fim = null;
            Senha = 0;
            fila = 0;
        }

        public void entrarNaFila()
        {
            Elemento Novo = new Elemento();
            Novo.senha = ++Senha;

            if (Inicio == null)
            {
                Inicio = Novo;
                Fim = Novo;
                Fim.Proximo = null;
            }
            else
            {
                Fim.Proximo = Novo;
                Fim = Novo;
                Fim.Proximo = null;
            }

            fila++;
            Console.WriteLine($"\nSenha {Senha} entrou na fila");
            Thread.Sleep(2000);
            Console.Clear();
        }

        public void sairDaFila()
        {
            if (Inicio != null)
            {
                Console.WriteLine($"\nSenha {Inicio.senha} saiu da fila");
                Inicio = Inicio.Proximo;
                
            }
            else
                Console.WriteLine("\nFila vazia");

            fila--;
            Thread.Sleep(2000);
            Console.Clear();
        }

        public void senhaAtual()
        {
            if (Inicio == null)
            {
                Console.WriteLine("Ninguém");
            }
            else
            {
                Console.WriteLine($"Senha {Inicio.senha}");
            }
        }

        public void filaAtual()
        {
            if (fila >= 1)
                Console.WriteLine($"{fila - 1} pessoas");
            else
                Console.WriteLine($"0 pessoas");
        }
    }
}
