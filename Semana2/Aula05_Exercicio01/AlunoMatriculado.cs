using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula05_Exercicio01
{
    public class AlunoMatriculado
    {
        public string NomeAluno;
        public string Matricula;
        public float NotaP1, NotaP2, NotaTrab;

        public AlunoMatriculado()
        {
            Cadastro();
        }
        public void  Cadastro()
        {

            Console.Write("Digite a matricula do aluno:");
            Matricula = Console.ReadLine();

            Console.Write("Digite o nome do aluno: ");
            NomeAluno = Console.ReadLine();

            Console.Write("Digite a nota da primeira prova: ");
            NotaP1 = float.Parse(Console.ReadLine());

            Console.Write("Digite a nota da segunda prova: ");
            NotaP2 = float.Parse(Console.ReadLine());

            Console.Write("Digite a nota do trabalho: ");
            NotaTrab = float.Parse(Console.ReadLine());

            float media = Media();
            float pf = MediaFinal();
            string resulte = Resultado();

            Console.WriteLine($"O aluno {NomeAluno} de número de matricula {Matricula} obteve média {Media():0.00},  {resulte}.");

        }
        public float Media()
        {
            float media = (NotaP1 + NotaP2 + NotaTrab) / 3;
            return media;   
        }

        public float MediaFinal()
        {
            if (Media()>0.0 && Media() < 7.0)
            {
                float pf = (10.0f - Media());
                return pf;
             
            }
            else 
            { 
                return Media();
            }
        }
        public string Resultado()
        {
            if (Media() > 0.0 && Media() < 7.0) { return $"ele precisará fazer prova final e tirar {MediaFinal():0.00}"; }
            else { return "foi aprovado com sucesso!"; }
        }
    }
}
