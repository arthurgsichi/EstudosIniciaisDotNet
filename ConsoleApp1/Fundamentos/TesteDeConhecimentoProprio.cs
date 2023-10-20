using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoCsharp.Fundamentos
{
    internal class TesteDeConhecimentoProprio
    {
        public static void Executar()
        {
            /* precisa fazer um trabalho quinta e terça, se ele completar ambos aábado ele vai comprar uma tv de 50 polegadas, se só fizer um dos 2 ele vai comprar uma de 35, em ambas situações ele vai tomar sorvete com a familia
            como eu fiz:
            Console.WriteLine("Você fez o trabalho de terça, quinta ou ambos?");
            string resposta = Console.ReadLine();
            if (resposta == "terça")
            {
                Console.WriteLine("Então você pode comprar uma TV de 35 polegadas e tomar um sorvete !");
            }
            else if (resposta == "quinta")
            {
                Console.WriteLine("Então você pode comprar uma TV de 35 polegadas e tomar um sorvete !");
            }
            else if (resposta == "ambos")
            {
                Console.WriteLine("Então você pode comprar uma TV de 50 polegadas e tomar um sorvete !");
            }
             como o professor fez:  */
            var executarTrabalho1 = true;
            var executarTrabalho2 = false;

            // AND: precisa que AMBOS sejam verdadeiros para dar um resultado verdadeiro
            bool comprouTv50 = executarTrabalho1 && executarTrabalho2;
            Console.WriteLine("Comprou Tv 50 polegadas? {0}", comprouTv50);

            // OU: Precisa que uma ou outra seja verdade
            var comprouSorvete = executarTrabalho1 || executarTrabalho2;
            Console.WriteLine("Comprou sorvete? {0}", comprouSorvete);

            // OU exclusivo: precisa q alguma das 2 seja necessariamente verdadeira
            var comprouTv35 = executarTrabalho1 ^ executarTrabalho2;
            Console.WriteLine("Comprou Tv 50 polegadas? {0}");

            //Negação Lógica: Inverte o resultado da var comprouSorvete
            Console.WriteLine("Mais saudável? {0}", !comprouSorvete);
            
        }
    }
}
