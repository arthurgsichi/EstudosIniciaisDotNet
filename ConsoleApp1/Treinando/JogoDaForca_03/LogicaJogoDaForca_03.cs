using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoCsharp.Treinando.JogoDaForca_03
{
    internal class JogoDaForca
    {
        public string palavra { get; set; }
        public string dica { get; set; }
        public char[] palavraDescoberta { get; set; }
        public int tentativas { get; set; }
        public int chances { get; set; }
        public string letrasUtilizadas { get; set; }

        public JogoDaForca(int tentativas, int chances)
        {
            this.tentativas = tentativas;
            this.chances = chances;
        }

        public void EscolherPalavra()
        {
            string[] palavraSecreta = { "sushi", "macarrao", "strogonoff", "lasanha", "churrasco" };
            string[] dicaFrase = { "Comida japonesa.", "Comida italiana.", "Muito creme e pode ser carne ou frango.", "Massa com muito queijo.", "Pode ser vegetariano mas o melhor mesmo é na brasa." };

            Random rand = new Random();
            int indice = rand.Next(palavraSecreta.Length);
            palavra = palavraSecreta[indice - 1];
            dica = dicaFrase[indice - 1];
        }


    }
}
