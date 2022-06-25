using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula9_Exercicio05
{
    public class PessoaJuridica : Cliente
    {
        public string Cnpj { get; set; }
        public string NomeFantasia { get; set; }

        public PessoaJuridica(string nome, string endereco, string telefone, string cnpj, string nomeFantasia)
            : base(nome, endereco, telefone)
        {
            this.Cnpj = cnpj;
            this.NomeFantasia = nomeFantasia;
        }

        public override string ToString()
        {
            return ($"CNPJ: {Cnpj}|Nome Fantasia da Empresa: {NomeFantasia}|Nome: {Nome}|Endereço: {Endereco}|Telefone: {Telefone}");

        }

    }
}
