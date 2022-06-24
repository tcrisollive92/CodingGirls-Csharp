using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09_Exercicio01
{
    public class Program
    {
        static void Main(string[] args)
        {
            AreadaFigura area;
            List<AreadaFigura> list = new List<AreadaFigura>();

            Console.WriteLine("Escolha quantas figuras deseja calcular a área:");
            int n=int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Escolha a figura que deseja calcular a área:\n1-Quadrado\n2-Retângulo\n3-Triângulo\n4-Circulo");
                Console.Write(">>");
                string escolha = Console.ReadLine();
                Console.WriteLine("--------------------------------------");

                if (escolha == "1")
                {
                    Console.Write("Entre com a medida do lado em m:");
                    double l = double.Parse(Console.ReadLine());
                    area = new Quadrado(l);
                    Console.WriteLine($"A área do {area.ToString()}");
                    list.Add(area);
                }
                
                else if (escolha == "2")
                {    
                    Console.Write("Entre com as medidas da base e da altura,respectivamente, em m:");
                    double b = double.Parse(Console.ReadLine());
                    double h = double.Parse(Console.ReadLine());

                    area = new Retangulo(b, h);
                    Console.WriteLine(area.ToString());
                    list.Add(area);
                }
                
                else if (escolha == "3")
                {    
                    Console.Write("Entre com as medidas da base e da altura,respectivamente, em m:");
                    double b = double.Parse(Console.ReadLine());
                    double h = double.Parse(Console.ReadLine());

                    area = new Triangulo(b, h);
                    Console.WriteLine(area.ToString());
                    list.Add(area);

                }
                else if (escolha == "4")
                {    
                    Console.Write("Entre com a medida do raio em m:");
                    double raio = double.Parse(Console.ReadLine());

                    area = new Circulo(raio);
                    Console.WriteLine(area.ToString());
                    list.Add(area);

                }
                else { Console.WriteLine("Escolha um valor válido"); }
                
            }

            Console.WriteLine("-------------------");
            Console.WriteLine("Lista de Formas e áreas calculadas: ");
            foreach(AreadaFigura a in list)
            {
                Console.WriteLine(a.ToString());
            }
            
           
            
            
            

        }
    }
}
