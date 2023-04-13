using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hashManual
{
    internal class Program
    {
        class Produto
        {
            public int Numero { get; set; }
            public string Descricao { get; set; }

            public void Mostra()
            {
                Console.WriteLine($"{this.Numero} - {this.Descricao}");
            }

            public void Ler()
            {
                Console.Write("Número do produto: ");
                this.Numero = int.Parse(Console.ReadLine());

                Console.Write("Descrição: ");
                this.Descricao = Console.ReadLine();
            }
        }

        static void Main(string[] args)
        {
            int Posicao;

            List<Produto>[] Cadastro = new List<Produto>[8];

            for(int i = 0; i < 8; i++)
            {
                Cadastro[i] = new List<Produto>();
            }

            Produto x;

            for (int i = 1; i <= 5; i++)
            {
                x = new Produto();

                x.Ler();

                Posicao = x.Numero % 8;

                Cadastro[Posicao].Add(x);
            }

            //Mostrar

            foreach(List<Produto> Lista in Cadastro)
            {
                if(Lista.Count != 0)
                {
                    Console.WriteLine();

                    foreach(Produto P in Lista)
                    {
                        P.Mostra();                        
                    }
                }                
            }
            Console.ReadKey();

            int Chave;

            Console.Write("\nChave a remover: ");
            Chave = int.Parse(Console.ReadLine());

            Produto MeuProduto = new Produto();

            foreach(List<Produto> Lista in Cadastro)
            {
                if(Lista.Count != 0)
                {
                    foreach (Produto P in Lista)    
                    {
                        if(P.Numero == Chave)
                        {
                            MeuProduto = P;
                        }
                    }
                    Lista.Remove(MeuProduto);
                }
            }

            foreach (List<Produto> Lista in Cadastro)
            {
                if (Lista.Count != 0)
                {
                    Console.WriteLine();

                    foreach (Produto P in Lista)
                    {
                        P.Mostra();
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
