using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    internal class Operacoes
    {
        public void Inserir(Aluno novoAluno, Dados MeusDados)
        {
            novoAluno.lerDados();

            MeusDados.inserirAluno(novoAluno);
        }

        public void Listar(Dados MeusDados)
        {
            ArrayList Lista;

            Lista = MeusDados.ListarAlunos();

            foreach (Aluno x in Lista)
            {
                x.mostrarDados();
            }
            Console.ReadKey();
        }
    }
}
