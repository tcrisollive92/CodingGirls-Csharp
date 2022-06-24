using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula08_Exercicio03
{

    public abstract class Animal
    {
        public string Nome { get; set; }
        public int Patas { get; set; }
        public string Cor { get; set; }
        public string Ambiente { get; set; }
        public double VelMedia { get; set; }

        public Animal(string nome, int patas, string cor, string ambiente, double velMedia)
        {
            this.Nome = nome;
            this.Patas = patas;
            this.Cor = cor;
            this.Ambiente = ambiente;
            this.VelMedia = velMedia;

        }
        public abstract void Dados();


    }
}
