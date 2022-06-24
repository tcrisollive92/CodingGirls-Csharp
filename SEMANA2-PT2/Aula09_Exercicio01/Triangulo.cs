using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09_Exercicio01
{
    class Triangulo : AreadaFigura
    {
        public double B { get; set; }
        public double H { get; set; }

        public Triangulo(double b, double h)
        {
            B = b;
            H = h;
        }
        public override double Calcular()
        {
            double area=(B * H)/2.0; 
            return area;
        }

        public override string ToString()
        {
            return $"Triângulo:{Calcular():0.00} m².";
        }
    }

   
}
