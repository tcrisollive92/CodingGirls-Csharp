using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07_Exercicio04
{
    public class CadastroPet
    {
        public string Nome;
        public string Especie;
        public string Cor;
        public int Idade;
        public string Informacoes;
        public string DadosDono { get; private set; }



        public CadastroPet(string nome,string especie,string cor,int idade,string info,string dadosdono)
        {
            Nome = nome;
            Especie = especie;
            Cor = cor;
            Idade = idade;
            Informacoes = info;
            DadosDono = dadosdono;
        }
       
        public override string ToString()
        {
            return $"Nome do Pet: {Nome}\nEspécie:{Especie}\nCor:{Cor}\nIdade:{Idade}\nInformações adicionais sobre o pet:{Informacoes}\nInformações sobre o dono: {DadosDono}";
               
        }
    }
}
