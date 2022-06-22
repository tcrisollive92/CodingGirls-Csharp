using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula06_Exercicio01
{
    internal class JogoDaVelha
    {
        int jogadas = 0;
        private string jogador, tabuleiro;
        private string[,] jogodavelha = new string[3, 3];
        string resposta = "SIM";

        public JogoDaVelha() 
        {
            Desenhar();
        }
        private void Tabuleiro()
        {
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
        }
        
        private void Marcacao()
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
            Ganhador();
            
           
        }
        private void Desenhar() 
        { 
            while(resposta == "SIM")
            {
                Tabuleiro();
                while (jogadas < 9)
                {
                    Marcacao();
                    if (Ganhador() != null) 
                    {
                        Console.WriteLine(Ganhador());
                        break;
                    }

                }
                Console.WriteLine("Deseja jogar novamente?");
                resposta = Console.ReadLine();
            }
        }
        private string Ganhador()
        {
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
                    return "O Jogador X ganhou!";


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
                    return "O Jogador O ganhou!";


                }
                else if (jogadas > 8)
                {
                    return "Deu velha!";
                }
                else { return null; }
            }
            else
            {
                return null;
            }
        }



    }
}
