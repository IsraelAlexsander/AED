using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heap_Sort
{
    class Program
    {
        // Projeto de Exemplo - HEAP SORT
        // ==============================
        //
        // Ordena um vetor de 10 posições com números inteiros fornecidos pelo usuário,
        // e gera um outro vetor ordenado pelo método HEAP SORT.

        static int[] X = new int[11];          // Declaração dos Vetores - Variável de Escopo Global
        
        static void Main(string[] args)
        {
            int i, Qtde;                // Variáveis Auxiliares

            Console.WriteLine("Ordenação em Memória Primária - HEAP SORT");
            Console.WriteLine("=========================================\n");

            for (i = 1; i <= 10; i++)    // Entrada dos Elementos do Vetor
            {
                Console.Write("Digite o Elemento {0,2} do Vetor: ", i);
                X[i] = int.Parse(Console.ReadLine());
            }

            // Transforma o Vetor em um Heap - Cada nó pai é maior que seus filhos
            Qtde = 10;

            TransformaHeap(Qtde);
            
            Ordena(Qtde);

            // Mostrando o Vetor Ordenado
            Console.Write("\nVetor Ordenado (HEAP SORT): ");
            for (i = 1; i <= 10; i++)
            {
                Console.Write("{0,3}", X[i]);
            }

            Console.ReadKey();
        }

        static void TransformaHeap(int Qtde)
        {
            int i;

            for (i = Qtde / 2; i >= 1; i--)
            {
                HeapFica(i, Qtde);
            }
        }

        static void HeapFica(int i, int Qtde)
        {
            int FilhoEsq, FilhoDir, Maior, Aux;

            Maior = i;

            if (2 * i + 1 <= Qtde)
            {
                // O nó tem filhos para a esquerda e para a direita
                FilhoEsq = 2 * i + 1;
                FilhoDir = 2 * i;

                if (X[FilhoEsq] >= X[FilhoDir] && X[FilhoEsq] > X[i])
                    Maior = 2 * i + 1;
                else if (X[FilhoDir] > X[FilhoEsq] && X[FilhoDir] > X[i])
                    Maior = 2 * i;
            }
            else if(2*i<=Qtde)
            {
                // O nó tem filhos só para a direita
                FilhoDir = 2 * i;
                if (X[FilhoDir] > X[i])
                    Maior = 2 * i;
            }

            if (Maior != i)
            {
                Aux = X[i];
                X[i] = X[Maior];
                X[Maior] = Aux;

                HeapFica(Maior, Qtde);
            }
        }

        static void Ordena(int Qtde)
        {
            int i, Aux, ÚltimaPos;

            for(i=Qtde; i>=2;i--)
            {
                Aux=X[1];
                X[1]=X[i];
                X[i]=Aux;

                ÚltimaPos=i-1;

                HeapFica(1,ÚltimaPos);
            }
        }
    }

    // Exercício de Laboratório
    // ========================
    //
    // 1 - Implementar um dos algoritmos mostrados e testar sua execução, inclusive em nível de Debug.
    //
    // 2 - Alterar o programa para que ele alimente um vetor com 100.000 números inteiros
    //     já ordenados em ordem crescente(usar a variável do for para fazer isso) e medir 
    //     o tempo gasto para a ordenação como mostrado abaixo:
    //
    //     using System.Diganostics;
    //
    //     Colocar no Início do Processo...: Stopwatch sw = new Stopwatch();
    //                                       sw.Start();
    //
    //     Colocar no Final do Processo....: sw.Stop();
    //                                       TimeSpan TS=sw.Elapsed;
    //
    //     Mostrar a Diferença de Tempo....: Console.WriteLine("Tempo: {0}", TS.TotalMilliseconds.ToString());
    //
    // 3 - Alterar novamente o programa para que ele alimente um vetor com 100.000 números inteiros
    //     já ordenados em ordem decrescente(usar a variável do for para fazer isso) e medir novamente
    //     o tempo gasto para a ordenação.
    //
    // 4 - Alterar o programa para que ele alimente um vetor com 100.000 números inteiros aleatórios
    //     sorteados utilizando a classe Random como mostrado abaixo: 
    //
    //     Random x = new Random();
    //     X[i] = x.Next(100000);
    //
    //     Medir novamente o tempo gasto para a ordenação.
}
