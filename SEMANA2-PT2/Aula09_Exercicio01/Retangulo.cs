using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09_Exercicio01
{
    public class Retangulo:AreadaFigura
    {
        public double B { get; set; }
        public double H { get; set; }

        public Retangulo(double b, double h)
        {
            B = b;
            H = h;
        }
        public override double Calcular()
        {
            double area = B * H;
            return area;
        }

        public override string ToString()
        {
            return $"Retângulo:{Calcular():0.00} m²";
        }
    }
}
