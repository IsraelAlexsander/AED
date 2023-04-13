using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strucs_e_Classes
{
    class FuncionarioC
    {
        public string nome;
        public double salario;
        public Data nascimento;   
    }

    class Data
    {
        public string Dia;
        public string Mes;
        public string ano;
    }

    struct FuncionarioS
    {
        public string nome;
        public double salario;
        public int idade;
    }
    internal class Program
    {
        static void Main(string[] args)
        {            
            #region Struct
            //FuncionarioS[] xFunc = new FuncionarioS[3];

            //for (int i = 0; i < xFunc.Length; i++)
            //{
            //    Console.Write("Nome do funcionário: ");
            //    xFunc[i].nome = Console.ReadLine();

            //    Console.Write("Salario: ");
            //    xFunc[i].salario = double.Parse(Console.ReadLine());

            //    Console.Write("Idade: ");
            //    xFunc[i].idade = int.Parse(Console.ReadLine());

            //    Console.WriteLine();

            //    Console.Clear();
            //}

            //foreach (FuncionarioS x in xFunc)
            //{
            //    Console.WriteLine($"{x.nome} - {x.idade} anos");
            //    Console.WriteLine($"Salário: R$ {x.salario:F2}");
            //}

            //Console.ReadKey();
            //Console.Clear();

            #endregion
            
            #region Classe

            FuncionarioC[] xFunci = new FuncionarioC[3];            

            for (int i = 0; i < xFunci.Length; i++)
            {

                FuncionarioC F = new FuncionarioC(); // Tem que ficar dentro do for, para criar sempre um novo endereço de memoria

                Console.Write("Nome do funcionário: ");
                F.nome = Console.ReadLine();

                Console.Write("Salario: ");
                F.salario = double.Parse(Console.ReadLine());

                F.nascimento = new Data();  //Tem que instanciar o tipo composto também

                Console.WriteLine("Data de nascimento");
                Console.Write("Dia: ");
                F.nascimento.Dia = Console.ReadLine();
                Console.Write("Mês: ");
                F.nascimento.Mes = Console.ReadLine();
                Console.Write("Ano: ");
                F.nascimento.ano = Console.ReadLine();


                xFunci[i] = F;

                Console.WriteLine();

                Console.Clear();
            }

            foreach (FuncionarioC x in xFunci)
            {
                Console.WriteLine($"{x.nome} - Nasceu em: {x.nascimento.Dia} de {x.nascimento.Mes} de {x.nascimento.ano}");
                Console.WriteLine($"Salário: R$ {x.salario:F2}");
            }

            Console.ReadKey();

            #endregion
        }
    }
}
