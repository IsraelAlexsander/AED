using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Metodos_de_Ordenação
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] X = new int[1000000];     
            int[] Y = new int[1000000];
            int Aux;

            Random r = new Random();

            for (int i = 0; i < X.Length; i++)
            {
                X[i] = r.Next();
                Y[i] = r.Next();
            }

            #region Merge Sort

            Console.WriteLine("\nMERGE SORT");
            Stopwatch sw = new Stopwatch();
            sw.Start();

            Merge(Y, 0, X.Length - 1);

            sw.Stop();
            TimeSpan ts = sw.Elapsed;

            Console.WriteLine($"Tempo: {ts.TotalMilliseconds.ToString()}\n");            
            #endregion

            #region Bouble Sort      

            Console.WriteLine("\nBUBBLE SORT");
            Stopwatch sw2 = new Stopwatch();
            sw2.Start();

            for (int i = 1; i <= X.Length; i++)           
            {
                for (int j = 0; j < X.Length - 1; j++)         
                {
                    if (X[j] > X[j + 1])        
                    {
                        Aux = X[j];             
                        X[j] = X[j + 1];
                        X[j + 1] = Aux;
                    }
                }
            }

            sw2.Stop();
            TimeSpan ts2 = sw2.Elapsed;                     

            Console.WriteLine($"Tempo: {ts2.TotalMilliseconds.ToString()}\n");

            Console.ReadKey();
            #endregion            
        }

        static void Merge(int[] X, int Início, int Fim)
        {
            int Meio;

            if (Início < Fim)
            {
                Meio = (Início + Fim) / 2;

                Merge(X, Início, Meio);
                Merge(X, Meio + 1, Fim);

                Intercala(X, Início, Fim, Meio);
            }
        }

        static void Intercala(int[] X, int Início, int Fim, int Meio)
        {
            int PosLivre, InícioVetorA, InícioVetorB, i;
            int[] Aux = new int[X.Length];

            InícioVetorA = Início;
            InícioVetorB = Meio + 1;
            PosLivre = Início;

            while (InícioVetorA <= Meio && InícioVetorB <= Fim)
            {
                if (X[InícioVetorA] <= X[InícioVetorB])
                {
                    Aux[PosLivre] = X[InícioVetorA];
                    InícioVetorA = InícioVetorA + 1;
                }
                else
                {
                    Aux[PosLivre] = X[InícioVetorB];
                    InícioVetorB = InícioVetorB + 1;
                }

                PosLivre++;
            }


            for (i = InícioVetorA; i <= Meio; i++)
            {
                Aux[PosLivre] = X[i];
                PosLivre++;
            }


            for (i = InícioVetorB; i <= Fim; i++)
            {
                Aux[PosLivre] = X[i];
                PosLivre++;
            }


            for (i = Início; i <= Fim; i++)
            {
                X[i] = Aux[i];
            }
        }

    }
}

// Escolhi os métodos de ordenação Bubble Sort e Merge Sort, por possuirem uma complexidade diferente.
// Bubble possui uma complexidade O(n²), tanto no pior quanto no melhor caso.
// Merge Sort possui uma complexidade n * log(n). E assim como o anterior, a complexidade é a mesma no pior e melhor caso
// Comparando os métodos com um vetor de 1 milhão de inteiros randomicos, pode-se ver a grande diferença de desempenho entre os ordenadores
// Com os testes realizados em meu computador, obtive os seguintes resultados:
// Merge Sort ordenou o vetor com o tempo de 144887,211 milissegundos
// Bubble Sort ordenou o vetor com o tempo de 6573507,6032 milissegundos
// Com valores pequenos, o Bubble Sort pode ser considerado uma boa opção, mas quanto maior a quantidade de elementos, maior vai ficando sua ineficiência
// O Merge Sort também tem um bom desempenho com poucos elementos, mas seu desempenho não cai tanto quando o Bubble, com quantidade maior de elementos



