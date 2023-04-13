using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno meuAluno = new Aluno();

            meuAluno.lerDados();
            meuAluno.mostrarDados();
        }
    }
}
