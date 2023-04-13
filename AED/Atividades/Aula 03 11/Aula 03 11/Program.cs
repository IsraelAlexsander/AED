using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Aula_03_11
{
    class Aluno
    {
        public string matricula { get; set; }
        public string nome { get; set; }
    }    

    internal class Program
    {
        static void mostra(List<Aluno> Lista)
        {
            foreach (Aluno x in Lista)
            {
                Console.WriteLine($"{x.matricula} - {x.nome}");
            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            List<Aluno> listaAluno = new List<Aluno>();


            Aluno xAluno;

            xAluno = new Aluno();
            xAluno.matricula = "123";
            xAluno.nome = "Israel";

            listaAluno.Add(xAluno);                       

            xAluno = new Aluno();
            xAluno.matricula = "456";
            xAluno.nome = "Alexsander";

            listaAluno.Add(xAluno);

            xAluno = new Aluno();
            xAluno.matricula = "789";
            xAluno.nome = "Vilela";

            listaAluno.Add(xAluno);

            mostra(listaAluno);

            // Procurar item

            string item;
            int posicao = -1;

            item = "456";            

            foreach (Aluno x in listaAluno)
            {
                if (x.matricula == item)
                    posicao = listaAluno.IndexOf(x);
            }

            if (posicao != -1)
                Console.WriteLine($"A matricula {item} se encontra na posição {posicao + 1}");
            else
                Console.WriteLine($"A matricula {item} não existe");

            Console.ReadKey();

            // inserir na posição desejada

            xAluno = new Aluno();
            xAluno.matricula = "111";
            xAluno.nome = "Andrade";

            listaAluno.Insert(2, xAluno);

            mostra(listaAluno);
        }        
    }
}
