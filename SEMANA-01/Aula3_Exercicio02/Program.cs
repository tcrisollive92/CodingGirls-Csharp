using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula3_Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2-Faça um programa que leia três valores e apresente o maior dos três valores lidos seguido da mensagem “x é o maior”.
            Console.WriteLine("Digite três valores:");
            int[] valores = new int[3];
            for (int i = 0; i < valores.Length; i++)
            {
                valores[i] = int.Parse(Console.ReadLine());
            }
            int maior = valores.Max();

            Console.WriteLine($"{maior} é o maior dos três valores.");

        }
    }
}
