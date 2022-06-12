using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2_Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2-Escreva um programa que leia 10 valores inteiros e ao final exiba a soma dos números.

            int valor;
            int soma = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Insira o {i+1}º número: ");
                valor = int.Parse(Console.ReadLine());
                soma += valor;
            }
            Console.WriteLine($"A soma é {soma}");
        }
    }
}
