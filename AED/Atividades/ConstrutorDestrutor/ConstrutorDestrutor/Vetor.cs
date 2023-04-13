using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstrutorDestrutor
{
    internal class Vetor
    {
        private int[] V;

        public Vetor()
        {
            V = new int[10]; 
        }

        public Vetor(int tamanho)
        {
            V = new int[tamanho];
        }

        public Vetor(int Tam, int LI, int LS)
        {
            Random r = new Random();

            V = new int[Tam];

            for (int i = 0; i < Tam; i++)
                V[i] = r.Next(LI, LS + 1);
        }

        public void Mostra()
        {
            foreach (int x in V)
                Console.Write($"{x,7}");
        }

        public void Coloca(int Valor, int Pos)
        {
            V[Pos] = Valor;
        }

        public int Consulta(int Pos)
        {
            return V[Pos];
        }

        public int Soma()
        {
            int soma = 0;

            foreach (int x in V)
                soma += x;

            return soma;
        }
    }
}
