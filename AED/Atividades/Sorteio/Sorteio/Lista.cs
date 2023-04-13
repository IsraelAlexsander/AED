using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorteio
{
    internal class Lista
    {
        Aluno Inicio;
        Aluno Fim;
        Aluno Aux;
        Aluno Anterior;

        public int Tamanho;

        public Lista()
        {
            Inicio = null;
            Fim = null;

            Tamanho = 0;
        }

        public void Inserir(string Nome)
        {            
            Aluno Aluno = new Aluno();
            Aluno.Nome = Nome;

            if (Inicio == null)
            {
                Inicio = Aluno;
                Fim = Aluno;
            }
            else
            {                
                Fim.Proximo = Aluno;
                Fim = Aluno;
            }
            Tamanho++;            
        }

        public void Mostra()
        {
            Console.Clear();

            if (Inicio == null)
            {
                Console.WriteLine("A lista não possui elementos...\n\n");
            }
            else
            {
                Console.WriteLine($"A lista possui {Tamanho} elementos...\n\n");

                Aux = Inicio;

                while (Aux != null) //for(Aux = Inicio; Aux != null; Aux = Aux.Prox);
                {
                    Console.WriteLine($"Nome: {Aux.Nome}");
                    Aux = Aux.Proximo;
                }
            }
        }

        public void Sortear()
        {
            Random rand = new Random();

            int nSorteado = rand.Next(1, Tamanho + 1);

            int i = 1;

            Aux = Inicio;
            Anterior = null;

            while (i != nSorteado)
            {
                Anterior = Aux;
                Aux = Aux.Proximo;
                i++;
            }S

            Console.WriteLine($"O aluno sorteado foi: {Aux.Nome}");

            Anterior.Proximo = Aux.Proximo;

        }
    }
}
