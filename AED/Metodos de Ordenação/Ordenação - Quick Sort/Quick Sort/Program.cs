using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quick_Sort
{
    class Program
    {
        // Projeto de Exemplo - QUICK SORT
        // ===============================
        //
        // Ordena um vetor de 10 posições com números inteiros fornecidos pelo usuário,
        // e gera um outro vetor ordenado pelo método QUICK SORT.

        static void Main(string[] args)
        {
            int[] X = new int[10];      // Declaração dos Vetores
            int i;                      // Variáveis Auxiliares

            Console.WriteLine("Ordenação em Memória Primária - QUICK SORT");
            Console.WriteLine("==========================================\n");

            for (i = 0; i < 10; i++)    // Entrada dos Elementos do Vetor
            {
                Console.Write("Digite o Elemento {0,2} do Vetor: ", i + 1);
                X[i] = int.Parse(Console.ReadLine());
            }

            Quick(X, 0, 9);

            // Mostrando o Vetor Ordenado
            Console.Write("\nVetor Ordenado (QUICK SORT): ");
            for (i = 0; i < 10; i++)
            {
                Console.Write("{0,3}", X[i]);
            }

            Console.ReadKey();
        }

        static void Quick(int[] X, int p, int r)
        {
            int q;

            if (p < r)
            {
                q = Partição(X, p, r);
                Quick(X, p, q);
                Quick(X, q + 1, r);
            }
        }

        static int Partição(int[] X, int p, int r)
        {
            int Pivô;
            int i, j;

            Pivô = X[(p + r) / 2];

            i = p - 1;
            j = r + 1;

            while (i < j)
            {
                do
                {
                    j--;
                } while (X[j] > Pivô);

                do
                {
                    i++;
                } while (X[i] < Pivô);

                if (i < j)
                {
                    Troca(X, i, j);
                }
            }

            return j;
        }

        static void Troca(int[] X, int i, int j)
        {
            int Aux;

            Aux = X[i];
            X[i] = X[j];
            X[j] = Aux;
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
