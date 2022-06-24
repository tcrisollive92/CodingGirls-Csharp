using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula06_02
{
    public class Empregado
    {
        private string Nome;
        private string Cargo;
        private double SalarioMensal;
        
        private int i;

        public Empregado()
        {
            Funcionario();
        }

        private double Salario()
        {
            if (SalarioMensal < 0.0) { return SalarioMensal=0.0; }
            else { return SalarioMensal; }
        }
        public double Aumento()
        {
            i = Salario() > 0.0 && Salario() <= 400.00 ? 0 : Salario() <= 800.00 ? 1 : Salario() <= 1200.00 ? 2 : Salario() <= 2000.00 ? 3 : 4;
            double[] a = { 0.15, 0.12, 0.10, 0.07, 0.04 };
       
            double reajuste = Salario()* a[i];

            double Novosalario = Salario() + reajuste;
            return Novosalario;
        }
        private void Funcionario()

        {
            Console.Write("Digite o nome do Funcionário: ");
            Nome=Console.ReadLine();

            Console.Write("Digite o cargo do Funcionário: ");
            Cargo = Console.ReadLine();

            Console.Write("Digite o salário do Funcionário: ");
            SalarioMensal = double.Parse(Console.ReadLine());

            Console.WriteLine($"Funcionário: {Nome}\n Cargo:{Cargo}\nSalário Mensal: R${Salario():00.00}.\nReceberá R${Aumento():00.00} de salário mensal após reajuste. ");
        }

    }
}
