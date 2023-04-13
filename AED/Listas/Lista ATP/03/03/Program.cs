using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double altura;
            int idade;
            char sexo;

            double maiorAltura = double.MinValue;
            double menorAltura = double.MaxValue;
            double alturaTotalM = 0;
            int contM = 0;
            int HomensEntre50e40 = 0;

            for (int i = 1; i <= 15 ; i++)
            {
                Console.Write("Digite sua altura: ");
                altura = double.Parse(Console.ReadLine());                

                Console.Write("Digite sua idade: ");
                idade = int.Parse(Console.ReadLine());

                Console.Write($"Digite o seu sexo: M - Masculino    F - Feminino: ");
                sexo = char.Parse(Console.ReadLine().ToLower());

                if (altura > maiorAltura)
                    maiorAltura = altura;
                else if (altura < menorAltura)
                    menorAltura = altura;

                if (sexo == 'm')
                {
                    if (idade >= 40 && idade <= 50)
                        HomensEntre50e40++;
                }
                else if (sexo == 'f')
                {
                    alturaTotalM += altura;
                    contM++;
                }
                
                Console.Clear();
            }

            Console.WriteLine($"A maior altura do grupo é: {maiorAltura} metros\nE a menor é: {menorAltura} metros");
            Console.WriteLine($"A média da altura das mulheres é: {alturaTotalM / contM} metros");
            Console.WriteLine($"A quantidade de homens entre 40 e 50 anos é: {HomensEntre50e40}");

            Console.ReadKey();
        }
    }
}
