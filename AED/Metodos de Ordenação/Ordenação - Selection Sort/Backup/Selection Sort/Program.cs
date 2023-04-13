using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Selection_Sort
{
    class Program
    {
        // Projeto de Exemplo - SELECTION SORT
        // ===================================
        //
        // Ordena um vetor de 10 posições com números inteiros fornecidos pelo usuário,
        // e gera um outro vetor ordenado pelo método SELECTION SORT.
        
        static void Main(string[] args)
        {
            int[] X = new int[10];                // Declaração dos Vetores

            int i, j, Eleito, Menor, Pos;         // Variáveis Auxiliares

            Console.WriteLine("Ordenação em Memória Primária - SELECTION SORT");
            Console.WriteLine("==============================================\n");

            for (i = 0; i < 10; i++)                                        // Entrada dos Elementos do Vetor
            {
                Console.Write("Digite o Elemento {0,2} do Vetor: ", i + 1);
                X[i] = int.Parse(Console.ReadLine());
            }

            // Processo de Ordenação - SELECTION SORT
            // ======================================
            // Algoritmo padrão do método

            for (i = 0; i < 9; i++)            // Da primeira à penúltima posição do vetor
            {
                Eleito = X[i];                 // Guarda o elemento pivot para comparação

                // Agora vamos encontrar o menor elemento à direita do eleito
                Menor = X[i + 1];              // O menor começa sendo o primeiro à direita do eleito
                Pos = i + 1;                   // e a posição dele é a primeira depois da posição do eleito

                for (j = i + 1; j <= 9; j++)   // Para todos os elementos à direta do eleito na posição i...
                {
                    if (X[j] < Menor)          // Se for menor que Menor
                    {
                        Menor = X[j];          // Pega o menor número
                        Pos = j;               // e a posição dele
                    }
                }

                // Troca o número Eleito pelo menor que está à direita dele
                if (Menor < Eleito)
                {
                    X[i] = X[Pos];
                    X[Pos] = Eleito;

                    for (int xx = 0; xx < 10; xx++)
                    {
                        Console.Write("{0,3}", X[xx]);
                    }
                    Console.Write("\n");
                }
            }

            // Mostrando o Vetor Ordenado
            Console.Write("\nVetor Ordenado (SELECTION SORT): ");
            for (i = 0; i < 10; i++)
            {
                Console.Write("{0,3}", X[i]);
            }

            Console.ReadKey();
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
