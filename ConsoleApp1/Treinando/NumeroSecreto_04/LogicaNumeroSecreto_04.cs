using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoCsharp.Treinando.NumeroSecreto_04
{
    public class LogicaNumeroSecreto_04
    {
        public int numeroEscolhido { get; set; }

        public int palpite { get; set; }
        public List<int> numerosUtilizados { get; set; }
        public int tentativas { get; set; }
        public int chances { get; set; }

        public LogicaNumeroSecreto_04(int tentativas, int chances)
        {
            this.tentativas = tentativas;
            this.chances = chances;
            numerosUtilizados = new List<int>();
        }
    }
}
//Gere um número aleatório entre 1 e 100 para ser a resposta que o jogador precisa adivinhar.

//Permita que o jogador insira palpites para adivinhar o número.

//Forneça dicas ao jogador se o palpite está muito alto, muito baixo ou correto.

//Limite o número de tentativas a, por exemplo, 10.

//Exiba uma mensagem indicando se o jogador ganhou (adivinhou o número) ou perdeu (esgotou todas as tentativas).
