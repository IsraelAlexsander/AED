using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    internal class Dados
    {
        private ArrayList Cadastro;

        public Dados()
        {
            Cadastro = new ArrayList();
        }

        public void inserirAluno(Aluno x)
        {
            Cadastro.Add(x);
        }

        public ArrayList ListarAlunos()
        {
            return Cadastro;
        }
    }
}
