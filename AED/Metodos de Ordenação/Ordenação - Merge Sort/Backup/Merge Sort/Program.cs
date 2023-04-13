using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Merge_Sort
{
    class Program
    {
        // Projeto de Exemplo - MERGE SORT
        // ===================================
        //
        // Ordena um vetor de 10 posições com números inteiros fornecidos pelo usuário,
        // e gera um outro vetor ordenado pelo método MERGE SORT.

        static void Main(string[] args)
        {
            int[] X = new int[10];      // Declaração dos Vetores
            int i;                      // Variável Auxiliar

            Console.WriteLine("Ordenação em Memória Primária - MERGE SORT");
            Console.WriteLine("==========================================\n");

            for (i = 0; i < 10; i++)                                        // Entrada dos Elementos do Vetor
            {
                Console.Write("Digite o Elemento {0,2} do Vetor: ", i + 1);
                X[i] = int.Parse(Console.ReadLine());
            }

            Merge(X,0,9);          // Chama a função Merge passando o vetor de elementos e o elemento de início e de fim do vetor

            // Mostrando o Vetor Ordenado
            Console.Write("\nVetor Ordenado (MERGE SORT): ");
            for (i = 0; i < 10; i++)
            {
                Console.Write("{0,3}", X[i]);
            }

            Console.ReadKey();
        }

        static void Merge(int[] X, int Início, int Fim)
        {
            int Meio;           // Meio da Lista

            if (Início < Fim)   // Início tem que ser menor que Fim 
            {
                Meio = (Início + Fim) / 2;          // Calcula o Meio da Lista

                Merge(X, Início, Meio);             // Chama novamente Merge (Recursivo) até que todas as divisões sejam feitas
                Merge(X, Meio + 1, Fim);            // tanto na parte esquerda quanto na parte direita do vetor 

                Intercala(X, Início, Fim, Meio);    // E intercala os subvetores que foram criados
            }
        }

        static void Intercala(int[] X, int Início, int Fim, int Meio)
        {
            int PosLivre, InícioVetorA, InícioVetorB, i;
            int[] Aux = new int[10];

            InícioVetorA = Início;
            InícioVetorB = Meio + 1;
            PosLivre = Início;

            while (InícioVetorA <= Meio && InícioVetorB <= Fim)      // Para todos os subvetores que foram divididos
            {
                if (X[InícioVetorA] <= X[InícioVetorB])             // Intercala
                {
                    Aux[PosLivre] = X[InícioVetorA];
                    InícioVetorA = InícioVetorA + 1;
                }
                else
                {
                    Aux[PosLivre] = X[InícioVetorB];                // Intercala
                    InícioVetorB = InícioVetorB + 1;
                }

                PosLivre++;
            }

            // Se ainda existem números no primeiro vetor que não foram intercalados...
            for (i = InícioVetorA; i <= Meio; i++)
            {
                Aux[PosLivre] = X[i];
                PosLivre++;
            }

            // Se ainda existem números no segundo vetor que não foram intercalados...
            for (i = InícioVetorB; i <= Fim; i++)
            {
                Aux[PosLivre] = X[i];
                PosLivre++;
            }

            // Retorna os valores de Aux para X
            for(i=Início;i<=Fim;i++)
            {
                X[i]=Aux[i];
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
