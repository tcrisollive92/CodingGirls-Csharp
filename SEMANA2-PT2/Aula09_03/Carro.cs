using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09_Exercicio03
{
    public class Carro : Veiculos
    {
        
        public override void Acelerar()
        {
            Console.WriteLine("Você está abaixo do limite de velocide na rodovia,acelere!");
        }

        public override void Frear()
        {
            Console.WriteLine("Você está acima do limite de velocide na rodovia,reduza!");
        }

        public string TrocarOleo()
        {
            return $"O óleo do carro precisa ser  trocado.";
        }

    }
}
