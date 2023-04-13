using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_3_11_3
{
    class Aluno
    {
        public string matricula { get; set; }
        public string nome { get; set; }
    }

    internal class Program
    {
        static void mostra(Stack<Aluno> Lista)
        {
            foreach (Aluno x in Lista)
            {
                Console.WriteLine($"{x.matricula} - {x.nome}");
            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Stack<Aluno> pilhaAluno = new Stack<Aluno>();

            Aluno xAluno;

            xAluno = new Aluno();
            xAluno.matricula = "123";
            xAluno.nome = "Israel";

            pilhaAluno.Push(xAluno);

            xAluno = new Aluno();
            xAluno.matricula = "456";
            xAluno.nome = "Alexsander";

            pilhaAluno.Push(xAluno);

            xAluno = new Aluno();
            xAluno.matricula = "789";
            xAluno.nome = "Vilela";

            pilhaAluno.Push(xAluno);

            mostra(pilhaAluno);

            xAluno = pilhaAluno.Pop();
            Console.WriteLine($"\nO aluno de matricula {xAluno.matricula} saiu da pilha\n");
            Console.WriteLine($"Existem {pilhaAluno.Count()} alunos na pilha\n");

            mostra(pilhaAluno);
        }
    }
}
