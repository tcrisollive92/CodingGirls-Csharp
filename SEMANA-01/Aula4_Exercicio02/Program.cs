using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula4_Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2-Crie um programa que armazene 10 números digitados pelo usuário em dois vetores: um somente para números pares, e outro somente para números ímpares. Após, exiba os valores dos dois vetores na tela, um vetor em cada linha.

            Console.WriteLine("Digite 10 valores: ");

            int[] par = new int[10];
            int[] impar = new int[10];
            int[] numero = new int[10];
            int n;

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{i + 1}º ");
                numero[i] = int.Parse(Console.ReadLine());

                if (numero[i] % 2 == 0) { par[i] = numero[i]; }
                else { impar[i] = numero[i]; }
            }

            Console.Write("Vetor Par: ");
            foreach (int p in par) { if (p > 0) { Console.Write(p + " "); } }
            Console.WriteLine();

            Console.Write("Vetor Impar: ");
            foreach (int m in impar) { if (m > 0) { Console.Write(m + " "); } }

        }
    }
}
