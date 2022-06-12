using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula3_Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*5-A Blue resolveu dar um aumento de salários a seus funcionários de acordo com os dados abaixo:
            Salário de 0 até 400.00 ganha 15 % Salário de 400.01 até 800.00 ganha 12 % Salário de 800.01 até 1200.00 ganha 10 % Salário de 1200.01 até 2000.00 ganha 7 % Acima de 2000.00 ganha 4 %
            Leia o salário do funcionário e calcule e mostre o novo salário, bem como o valor de reajuste ganho e o índice reajustado, em percentual.*/

            Console.Write("Digite seu salário: R$ ");
            double salario = double.Parse(Console.ReadLine());
            double novosalario, reajuste;

            string[] p = { "15%", "12%", "10%", "7%", "4%" };
            double[] a = { 0.15, 0.12, 0.10, 0.07, 0.04 };

            int i = salario > 0 && salario <= 400.00 ? 0 : salario <= 800.00 ? 1 : salario <= 1200.00 ? 2 : salario <= 2000.00 ? 3 : 4;
            reajuste = salario * a[i];
            novosalario = salario + reajuste;

            Console.WriteLine($"Novo salario R${novosalario:00.00},o reajuste ganho R${reajuste:00.00} e o percentual foi de {p[i]} ");

        }
    }
}
