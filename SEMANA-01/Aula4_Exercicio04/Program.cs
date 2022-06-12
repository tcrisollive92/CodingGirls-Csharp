using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula4_Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*4- Jogo Jokenpô
            Utilizando os conceitos aprendidos até estruturas de repetição, crie um programa que jogue pedra, papel e tesoura(Jokenpô) com você.
            Permitir que eu decida quantas rodadas iremos fazer;
            Ler a minha escolha(Pedra, papel ou tesoura);
            Decidir de forma aleatória a decisão do computador;
            Mostrar quantas rodadas cada jogador ganhou;
            Determinar quem foi o grande campeão de acordo com a quantidade de vitórias de cada um(computador e jogador);
            Perguntar se o Jogador quer jogar novamente, se sim inicie volte a escolha de quantidade de rodadas, se não finalize o programa.*/

            int opcao = 1;
            int vitoriausuario = 0;
            int vitoriapc = 0;
            int empate = 0;

            while (opcao == 1)
            {
                Console.WriteLine("Quantas partidas serão: ");
                int rodadas = int.Parse(Console.ReadLine());

                string[] lista = { "Pedra", "Papel", "Tesoura" };

                for (int i = 0; i < rodadas; i++)
                {
                    Console.WriteLine("Escolha:\n0-Pedra\n1-Papel\n2-Tesoura");
                    int escolha = int.Parse(Console.ReadLine());

                    Random r = new Random();
                    int computer = r.Next(0, 2);

                    if (escolha < 0 || escolha > 2)
                    {
                        Console.WriteLine("Jogada inválida!");

                    }
                    else if (escolha == computer)
                    {
                        Console.WriteLine($"RODADA EMPATADA!você escolheu:{lista[escolha]} e o pc escolheu:{lista[computer]} ");
                        empate++;
                    }
                    else if (escolha == 0 && computer == 1 || escolha == 1 && computer == 2 || escolha == 2 && computer == 0)
                    {
                        Console.WriteLine($"VC PERDEU ESSA RODADA!você escolheu:{lista[escolha]} e o pc escolheu:{lista[computer]} ");
                        vitoriapc++;
                    }
                    else
                    {
                        Console.WriteLine($"VC GANHOU ESSA RODADA!você escolheu:{lista[escolha]} e o pc escolheu:{lista[computer]} ");
                        vitoriausuario++;
                    }
                }
                Console.WriteLine("Deseja continuar jogando?\n1-Sim\n2-Não");
                opcao = int.Parse(Console.ReadLine());
            }
            string resultado = vitoriapc == vitoriausuario ? $"Empatados!{vitoriausuario} x {vitoriapc}" : vitoriausuario > vitoriapc && vitoriausuario > empate ? $"O usuário é o grande campeão!{vitoriausuario} x {vitoriapc}" : $"O computador é o grande campeão!{vitoriapc} x {vitoriausuario}";

        }
    }
}
