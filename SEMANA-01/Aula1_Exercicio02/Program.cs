using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1_Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2-Escolha uma mulher famosa na história da tecnologia e implemente um programa que escreve seu nome, sua formação e uma contribuição feita por ela dentro da tecnologia em linhas separadas

            string nome = "Marie Curie";
            string formacao = "Cientista com mestrado em Física e Matemática";
            string historia = "Foi a primeira mulher a ganhar o prêmio Nobel em Física,\nseus estudos constataram a descoberta dos elementos químicos Rádio e Polônio que revolucionaram a medicina \ncom a criação da radioterapia";

            Console.WriteLine("---Mulheres famosas na história da tecnologia---");
            Console.WriteLine($"Nome:{nome}\nFormação: {formacao}\nContribuições feitas dentro do universo da tecnologia:{historia}");

        }
    }
}
