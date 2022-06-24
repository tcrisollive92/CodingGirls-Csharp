using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Aula08_Exercicio03.Animal;

namespace Aula08_Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> mundoanimal = new List<Animal>();

            Animal animal;
            Console.WriteLine("Escolha quantos animais deseja adicionar a lista: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {

                Console.WriteLine("Deseja adicionar qual animal a lista:\n1 - Peixes\n2 - Mamiferos\n3 - Sair");
                string escolha = Console.ReadLine();

                if (escolha == "1")
                {
                    Console.Write("Entre com o nome do animal: ");
                    string nome = Console.ReadLine();
                    Console.Write("Número de Patas: ");
                    int patas = int.Parse(Console.ReadLine());
                    Console.Write("Cor do animal: ");
                    string cor = Console.ReadLine();
                    Console.Write("Ambiente: ");
                    string ambiente = Console.ReadLine();
                    Console.Write("Velocidade Média: ");
                    double velMedia = double.Parse(Console.ReadLine());
                    Console.Write("Caracteristicas: ");
                    string carac = Console.ReadLine();

                    animal = new Peixe(nome, patas, cor, ambiente, velMedia, carac);

                    mundoanimal.Add(animal);
                    Console.WriteLine("------------------------------------");
                }
                else if (escolha == "2")
                {
                    Console.Write("Entre com o nome do animal: ");
                    string nome = Console.ReadLine();
                    Console.Write("Número de Patas: ");
                    int patas = int.Parse(Console.ReadLine());
                    Console.Write("Cor do animal: ");
                    string cor = Console.ReadLine();
                    Console.Write("Ambiente: ");
                    string ambiente = Console.ReadLine();
                    Console.Write("Velocidade Média: ");
                    double velMedia = double.Parse(Console.ReadLine());
                    Console.Write("Alimento: ");
                    string alimento = Console.ReadLine();

                    animal = new Mamifero(nome, patas, cor, ambiente, velMedia, alimento);

                    mundoanimal.Add(animal);

                    Console.WriteLine("------------------------------------");
                }
                else { Console.WriteLine("Escolha um animal válido!"); }

            }

            Console.WriteLine("Lista de animais cadastrados: ");
            foreach (Animal a in mundoanimal)
            {
                Console.WriteLine(a.ToString());
            }


        }


    }
}
