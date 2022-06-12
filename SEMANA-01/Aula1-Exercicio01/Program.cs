using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1_Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1-Elabore um programa que escreve seu nome completo, seu endereço, o CEP e telefone em linhas separadas.

            string nome = "Maria Silva";
            string endereco = "Rua das Tulipas 10";
            string cep = "123456-78";
            string telefone = "021 9999-8888";

            Console.WriteLine($"Nome: {nome}\nEndereço: {endereco}\nCEP: {cep}\nTelefone: {telefone}");
        }
    }
}
