using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioProposto2
{
    internal class Elemento
    {
        public int senha;
        public Elemento Proximo;

        public Elemento()
        {
            senha = 0;
            Proximo = null;
        }
    }
}
