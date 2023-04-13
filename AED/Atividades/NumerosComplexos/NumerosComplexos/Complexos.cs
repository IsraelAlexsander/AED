using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosComplexos
{
    internal class Complexos
    {
		private int _PReal;

		public int PReal
		{
			get { return _PReal; }
			set { _PReal = value; }
		}

		private int _PImg;

		public int PImg
		{
			get { return _PImg; }
			set { _PImg = value; }
		}

		public void MostraComplexo()
		{
			Console.WriteLine($"{_PReal} {(_PImg<0? "-" : "+")} {Math.Abs(_PImg)}i");
		}

		public Complexos SomaComplexos(Complexos a, Complexos b)
		{
			Complexos x = new Complexos();

			x.PReal = a.PReal + b.PReal;
			x.PImg = a.PImg + b.PImg;

			return x;
		}

        public Complexos SubtracaoComplexos(Complexos a, Complexos b)
        {
            Complexos x = new Complexos();

            x.PReal = a.PReal - b.PReal;
            x.PImg = a.PImg - b.PImg;

            return x;
        }

    }
}
