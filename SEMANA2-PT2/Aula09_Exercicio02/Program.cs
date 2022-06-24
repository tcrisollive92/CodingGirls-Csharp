using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09_Exercicio02
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha uma calculadora:\n1-Básica\n2-Cientifica");
            string escolha = Console.ReadLine();

            switch (escolha)
            {
                case "1":
                    Calc calc = new Calc();
                    calc.Menu();

                    break;
                case "2":
                    CalcCientifica calcc = new CalcCientifica();
                    calcc.Menu();

                    break;
            }
        }
    }
}
