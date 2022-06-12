using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2_Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*3-Escreva um programa que leia o número de horas trabalhadas e um funcionário, o valor
            que recebe por hora e calcula o salário desse funcionário. A seguir, mostre o número
            e o salário do funcionário, com duas casas decimais.*/

            Console.Write("Nome do Funcionário: ");
            string nome = Console.ReadLine();

            Console.Write("Digite as horas trabalhadas: ");
            double horas = double.Parse(Console.ReadLine());

            Console.Write("Valor a receber por hora: ");
            double valorhora = double.Parse(Console.ReadLine());

            double salario = horas * valorhora;

            Console.WriteLine($"O funcionário {nome},trabalhou {horas} hora(s) e receberá R$ {salario:00.00}");
        }
    }
}
