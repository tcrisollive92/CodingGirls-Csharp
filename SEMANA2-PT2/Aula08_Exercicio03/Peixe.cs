using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula08_Exercicio03
{
    public class Peixe : Animal
    {
        public string Caracteristicas { get; set; }
        public Peixe(string nome, int patas, string cor, string ambiente, double velMedia,string carac):base(nome, patas, cor, ambiente, velMedia)   
        {
            this.Caracteristicas = carac;
              
        }
        
        public override void Dados() => Console.WriteLine($"Nome:{Nome}\nNúmero de Patas:{Patas}\nCor:{Cor}\nAmbiente{Ambiente}\nVelocidade Média:{VelMedia}\nCaracteristicas:{Caracteristicas}");

        
    }

}
