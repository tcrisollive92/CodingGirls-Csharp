using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula9_Exercicio05
{
    public abstract class Cliente
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }

        public Cliente(string nome, string endereco, string telefone)
        {
            this.Nome = nome;
            this.Endereco = endereco;
            this.Telefone = telefone;
        }

        public abstract string ToString();



    }


}
