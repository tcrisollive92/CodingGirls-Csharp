using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula06_Exercicio04
{
    public class Sorteio
    {
        public int NumeroSorte;

        public void Sorteionumero()
        {
            Random numero = new Random();
            NumeroSorte = numero.Next(1, 1000);
            
        }

        public void Palpites()
        {
            string resposta="sim";
            do
            {   
                Sorteionumero();
                Console.WriteLine("Adivinhe qual o número sorteado:");
                Console.Write(">");
                int palpite = int.Parse(Console.ReadLine());

                int tentativa = 1;
                if (palpite != NumeroSorte)
                {
                    while (palpite != NumeroSorte)
                    {
                        if (palpite > NumeroSorte)
                        {
                            Console.WriteLine("Seu palpite é maior que o número sorteado!");
                            Console.Write("Entre com um novo papite: ");
                            Console.Write(">");
                            palpite=int.Parse(Console.ReadLine());
                        }
                        else { Console.WriteLine("Seu palpite é menor que o número sorteado!");
                               Console.Write("Entre com um novo papite: ");
                               Console.Write(">");
                               palpite = int.Parse(Console.ReadLine());
                        }

                        tentativa++;
                    }
                }
                else { Console.WriteLine($"Parabéns você acertou o número da sorte!Número de palpite= {tentativa} o número da sorte é {NumeroSorte}"); }


                Console.WriteLine($"Parabéns você acertou o número da sorte!Número de palpite= {tentativa} o número da sorte é {NumeroSorte}");
                Console.WriteLine("Deseja jogar novamente? ");

            } while (resposta == "sim");
        }
        
        
    }
}
