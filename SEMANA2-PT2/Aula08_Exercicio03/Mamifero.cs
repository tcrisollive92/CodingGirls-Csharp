using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula08_Exercicio03
{
    public class Mamifero : Animal
    {
        public string Alimento { get; set; }
        public Mamifero(string nome, int patas, string cor, string ambiente, double velMedia, string alimento) : base(nome, patas, cor, ambiente, velMedia)
        {
            this.Alimento = alimento; 
        }
        public override void Dados() => Console.WriteLine($"Nome:{Nome}\nNúmero de Patas:{Patas}\nCor:{Cor}\nAmbiente{Ambiente}\nVelocidade Média:{VelMedia}\nAlimento:{Alimento}");
        
    }
    
}
