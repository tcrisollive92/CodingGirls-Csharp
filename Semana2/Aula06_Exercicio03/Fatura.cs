using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula06_Exercicio03
{
    public class Fatura
    {
        private int NumerodoProduto;
        private string DescricaoProduto =String.Empty;
        private int QuantidadeProduto;
        private double PrecoProduto;


        public Fatura(int numeroProduto,string descricaoProduto,int quantidadeProduto,double precoProduto )
        {
            NumerodoProduto= numeroProduto;
            DescricaoProduto= descricaoProduto;
            QuantidadeProduto= quantidadeProduto;
            PrecoProduto= precoProduto;

            DetalhesdaFatura(); 
        }
        public void DetalhesdaFatura()
        {
            Console.WriteLine($"O número do produto comprado: {Numero}\nDescrição do Produto:{Descricao}\nQuantidade comprada:{Quantidade}\nValor total da fatura: R${TotalaPagar():00.00}");
        }
        public int Numero
        {
            get { return NumerodoProduto; }
            set { NumerodoProduto = value; }
        }
        public string Descricao 
        { 
            get { return this.DescricaoProduto; }
            set { this.DescricaoProduto = value; }
        }
        public int Quantidade 
        { get { return this.QuantidadeProduto; }
          set { this.QuantidadeProduto = value; }
        }
        public double Preco
        {
            get { return this.PrecoProduto; }
            set { PrecoProduto = value; }
        }

        private double TotalaPagar(double total=0.0)
        {
            total = this.QuantidadeProduto * this.PrecoProduto;
            return total;
        }

    }
}
