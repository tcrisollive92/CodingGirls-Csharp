using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula4_Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3-Crie um programa que lê 5 palavras e as ordena em um vetor de strings pelo seu tamanho. Se o tamanho das strings for igual, deve-se manter a ordem inserida pelo usuário.

            string[] nome = new string[5];
            string[] tamanho = new string[5];

            Console.WriteLine("Digite cinco nomes: ");

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"{i + 1}º: ");
                nome[i] = Console.ReadLine();
            }

            tamanho = nome.OrderBy(_ => _.Length).ToArray();

            Console.WriteLine("Nomes em ordem de tamanho: ");

            for (int i = 0; i < tamanho.Length; i++)
            {
                Console.Write(tamanho[i] + " ");
            }
        }
    }
}
