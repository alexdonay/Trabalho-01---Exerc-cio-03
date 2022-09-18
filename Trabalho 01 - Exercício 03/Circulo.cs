using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_01___Exercício_03
{
    internal class Circulo : Forma
    {
        public double raio;
        public double pi = 3.14;
        public override double CalculaArea()
        {
            return pi * (raio * raio);
        }
        public override double CalculaPerimetro()
        {
            return 2 * pi * raio;
        }
    }
}
