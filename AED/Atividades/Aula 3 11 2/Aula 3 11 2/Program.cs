using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_3_11_2
{
    class Aluno
    {
        public string matricula { get; set; }
        public string nome { get; set; }
    }

    internal class Program
    {
        static void mostra(Queue<Aluno> Lista)
        {
            foreach (Aluno x in Lista)
            {
                Console.WriteLine($"{x.matricula} - {x.nome}");
            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Queue<Aluno> filaAluno = new Queue<Aluno>();


            Aluno xAluno;

            xAluno = new Aluno();
            xAluno.matricula = "123";
            xAluno.nome = "Israel";

            filaAluno.Enqueue(xAluno);

            xAluno = new Aluno();
            xAluno.matricula = "456";
            xAluno.nome = "Alexsander";

            filaAluno.Enqueue(xAluno);

            xAluno = new Aluno();
            xAluno.matricula = "789";
            xAluno.nome = "Vilela";

            filaAluno.Enqueue(xAluno);

            mostra(filaAluno);

            xAluno = filaAluno.Dequeue(); //retorna o primeiro elemento e retira ele

            Console.WriteLine($"\nO aluno {xAluno.nome} saiu da fila...\n");

            mostra(filaAluno);

            xAluno = filaAluno.Peek(); //retorna o primeiro elemento

            mostra(filaAluno);            

            Console.WriteLine($"\nO aluno no inicio da fila é: {xAluno.nome}");
            Console.ReadKey();
        }
    }
}
