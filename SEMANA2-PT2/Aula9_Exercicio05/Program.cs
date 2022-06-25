using Aula9_Exercicio05;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Aula09_Exercicio5
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Cliente>cadastroclientecpf=new List<Cliente>();
            List<Cliente> cadastroclientecnpj=new List<Cliente>();
            string resposta = "sim";
            Cliente cliente;

            Console.WriteLine("Vamos iniciar o cadastro:");

            while (resposta == "sim")
            {

                Console.Write("Nome do Cliente: ");
                string nome = Console.ReadLine();
                Console.Write("Endereço: ");
                string endereco = Console.ReadLine();
                Console.Write("Telefone para contato: ");
                string telefone = Console.ReadLine();


                Console.Write("1-Pessoa Física\n2-Pessoa Jurídica\nEscolha: ");
                string escolha1 = Console.ReadLine();
                if (escolha1 == "1")
                {
                    Console.Write("Insira o CPF do Cliente: ");
                    string cpf = Console.ReadLine();
                    cliente = new PessoaFisica(nome, endereco, telefone, cpf);
                    
                    cadastroclientecpf.Add(cliente);

                }
                else if(escolha1 == "2")
                {
                    Console.Write("Insira o CNPJ da empresa: ");
                    string cnpj = Console.ReadLine();
                    Console.Write("Insira o Nome Fantasia da empresa: ");
                    string nomefantasia = Console.ReadLine();
                    cliente = new PessoaJuridica(nome, endereco, telefone, cnpj, nomefantasia);
                    
                    cadastroclientecnpj.Add(cliente);
                }
                else { Console.WriteLine( "Opção inválida!"); }

                Console.Clear();
                Console.Write("Deseja cadastrar outro cliente?");
                Console.Write(">>");
                resposta = Console.ReadLine();
            }

            Console.WriteLine("Qual lista deseja consultar:\n1-Clientes CPF\n2-Clientes CNPJ");
            Console.Write(">>");
            string escolha= Console.ReadLine();
            if(escolha == "1")
            {
                foreach (Cliente pf in cadastroclientecpf) { Console.WriteLine(pf.ToString()); }
            }
            else if(escolha == "2")
            {
                foreach(Cliente pj in cadastroclientecnpj) { Console.WriteLine(pj.ToString()); }
            }
            else { Console.WriteLine("Opção inválida!"); }
        }


    }
}

