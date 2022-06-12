using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1_Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3-Elabore um programa que mostre na tela uma letra de música que você gosta, o compositor e o gênero musical em linhas separadas.

            string nomemusica = "Come Alive";
            string letra = @"Seems like only yesterday
Life belonged to runaways
Nothin' here to see
No looking back
Every sound monotone
Every color monochrome
Light began to fade
Into the black

Such a simple animal
Sterilized with alcohol
I could hardly
Feel me anymore

Desperate and meaningless
All filled up with emptiness
Felt like everything
Was said and done

I lay there in the dark
And I close my eyes
You saved me the day
You came alive

Still, I tried to find my way
Spinnin' hours into days
Burnin' like a flame
Behind my eyes

Drown it out
Drink it in
Crown the king of sufferin'
Prisoner, slave to the disguise

Disappear the only thing
Bittersweet surrenderin'
Knew that it was time
To say goodbye

And I lay there in the dark
And I close my eyes
You saved me the day
You came alive
No reason left
Me to survive
You saved me
The day you came alive

Come alive
Come alive
Come alive
Come alive
Come alive
Come alive
Come alive
Come alive
Come alive
Come alive
Come alive
Come alive
Come alive
Come alive
Come alive
Come alive

I lay there in the dark
And I close my eyes
You saved me the day
You came alive

Come alive
Come alive
Come alive
Come alive
Come alive
Come alive
Come alive
Come alive
Come alive
Come alive
Come alive
Come alive
Come alive
Come alive
Come alive

Nothin' more to give
I can finally live
Come alive
Your life into me
I can finally breathe
Come alive

I lay me down in the dark (come alive, come alive, come alive)
Open my eyes (come alive, come alive, come alive, come alive, come alive)
You saved me (come alive, come alive, come alive, come alive)
The day you came alive (come alive, come alive, come alive, come alive)
(come alive, come alive)

Come alive
Come alive
Come alive
Come alive
Come alive
Come alive
Come alive
Come alive
Come alive
Come alive
Come alive";

            string compositor = "David Eric Grohl e Taylor Hawkins";
            string genero = "Rock Alternativo";

            Console.WriteLine($"Você conhece essa letra?");
            Console.WriteLine($"\n{ letra}");
            Console.WriteLine("");
            Console.WriteLine($"Essa música se chama {nomemusica} e foi composta por {compositor},\nela se encaixa bem no gênero {genero}");
        }
    }
}
