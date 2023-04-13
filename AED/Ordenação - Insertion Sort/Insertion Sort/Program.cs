using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Insertion_Sort
{
    class Program
    {
        // Projeto de Exemplo - INSERTION SORT
        // ===================================
        //
        // Ordena um vetor de 10 posições com números inteiros fornecidos pelo usuário,
        // e gera um outro vetor ordenado pelo método INSERTION SORT.
        
        static void Main(string[] args)
        {
            int[] X = new int[10];      // Declaração dos Vetores

            int i, j, Eleito;           // Variáveis Auxiliares

            Console.WriteLine("Ordenação em Memória Primária - INSERTION SORT");
            Console.WriteLine("==============================================\n");

            for (i = 0; i < 10; i++)                                        // Entrada dos Elementos do Vetor
            {
                Console.Write("Digite o Elemento {0,2} do Vetor: ", i + 1);
                X[i] = int.Parse(Console.ReadLine());
            }

            // Processo de Ordenação - INSERTION SORT
            // ======================================
            // Algoritmo padrão do método

            for (i = 1; i < 10; i++)                    // Para todos os elementos do vetor
            {
                Eleito = X[i];                          // Elemento pivot de comparação

                j = i - 1;

                // Laço que percorre os elementos à esquerda do número eleito
                // ou até encontrar a posição para recolocação do número eleito
                while (j >= 0 && X[j] > Eleito)
                {
                    X[j + 1] = X[j];
                    j = j - 1;
                }
                X[j + 1] = Eleito;                      // Novo elemento eleito
            }

            // Mostrando o Vetor Ordenado
            Console.Write("\n\nVetor Ordenado (INSERTION SORT): ");
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
