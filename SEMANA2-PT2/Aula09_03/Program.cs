using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09_Exercicio03
{
    public class Program
    {
        static void Main(string[] args)
        {
            Moto moto;
            Carro carro;

            Console.WriteLine("Qual o seu veiculo:\n1-Carro\n2-Moto ");
            string resposta=Console.ReadLine();

            if (resposta == "1")
            {
                carro = new Carro();
                Console.WriteLine("Velocidade média na rodovia :");
                double resp=double.Parse(Console.ReadLine());

                if (resp <= 55.0) { carro.Acelerar(); }
                else if(resp>110.0){ carro.Frear(); }
               
                Console.WriteLine(carro.TrocarOleo());
                
            }
            else if(resposta == "2")
            {
                moto = new Moto();
                Console.WriteLine("Velocidade média na rodovia :");
                double resp = double.Parse(Console.ReadLine());

                if (resp <= 45.0) { moto.Acelerar(); }
                else if (resp > 90.0) { moto.Frear(); }
                
                Console.WriteLine(moto.AjustarPneu());

            }




        }
    }
}
