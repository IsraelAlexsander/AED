using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoHashTable
{
    internal class Operacoes
    {
        public void inserir(Paciente P, Dados MeusDados)
        {
            P.lerDados();
            MeusDados.inserirPaciente(P);
        }

        public void listar(Dados MeusDados)
        {
            Hashtable Lista;

            Lista = MeusDados.listar();

            foreach (Paciente P in Lista.Values)
            {
                P.mostrarDados();
            }
        }

        public void pesquisar(string RG, Paciente P, Dados MeusDados)
        {
            P = MeusDados.pesquisarPaciente(RG);

            if (P != null)
            {
                Console.WriteLine();
                P.mostrarDados();
            }
            else
            {
                Console.WriteLine("\nPaciente não cadastrado");
            }
        }

        public void excluir(string RG, Paciente P, Dados MeusDados)
        {
            P = MeusDados.pesquisarPaciente(RG);

            if (P != null)
            {
                Console.WriteLine();
                P.mostrarDados();
                MeusDados.excluirPaciente(RG);

                Console.WriteLine($"\n{P.Nome} foi excluido");
            }
            else
            {
                Console.WriteLine("\nPaciente não cadastrado");
            }
        }        

        public void salvarXML(Dados MeusDados)
        {
            int registros;

            registros = MeusDados.salvarArquivo();

            Console.WriteLine($"\nArquivo XML gerado com sucesso!\nTotal de registros: {registros}");
        }

        public void lerXML(Dados MeusDados)
        {
            int registros;

            registros = MeusDados.lerArquivo();

            Console.WriteLine($"\nArquivo XML carregado com sucesso!\nTotal de registros: {registros}");
        }
    }
}
