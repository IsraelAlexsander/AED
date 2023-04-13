using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorteio
{
    internal class Aluno
    {
        public Aluno MeuAluno;
        public string Nome;        
        public Aluno Proximo;

        public Aluno()
        {
            MeuAluno = null;
            Proximo = null; 
        }        
    }
}
