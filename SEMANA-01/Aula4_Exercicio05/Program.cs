using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula4_Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*5-Jogo da Velha
            Crie um algorítimo que possibilite que dua pessoas joguem o jogo da velha e exiba quem foi o vencedor.
            O tabuleiro é uma matriz de três linhas e três colunas.
            Dois jogadores escolhem uma marcação cada um, geralmente um círculo(O) e um xis(X).
            Os jogadores jogam alternadamente, uma marcação por vez, numa célula que esteja vazia.
            O objetivo é conseguir três círculos ou três xis em linha, quer horizontal, vertical ou diagonal, e ao mesmo tempo, quando possível, impedir o adversário de ganhar na próxima jogada.
            Quando um jogador conquista o objetivo ele é o vencedor. Se os dois jogadores jogarem sempre da melhor forma, o jogo terminará sempre em empate ou seja "Deu a Velha!".*/

            string resposta = "SIM";

            while (resposta == "SIM")
            {
                string[,] jogodavelha = new string[3, 3];

                int posicao = 1;
                
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        jogodavelha[i, j] = Convert.ToString(posicao);
                        posicao++;
                    }
                }
                Console.WriteLine("---------------------JOGO DA VELHA--------------------");
                Console.WriteLine();
                Console.WriteLine($"    {jogodavelha[0, 0]} | {jogodavelha[0, 1]} | {jogodavelha[0, 2]}");
                Console.WriteLine("-----------------");
                Console.WriteLine($"    {jogodavelha[1, 0]} | {jogodavelha[1, 1]} | {jogodavelha[1, 2]}");
                Console.WriteLine("-----------------");
                Console.WriteLine($"    {jogodavelha[2, 0]} | {jogodavelha[2, 1]} | {jogodavelha[2, 2]}");

                int jogadas = 0;

                string jogador, tabuleiro;

                while (jogadas < 9)
                {

                    Console.WriteLine("Escolha sua marcação: X ou O ? ");
                    jogador = Console.ReadLine();

                    int p = 0;

                    if (jogador == "X")
                    {
                        Console.WriteLine("Jogador X escolha uma posição: ");
                        p = int.Parse(Console.ReadLine());

                        tabuleiro = p == 1 ? jogodavelha[0, 0] = jogador : p == 2 ? jogodavelha[0, 1] = jogador : p == 3 ? jogodavelha[0, 2] = jogador : p == 4 ? jogodavelha[1, 0] = jogador : p == 5 ? jogodavelha[1, 1] = jogador : p == 6 ? jogodavelha[1, 2] = jogador : p == 7 ? jogodavelha[2, 0] = jogador : p == 8 ? jogodavelha[2, 1] = jogador : jogodavelha[2, 2] = jogador;
                        jogadas++;

                    }
                    else if (jogador == "O")
                    {
                        Console.WriteLine("Jogador O escolha uma posição:");
                        p = int.Parse(Console.ReadLine());

                        tabuleiro = p == 1 ? jogodavelha[0, 0] = jogador : p == 2 ? jogodavelha[0, 1] = jogador : p == 3 ? jogodavelha[0, 2] = jogador : p == 4 ? jogodavelha[1, 0] = jogador : p == 5 ? jogodavelha[1, 1] = jogador : p == 6 ? jogodavelha[1, 2] = jogador : p == 7 ? jogodavelha[2, 0] = jogador : p == 8 ? jogodavelha[2, 1] = jogador : jogodavelha[2, 2] = jogador;
                        jogadas++;
                    }
                    else
                    {
                        Console.WriteLine("Marcador inválido,tente novamente!");
                    }

                    Console.WriteLine("---------------------JOGO DA VELHA--------------------");
                    Console.WriteLine();
                    Console.WriteLine($"    {jogodavelha[0, 0]} | {jogodavelha[0, 1]} | {jogodavelha[0, 2]}");
                    Console.WriteLine("-----------------");
                    Console.WriteLine($"    {jogodavelha[1, 0]} | {jogodavelha[1, 1]} | {jogodavelha[1, 2]}");
                    Console.WriteLine("-----------------");
                    Console.WriteLine($"    {jogodavelha[2, 0]} | {jogodavelha[2, 1]} | {jogodavelha[2, 2]}");


                    if (jogadas > 3)
                    {
                        if ((jogodavelha[0, 0] == "X" && jogodavelha[0, 1] == "X" && jogodavelha[0, 2] == "X") ||
                           (jogodavelha[0, 0] == "X" && jogodavelha[1, 0] == "X" && jogodavelha[2, 0] == "X") ||
                           (jogodavelha[0, 1] == "X" && jogodavelha[1, 1] == "X" && jogodavelha[2, 1] == "X") ||
                           (jogodavelha[0, 0] == "X" && jogodavelha[1, 1] == "X" && jogodavelha[2, 2] == "X") ||
                           (jogodavelha[0, 2] == "X" && jogodavelha[1, 1] == "X" && jogodavelha[2, 0] == "X") ||
                           (jogodavelha[2, 0] == "X" && jogodavelha[2, 1] == "X" && jogodavelha[2, 2] == "X") ||
                           (jogodavelha[1, 0] == "X" && jogodavelha[1, 1] == "X" && jogodavelha[1, 2] == "X") ||
                           (jogodavelha[2, 0] == "X" && jogodavelha[2, 1] == "X" && jogodavelha[2, 2] == "X"))
                        {
                            Console.WriteLine("O Jogador X ganhou!");

                            break;
                        }
                        else if ((jogodavelha[0, 0] == "O" && jogodavelha[0, 1] == "O" && jogodavelha[0, 2] == "O") ||
                                (jogodavelha[0, 0] == "O" && jogodavelha[1, 0] == "O" && jogodavelha[2, 0] == "O") ||
                                (jogodavelha[0, 1] == "O" && jogodavelha[1, 1] == "O" && jogodavelha[2, 1] == "O") ||
                                (jogodavelha[0, 0] == "O" && jogodavelha[1, 1] == "O" && jogodavelha[2, 2] == "O") ||
                                (jogodavelha[0, 2] == "O" && jogodavelha[1, 1] == "O" && jogodavelha[2, 0] == "O") ||
                                (jogodavelha[2, 0] == "O" && jogodavelha[2, 1] == "O" && jogodavelha[2, 2] == "O") ||
                                (jogodavelha[1, 0] == "O" && jogodavelha[1, 1] == "O" && jogodavelha[1, 2] == "O") ||
                                (jogodavelha[2, 0] == "O" && jogodavelha[2, 1] == "O" && jogodavelha[2, 2] == "O"))
                        {
                            Console.WriteLine("O Jogador O ganhou!");

                            break;
                        }
                        else if (jogadas > 8)
                        {
                            Console.WriteLine("Deu velha!");
                        }
                    }
                }
                Console.WriteLine("Deseja jogar novamente?");
                resposta = Console.ReadLine();
            }

        }
    }
}
