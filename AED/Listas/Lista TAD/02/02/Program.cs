using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno MeuAluno = new Aluno();

            MeuAluno.lerDados();
            MeuAluno.mostrarDados();
        }
    }
}
