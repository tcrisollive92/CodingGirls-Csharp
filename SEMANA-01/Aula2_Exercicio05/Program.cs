using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2_Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*5-Construa um conversor de moedas:
           Crie um programa que solicite um um valor em real ao usuário e converta esse valor, para:
           DOLAR
           EURO
           LIBRA ESTERLINA
           DÓLAR CANADENSE
           PESO ARGENTINO
           PESO CHILENO
           */
         
            Console.Write("Digite o valor em reais: R$ ");
            double x = double.Parse(Console.ReadLine());

            double dolar = x / 4.73;
            double euro = x / 5.08;
            double libra = x / 5.98;
            double dolarca = x / 3.72;
            double pesoarg = x / 0.040;
            double pesochi = x / 0.0057;

            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine($"\n O valor convertido é:\n DOLAR:US$ {dolar:00.00}\n EURO:€{euro:00.00}\n LIBRA ESTERLINA:£{libra:00.00}\n DÓLAR CANADENSE:C$ {dolarca:00.00}\n PESO ARGENTINO:${pesoarg:00.00}\n PESO CHILENO:${pesochi:00.00}");

        }
    }
}
