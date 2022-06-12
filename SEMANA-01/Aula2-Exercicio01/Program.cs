using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2_Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1- Faça um programa que pergunte ao usuário ano de nascimento e imprima sua idade.

            Console.Write("Informe o ano do seu nascimento: ");
            int anonascimento = int.Parse(Console.ReadLine());

            string ano = DateTime.Now.Year.ToString();
            int anoatual = int.Parse(ano);
            int idade = anoatual - anonascimento;

            Console.WriteLine($"Sua idade é {idade} anos.");
        }
    }
}
