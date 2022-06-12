using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula4_Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1-Crie um programa que solicite a entrada de 10 números pelo usuário, armazenando-os em um vetor, e então monte outro vetor com os valores do primeiro multiplicados por 5.
            //Exiba os valores dos dois vetores na tela, um em cada linha.

            int[] vetorA = new int[10];
            Console.WriteLine("Digite 10 números: ");
            for (int i = 0; i < vetorA.Length; i++)
            {
                Console.Write($"{i + 1}º:");
                vetorA[i] = int.Parse(Console.ReadLine());
            }
            int[] vetorB = new int[10];
            for (int i = 0; i < vetorB.Length; i++)
            {
                vetorB[i] = 5 * vetorA[i];
            }
            Console.Write("VetorA= ");
            foreach (int a in vetorA)
            {
                Console.Write(a + " ");
            }
            Console.WriteLine();
            Console.Write("VetorB= ");
            foreach (int b in vetorB)
            {
                Console.Write(b + " ");
            }

        }
    }
}
