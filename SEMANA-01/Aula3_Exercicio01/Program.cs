using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula3_Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1- Leia um valor de ponto flutuante com duas casas decimais. Este valor representa um valor monetário. A seguir, calcule o menor número de notas e moedas possíveis no qual o valor pode ser decomposto.As notas consideradas são de 100, 50, 20, 10, 5, 2.

            Console.Write("Digite um valor : R$ ");
            float valor = float.Parse(Console.ReadLine());

            int[] notas = { 100, 50, 20, 10, 5, 2 };
            int[] contador = { 0, 0, 0, 0, 0, 0 };

            int saldo = (int)Math.Round(valor);
            for (int i = 0; i < notas.Length; i++)
            {
                if (saldo >= notas[i])
                {
                    if (saldo % notas[i] == 0)
                    {
                        contador[i] = saldo / notas[i];
                        saldo = 0;
                    }
                    else
                    {
                        contador[i] = saldo / notas[i];
                        saldo = saldo % notas[i];
                    }
                }
            }
            Console.Write("Notas: ");
            for (int i = 0; i < contador.Length; i++)
            {
                Console.Write($" {contador[i]} nota(s) de R$ {notas[i] }");
            }
        }
    }
}
