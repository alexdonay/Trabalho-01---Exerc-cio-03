using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_01___Exercício_03
{
    internal class Retangulo : Forma
    {
        public double lado;
        public double altura;
        public override double CalculaArea()
        {
            return lado * altura;
        }
        public override double CalculaPerimetro()
        {
            return 2 * (lado + altura);
        }
    }
}
