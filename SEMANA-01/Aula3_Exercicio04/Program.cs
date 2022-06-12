using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula3_Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Leia 3 valores que são as três notas de um aluno. A seguir, calcule a média do aluno.
            Se a nota for menor que 6.0, deve exibir a nota F.
            Se a nota for de 6.0 até 7.0, deve exibir a nota D.
            Se a nota for entre 7.0 e 8.0, deve exibir a nota C.
            Se a nota for entre 8.0 e 9.0, deve exibir a nota B.
            Se a nota fot entre 9.0 e 10.0, deve exibir um belo de um A.
            Não esqueça de adicionar uma mensagem após a nota, pode ser um simples parabéns para aprovação ou algo mais complexo.
             */
            
            Console.WriteLine("Digite três notas:");

            double[] notas = new double[3];

            for (int i = 0; i < notas.Length; i++)
            {
                Console.Write($"{i + 1}º nota: ");
                notas[i] = double.Parse(Console.ReadLine());
            }

            double media = notas.Average();

            string resultado = media < 0.0 || media > 10.0 ? "Valor inválido!" : media < 6.0 ? "O aluno tirou F.Reprovado!" : media < 7.0 ? "O aluno tirou D.Recuperação!" : media < 8.0 ? "O aluno tirou C.Aprovado!" : media < 9.0 ? "O aluno tirou B.Aprovado!" : "O aluno tirou A.Parabéns!";
            Console.WriteLine(resultado);

        }
    }
}
