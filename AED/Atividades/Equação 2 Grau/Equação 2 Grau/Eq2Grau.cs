using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equação_2_Grau
{
    internal class Eq2Grau
    {
        private double _a;

        public double a  //propriedade -> Obter valor de uma variavel
        {
            get { return _a; }

            set 
            {
                if (value == 0)
                {
                    Console.WriteLine("Valor inválido para o coeficiênte da equação");
                    Console.ReadKey();
                    
                    Environment.Exit(0);
                }                    
                else
                    _a = value;
            }
        }

        private double _b;

        public double b
        {
            get { return _b; }
            set { _b = value; }
        }

        public double c { get; set; }

        public double Delta { get; private set; }

        public double Raiz1 { get; private set; }

        public double Raiz2 { get; private set; }

        public void CalcDelta()
        {
            Delta = _b * _b - 4 * _a * c;
        }            

        public void CalcRaiz()
        {
            Raiz1 = ((-_b + Math.Sqrt(Delta)) / (2 * _a));
            Raiz2 = ((-_b - Math.Sqrt(Delta)) / (2 * _a));
        }
    }
}
