using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula05_Exercicio03
{
    public  class Calculadora
    {
        private double ValorTotal = 0;

        public Calculadora()
        {
            Menu();
        }
        private void Menu()
        {

            Console.WriteLine($"Valor Total: {ValorTotal}");
            Console.Clear();

            Console.WriteLine("Escolha qual operação deseja realizar: ");
            Console.WriteLine("1-Somar ");
            Console.WriteLine("2-Subtrair");
            Console.WriteLine("3-Multiplicar");
            Console.WriteLine("4-Dividir");
            Console.WriteLine("5-Reiniciar");
            Console.WriteLine("\n");
            Console.WriteLine($"Valor Total: {ValorTotal}");
            Console.Write(">");

            double ValorDoUsuario1 = 0.0;
            double ValorDoUsuario2 = 0.0;
            string EscolhaDoUsuario = Console.ReadLine();
            Console.Write(">");
            if (EscolhaDoUsuario == "5")
            {
                ValorTotal = 0.0;
                Menu();
            }
            else
            {
                Console.WriteLine("Escolha o primeiro valor: ");
                ValorDoUsuario1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Escolha o segundo valor: ");
                ValorDoUsuario2 = double.Parse(Console.ReadLine());
            }
            switch (EscolhaDoUsuario)
            {
                case "1":
                    Somar(ValorDoUsuario1, ValorDoUsuario2);
                    break;

                case "2":
                    Subtrair(ValorDoUsuario1, ValorDoUsuario2);
                    break;

                case "3":
                    Multiplicar(ValorDoUsuario1, ValorDoUsuario2);
                    break;
                case "4":
                    Divisao(ValorDoUsuario1, ValorDoUsuario2);
                    break;

                default:
                    Menu();
                    break;
            }

        }
        private void Somar(double Valor1, double Valor2)
        {
            ValorTotal = Valor1 + Valor2;
            Menu();
        }
        private void Subtrair(double Valor1, double Valor2)
        {
            ValorTotal = Valor1 - Valor2;
            Menu();
        }
        private void Multiplicar(double Valor1, double Valor2)
        {
            ValorTotal = Valor1 * Valor2;
            Menu();
        }
        private void Divisao(double Valor1, double Valor2)
        {
            ValorTotal = Valor1 / Valor2;
            Menu();
        }
       
    }
}