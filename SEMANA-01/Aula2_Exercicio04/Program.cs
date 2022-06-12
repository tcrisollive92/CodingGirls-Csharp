using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2_Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4-Leia um valor inteiro correspondente à idade de uma pessoa e mostre-a em anos, meses e dias.

            Console.Write("Digite a sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            int mes = idade * 12;
            int dias = idade * 365;

            Console.WriteLine($"Sua idade em anos é {idade},em meses é {mes} e em dias é {dias} ");
        }
    }
}
