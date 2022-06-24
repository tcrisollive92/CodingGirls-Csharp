using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09_Exercicio02
{
    public class CalcCientifica : BaseCalc
    {
        public double ValorTotal = 0.0;
        
        public override void Menu()
        {
            
            Console.WriteLine($"Valor Total: {ValorTotal}");
            Console.Clear();
            Console.WriteLine("Escolha qual operação deseja realizar: ");
            Console.WriteLine("1-Raiz");
            Console.WriteLine("2-Potência");
            Console.WriteLine("3-Reiniciar");
            Console.WriteLine("\n");
            Console.WriteLine($"Valor Total: {ValorTotal}");
            Console.Write(">");

            string EscolhaDoUsuario = Console.ReadLine();
            Console.Write(">");
            int i = 0;
            double Valor=0;

            if (EscolhaDoUsuario == "2")
            {
                Console.WriteLine("Entre com valor que deseja calcular: ");
                Valor = double.Parse(Console.ReadLine());
                Console.WriteLine("Qual será o índice da potência que deseja calcular: ");
                i = int.Parse(Console.ReadLine());

            }
            else if(EscolhaDoUsuario == "3")
            {
                ValorTotal = 0.0;
                
                Menu();
            }
            else
            {
                Console.WriteLine("Entre com valor que deseja calcular: ");
                Valor = double.Parse(Console.ReadLine());
            }
            
            switch (EscolhaDoUsuario)
            {
                case "1":
                    Raiz(Valor);
                    
                    break;

                case "2":
                    Potencia(Valor, i);
                    
                    break;

                default:
                    Menu();
                    break;
            }

        }
       
        public void Raiz(double Valor)
        {
            ValorTotal = Math.Sqrt(Valor);
            Menu();

        }
        
        public void Potencia(double Valor, int i)
        {
            ValorTotal = Math.Pow(Valor, i);
            Menu();
        }

    }
}
