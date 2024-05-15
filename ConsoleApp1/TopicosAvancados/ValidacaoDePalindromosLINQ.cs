using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoCsharp.TopicosAvancados
{
    internal class ValidacaoDePalindromosLINQ
    {
        public static void Executar()
        {
            Console.WriteLine("Escreva uma frase e eu direi se é um palíndromo ou não!");
            var resposta = Console.ReadLine();

            string[] respostaContrario = resposta.Split(new char[] { ' ', ',', '.', '!', '?', ':', ';', '-', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            
            var reversed = respostaContrario.Reverse().ToList();
           
               //Console.WriteLine($"Frase original:" + string.Join(" ", respostaContrario));
        for(var l = reversed.Count - 1; l >= 0; l--) 
           {
                Console.WriteLine("Desafio imcompleto por incapacidade neorecerebral");
            }

        }
    }
}
//Valide se a frase é um palíndromo, ou seja, se ela é a mesma frase quando lida da esquerda para a direita e da direita para a esquerda, ignorando espaços em branco, pontuações e diferenças entre maiúsculas e minúsculas.
//Exiba uma mensagem indicando se a frase é ou não um palíndromo.