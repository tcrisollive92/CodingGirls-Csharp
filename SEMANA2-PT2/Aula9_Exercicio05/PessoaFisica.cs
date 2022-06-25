using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula9_Exercicio05
{
    public class PessoaFisica : Cliente
    {
        public string Cpf { get; set; }

        public PessoaFisica(string nome, string endereco, string telefone, string cpf)
            : base(nome, endereco, telefone)
        {
            this.Cpf = cpf;
        }

        public override string ToString()
        {
            return ($"CPF: {Cpf}|Nome: {Nome}|Endereço: {Endereco}|Telefone: {Telefone}");

        }

    }
}
