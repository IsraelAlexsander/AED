using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bubble_Sort
{
    class Program
    {
        // Projeto de Exemplo - BUBBLE SORT
        // ================================
        //
        // Ordena um vetor de 10 posições com números inteiros fornecidos pelo usuário,
        // e gera um outro vetor ordenado pelo método BUBBLE SORT.
        //
        // O programa também gera um outro vetor com os números ordenados sem repetição.

        static void Main(string[] args)
        {
            int[] X = new int[10];      // Declaração dos Vetores
            int[] Y = new int[10];
            
            int i, j, Pos, Aux;         // Variáveis Auxiliares

            Console.WriteLine("Ordenação em Memória Primária - BUBBLE SORT");
            Console.WriteLine("===========================================\n");

            for (i = 0; i < 10; i++)                                        // Entrada dos Elementos do Vetor
            {
                Console.Write("Digite o Elemento {0,2} do Vetor: ", i+1);
                X[i] = int.Parse(Console.ReadLine());
            }
            
            // Processo de Ordenação - BUBBLE SORT - Versão I
            // ==============================================
            // Algoritmo padrão do método

            for (i = 1; i <= 10; i++)           // Desde a segunda até a última posição do vetor...
            {
                for (j = 0; j < 9; j++)         // Desde a primeira até a penúltima posição do vetor...
                {
                    if (X[j] > X[j + 1])        // Compara. Se o elemento atual é maior que o elemento da frente dele no vetor,
                    {
                        Aux = X[j];             // Troca ele de lugar com o da frente...
                        X[j] = X[j + 1];
                        X[j + 1] = Aux;
                    }
                }
            }

            // Mostrando o Vetor Ordenado
            Console.Write("\nVetor Ordenado (BUBBLE SORT Versão I) ....: ");
            for (i = 0; i < 10; i++)
            {
                Console.Write("{0,3}", X[i]);
            }

            Console.ReadKey();
            

            // Processo de Ordenação - BUBBLE SORT - Versão II
            // ===============================================
            // Nesse caso as posições do vetor já ordenadas não são mais percorridas

            for (i = 1; i <= 9; i++)           // Desde a segunda até a penúltima posição do vetor...
            {
                for (j = 9; j >= i; j--)          // Desde a última posição até a posição i do vetor...
                {
                    if (X[j] < X[j - 1])        // Compara. Se o elemento atual é menor que o elemento atrás dele no vetor,
                    {
                        Aux = X[j];             // Troca ele de lugar com o da frente...
                        X[j] = X[j - 1];
                        X[j - 1] = Aux;
                    }
                }
            }

            // Mostrando o Vetor Ordenado
            Console.Write("\nVetor Ordenado (BUBBLE SORT Versão II) ...: ");
            for (i = 0; i < 10; i++)
            {
                Console.Write("{0,3}", X[i]);
            }

            Console.ReadKey();


            // Processo de Ordenação - BUBBLE SORT - Versão III
            // ================================================
            // Nesse caso uma variável controla o número de iterações e o algoritmo troca elementos enquanto for preciso

            int Troca = 1;                      // Controle

            i = 1;

            while(i<=10 && Troca==1)            // Para todos os elementos do vetor...
            {
                Troca = 0;

                for (j = 0; j <= 8; j++)        // Desde a primeira até a penúltima posição do vetor...
                {
                    if (X[j] > X[j + 1])        // Compara. Se o elemento atual é maior que o elemento na frente dele no vetor,
                    {
                        Troca = 1;
                        Aux = X[j];             // Troca ele de lugar com o da frente...
                        X[j] = X[j + 1];
                        X[j + 1] = Aux;
                    }
                }

                i++;                            // Próximo elemento...
            }

            // Mostrando o Vetor Ordenado
            Console.Write("\nVetor Ordenado (BUBBLE SORT Versão III) ..: ");
            for (i = 0; i < 10; i++)
            {
                Console.Write("{0,3}", X[i]);
            }

            Console.ReadKey();

            
            // Geração do segundo vetor sem elementos repetidos
            Pos = 0;                            // Posição onde o elemento será inserido no vetor de destino
            for (i = 0; i < 10; i++)            // Para todos os 10 elementos...
            {
                if (i == 0)                     // Se é o primeiro elemento...
                {
                    Y[Pos] = X[i];              // Coloca ele na primeira posição do vetor de destino
                    Pos++;                      // e incrementa o índice de posição
                }
                else if (X[i] != Y[Pos - 1])    // Se o elemento atual do vetor origem não existe no segundo vetor...
                {
                    Y[Pos] = X[i];              // então armazena ele no segundo vetor
                    Pos++;                      // e incrementa
                }
            }


            // Mostrando o Segundo Vetor
            Console.Write("\n\nVetor Ordenado sem Repetição .............: ");
            for (i = 0; i < Pos; i++)
            {
                Console.Write("{0,3}", Y[i]);
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

