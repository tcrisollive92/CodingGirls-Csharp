using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09_Exercicio01
{
    public class Quadrado:AreadaFigura
    {
        public double L { get; set; }

        public Quadrado(double l)
        {
            L = l;
        }
        public override double Calcular()
        {
            double area = L * L;
            return area;
        }
        public override string ToString()
        {
            return $"Quadrado:{Calcular():0.00} m².";
        }
    }
}
