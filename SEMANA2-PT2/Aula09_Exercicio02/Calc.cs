using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09_Exercicio02
{
    public class Calc : BaseCalc
    {
        public double ValorTotal = 0.0;
        
        public override void Menu()
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

            string EscolhaDoUsuario = Console.ReadLine();
            Console.Write(">");

            double Valor1=0;
            double Valor2=0;

            if (EscolhaDoUsuario == "5")
            {
                ValorTotal = 0.0;
                
                Menu();
            }
            else
            {
                Console.WriteLine("Escolha o primeiro valor: ");
                Valor1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Escolha o segundo valor: ");
                Valor2 = double.Parse(Console.ReadLine());
            }

            switch (EscolhaDoUsuario)
            {
                case "1":
                    Somar(Valor1, Valor2);
                    
                    break;

                case "2":
                    Subtrair(Valor1, Valor2);
                    
                    break;

                case "3":
                    Multiplicar(Valor1, Valor2);
                    
                    break;

                case "4":
                    Dividir(Valor1, Valor2);
                    
                    break;
                

                default:
                    
                    break;
            }
        }
        
        public void Somar(double Valor1, double Valor2)
        {
            ValorTotal = Valor1 + Valor2;
            Menu();
        }
        
        public void Subtrair(double Valor1, double Valor2)
        {
            ValorTotal = Valor1 - Valor2;
            Menu();
        }
        
        public void Multiplicar(double Valor1, double Valor2)
        {
            ValorTotal = Valor1 * Valor2;
            Menu();
        }
        
        public void Dividir(double Valor1, double Valor2)
        {
            ValorTotal = Valor1 / Valor2;
            Menu();
        }
       
    }
}
