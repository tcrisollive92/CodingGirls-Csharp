using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07_Exercicio04
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*4-Vamos modelar um cadastro de animais de uma pet-shop? Crie uma classe que modele os 
             * animais e contenha como atributos nome, espécie, cor, idade, observação e dados do dono.
             * Os atributos relacionados ao dono do animal deve ser privados para proteção de dados.
             * Forrneça métodos para cadastro e leitura das informações.*/

            Console.WriteLine("---Cadastro Pet----");
            Console.Write("Nome do Pet: ");
            string nome=Console.ReadLine();
            Console.Write("Espécie do Pet: ");
            string especie=Console.ReadLine();
            Console.Write("Cor do Pet: ");
            string cor=Console.ReadLine();
            Console.Write("Idade do Pet: ");
            int idade=int.Parse(Console.ReadLine());
            Console.Write("Informações adicionais sobre o pet: ");
            string info=Console.ReadLine();
            Console.Write("Dados do dono: ");
            string dadosdono=Console.ReadLine();    

            CadastroPet cadastro=new CadastroPet(nome,especie,cor,idade,info,dadosdono);
            Console.WriteLine(cadastro);

            List<CadastroPet> list = new List<CadastroPet>();
            list.Add(cadastro);

            

        }
    }
}
