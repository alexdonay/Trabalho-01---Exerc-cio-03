using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_01___Exercício_03
{
    internal class Quadrado : Retangulo
    {
        public double lado;
    

        public override double CalculaArea()
        {
            base.altura = this.lado;
            base.lado = this.lado;
            return base.CalculaArea();
        }
        public override double CalculaPerimetro()
        {
            return base.CalculaPerimetro();
        }
    }
}
