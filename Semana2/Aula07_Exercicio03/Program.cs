using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07_Exercicio03
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*3-Crie uma classe Conta Bancária que possua os seguintes atributos: número da conta, nome do cliente e saldo privados. Além dos métodos de get para os atributos crie um método para alterar o nome, realizar depósitos e saques.
             * Também construa um construtor onde saldo é opcional, com valor default zero, já os demais atributos são obrigatórios.*/
            
            ContaBancaria conta;
            double valor=0.0;

            Console.WriteLine("---Bem vindo ao Banco Blue---");
            Console.Write("Entre com o número da conta: ");
            int numero=int.Parse(Console.ReadLine());
            Console.Write("Entre com o nome do Cliente: ");
            string nome =Console.ReadLine();
            Console.WriteLine("Haverá deposito inicial? ");
            string resposta=Console.ReadLine();

            if (resposta == "sim") { 
                Console.WriteLine("Entre com o valor do depósito: ");
                double depositoinicial=double.Parse(Console.ReadLine());
                conta=new ContaBancaria(numero,nome,depositoinicial);
            }
            else { conta = new ContaBancaria(numero, nome); }

            Console.WriteLine($"Dados da conta:\n{conta}");
            Console.WriteLine("Deseja realizar qual operação:\n1-Saque\n2-Depósito\n3-Alterarnomecliente\n4-Sair");
            Console.Write(">>");
            string opcao=Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.WriteLine("Entre com o valor que deseja sacar: ");
                    valor = double.Parse(Console.ReadLine());
                    conta.Saque(valor);

                    Console.WriteLine($"Dados atualizados da conta:\n{conta}");
                    break;
                case "2":
                    Console.WriteLine("Entre com o valor que deseja depositar: ");
                    valor = double.Parse(Console.ReadLine());
                    conta.Deposito(valor);

                    Console.WriteLine($"Dados atualizados da conta:\n{conta}");
                    break;

                case "3":
                    Console.WriteLine("Digite o novo nome: ");
                    nome = Console.ReadLine();
                    conta.AlterarNome(nome);

                    Console.WriteLine($"Dados atualizados da conta:\n{conta}");
                    break;

                default:
                    Console.WriteLine("Obrigada por escolher o banco blue!");
                    break;
            }
            
        }
    }
}
