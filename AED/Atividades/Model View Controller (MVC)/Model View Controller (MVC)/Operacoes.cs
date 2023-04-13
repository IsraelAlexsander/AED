using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Model_View_Controller__MVC_
{
    internal class Operacoes
    {
        public void Inserir(Aluno MeuAluno, Dados MeusDados)
        {
            MeuAluno.LerDados();

            MeusDados.InserirAluno(MeuAluno);
        }

        public void Listar(Dados MeusDados)
        {
            ArrayList Lista;

            Lista = MeusDados.ListarAlunos();

            foreach (Aluno x in Lista)
            {
                x.MostraDados();
            }

            Console.ReadKey();
        }

        public void Pesquisar(string codPesq, Aluno MeuAluno, Dados MeusDados)
        {
            MeuAluno = MeusDados.PesquisarAluno(codPesq);

            if(MeuAluno != null)
            {
                Console.WriteLine("\n");

                MeuAluno.MostraDados();
            }
            else
            {
                Console.Write("\nAluno não encontrado na Base de Dados");                
            }

            Console.ReadKey();
        }

        public void Excluir(string codPesq, Aluno MeuAluno, Dados MeusDados)
        {
            MeuAluno = MeusDados.PesquisarAluno(codPesq);

            if (MeuAluno != null)
            {
                Console.WriteLine("\n");

                MeuAluno.MostraDados();

                MeusDados.ExcluirAluno(MeuAluno);

                Console.WriteLine("\nAluno excluido do Cadastro!");
            }
            else
            {
                Console.Write("\nAluno não encontrado na Base de Dados");
            }

            Console.ReadKey();
        }

        public void Alterar(string codPesq, Aluno MeuAluno,Aluno MeuAlunoAlterado, Dados MeusDados)
        {
            MeuAluno = MeusDados.PesquisarAluno(codPesq);

            if (MeuAluno != null)
            {
                Console.WriteLine("\n");

                MeuAluno.MostraDados();

                Console.WriteLine("\nDados de Atualização: \n");

                MeuAlunoAlterado.LerDados(false);

                MeuAlunoAlterado.codigo = MeuAluno.codigo;

                MeusDados.AlterarAluno(MeuAluno, MeuAlunoAlterado);

                Console.WriteLine("\nDados altualizados");
            }
            else
            {
                Console.Write("\nAluno não encontrado na Base de Dados");
            }

            Console.ReadKey();
        }

        public void Ordenar(Dados MeusDados)
        {
            int registros;

            registros = MeusDados.OrdenarAlunos();

            Console.WriteLine($"\nDados Ordenados. Total de Registros: {registros}");

            Console.ReadKey();
        }

        public void SalvarXML(Dados MeusDados)
        {
            int Registros;

            Registros = MeusDados.SalvarArquivo();

            Console.WriteLine($"\nArquivo XML gerado com sucesso!\nTotal de registros: {Registros}\n");

            Console.ReadKey();

        }
        public void LerXML(Dados MeusDados)
        {
            int Registros;

            Registros = MeusDados.LerArquivo();

            Console.WriteLine($"\nArquivo XML carregado com sucesso!\nTotal de registros: {Registros}\n");

            Console.ReadKey();

        }
    }
}
