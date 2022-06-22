using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula06_Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*3-Crie uma classe que representa uma fatura para uma loja de suprimentos de informática.
            A classe deve conter os seguintes atributos: número, descrição dos produtos, quantidade comprada 
            de um produto e o preço. A classe deve ter um construtor e um método get e set para cada variável
            de instância. Além disso, forneça um método para calcular o valor total da fatura.*/

            Console.Write("Digite o número do produto: ");
            int numeroProduto=int.Parse(Console.ReadLine());

            Console.Write("Descrição do produto: ");
            string descricaoProduto=Console.ReadLine();

            Console.Write("Número de produtos que deseja comprar: ");
            int quantidadeProduto=int.Parse(Console.ReadLine());

            Console.Write("Preço unitário do produto: ");     
            double precoProduto=double.Parse(Console.ReadLine());

            Fatura fatura = new Fatura(numeroProduto,descricaoProduto,quantidadeProduto,precoProduto);

        }
    }
}
