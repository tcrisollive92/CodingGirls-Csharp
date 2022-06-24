using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09_Exercicio01
{
    public class Circulo:AreadaFigura
    {
        public double R { get; set; }
        public const double PI = 3.1415;

        public Circulo(double r)
        {
            R = r;
        }
        public override double Calcular()
        {
            double area = R * R * PI;
            return area;
        }

        public override string ToString()
        {
            return $"Circulo:{Calcular():0.00} m².";
        }
    }
}
