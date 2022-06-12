using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula3_Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3-Leia 3 valores que são as três notas de um aluno. A seguir, calcule a média do aluno.Considere que cada nota pode ir de 0 até 10.0, sempre com uma casa decimal.Imprima se o aluno foi aprovado ou reprovado considerando a média 7.

            Console.WriteLine("Digite três notas:");
            
            double[] notas = new double[3];

            for (int i = 0; i < notas.Length; i++)
            {
                Console.Write($"{i + 1}º nota: ");
                notas[i] = double.Parse(Console.ReadLine());
            }

            double media = notas.Average();

            string resultado = media < 0.0 || media > 10.0 ? "Valor inválido!" : media < 7.0 ? "Reprovado!" : "Aprovado!";
            
            Console.Write(resultado);
        }
    }
}
