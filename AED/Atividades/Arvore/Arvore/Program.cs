using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arvore
{
    class Elemento
    {
        public int Num;
        public Elemento Esq;
        public Elemento Dir;

        public Elemento()
        {
            Num = 0;
            Esq = null;
            Dir = null;
        }
    }

    class Arvore
    {
        public Elemento Raiz;
        public Elemento Novo;
        public Elemento Aux;

        public Arvore()
        {
            Raiz = null;
            Novo = null;
        }

        public bool inserir(int valor)
        {
            bool achou = false;

            Novo = new Elemento();
            Novo.Num = valor;

            if (Raiz == null)
                Raiz = Novo;
            else
            {
                Aux = Raiz;
                
                while (!achou)
                {
                    if (Novo.Num < Aux.Num)
                        if (Aux.Esq == null)
                        {
                            Aux.Esq = Novo;
                            achou = true;
                        }
                        else
                            Aux = Aux.Esq;

                    else if (Novo.Num > Aux.Num)
                        if (Aux.Dir == null)
                        {
                            Aux.Dir = Novo;
                            achou = true;
                        }
                        else
                            Aux = Aux.Dir;

                    else if (Novo.Num == Aux.Num)
                         return false;
                }
            }
            return achou;
        }

        public int Pesquisar(int valor)
        {
            int altura = 0;

            Aux = Raiz;

            while (Aux != null)
            {
                if (Aux.Num == valor)
                    return altura;
                else if (valor < Aux.Num)
                {
                    Aux = Aux.Esq;
                    altura++;
                }
                else
                {
                    Aux = Aux.Dir;
                    altura++;
                }                
            }
            return -1;
        }

        public void listarEmOrdem(Elemento x)
        {
            if (x != null)
            {
                listarEmOrdem(x.Esq);
                Console.Write($"{x.Num,6}");
                listarEmOrdem(x.Dir);
            }
        }
        public void listarEmPREOrdem(Elemento x) //Raiz primeiro
        {
            if (x != null)
            {
                Console.Write($"{x.Num,6}");
                listarEmPREOrdem(x.Esq);                
                listarEmPREOrdem(x.Dir);
            }
        }
        public void listarEmPOSOrdem(Elemento x) //Raiz por ultimo
        {
            if (x != null)
            {                
                listarEmPOSOrdem(x.Esq);
                listarEmPOSOrdem(x.Dir);
                Console.Write($"{x.Num,6}");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Arvore minhaArvore = new Arvore();

            bool status;

            status = minhaArvore.inserir(52);
            status = minhaArvore.inserir(40);
            status = minhaArvore.inserir(31);
            status = minhaArvore.inserir(28);
            status = minhaArvore.inserir(28);
            status = minhaArvore.inserir(49);
            status = minhaArvore.inserir(67);
            status = minhaArvore.inserir(60);
            status = minhaArvore.inserir(55);
            status = minhaArvore.inserir(80);
            status = minhaArvore.inserir(70);
            status = minhaArvore.inserir(90);

            int altura;

            altura = minhaArvore.Pesquisar(60);

            if (altura > -1)            
                Console.WriteLine($"\nElemento encontrado - Altura: {altura}");

            Console.ReadKey();

            Console.WriteLine($"\nPercurso em ordem");
            minhaArvore.listarEmOrdem(minhaArvore.Raiz);

            Console.WriteLine();

            Console.WriteLine($"\nPercurso em Pré-ordem");
            minhaArvore.listarEmPREOrdem(minhaArvore.Raiz);

            Console.WriteLine();

            Console.WriteLine($"\nPercurso em Pós-ordem");
            minhaArvore.listarEmPOSOrdem(minhaArvore.Raiz);
            
            Console.ReadKey();


        }
    }
}
