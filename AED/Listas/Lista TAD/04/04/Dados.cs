using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    internal class Dados
    {
        ArrayList listaDeFilmes;

        public Dados()
        {
            listaDeFilmes = new ArrayList();
        }

        public void adicionarFilme(Filme novoFilme)
        {
            novoFilme.lerDados();

            listaDeFilmes.Add(novoFilme);
        }

        public void listarFilmes()
        {
            foreach (Filme x in listaDeFilmes)
            {
                x.mostrarDados();                
            }

            Console.ReadKey();
        }

        public void buscarCategoria(string cat)
        {
            foreach (Filme x in listaDeFilmes)
            {
                if (cat.ToLower() == x.categoria.ToLower())
                {
                    x.mostrarDados();
                }
            }
        }
    }
}
