using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoCsharp.Treinando.NumeroSecreto_04.NumeroSecreto_04
{
    internal class ChatGPT_04
    {
        public static void Executar()
        {
            LogicaNumeroSecreto_04 secretNumba = new LogicaNumeroSecreto_04(0, 10);
            Random random = new Random();
            secretNumba.numeroEscolhido = random.Next(1, 101);

            Console.WriteLine("Bem vindo ao jogo de adivinhações!");
            Console.WriteLine("Você tem até 10 chances para acertar um número de 0 a 100");

            while (secretNumba.tentativas <= secretNumba.chances)
            {
                Console.WriteLine("Agora, chute um número: ");
                secretNumba.palpite = Convert.ToInt32(Console.ReadLine());



                if (secretNumba.numerosUtilizados != null && secretNumba.numerosUtilizados.Any(a => a == secretNumba.palpite))
                {
                    Console.WriteLine(" Você já usou esse número. ");
                    continue;
                }
                secretNumba.numerosUtilizados.Add(secretNumba.palpite);
                if (secretNumba.palpite == secretNumba.numeroEscolhido)
                {
                    Console.WriteLine("Boa, você ganhou!");
                    break;
                }
                else if (secretNumba.palpite < secretNumba.numeroEscolhido)
                {
                    secretNumba.tentativas++;
                    Console.WriteLine("muito baixo, tente um número um pouco mais alto! (tentativas restantes: {0}", secretNumba.chances - secretNumba.tentativas);
                }
                else
                {
                    secretNumba.tentativas++;
                    Console.WriteLine("muito alto, tente um número um pouco mais baixo! (tentativas restantes: {0}", secretNumba.chances - secretNumba.tentativas);
                }
                if (secretNumba.chances - secretNumba.tentativas <= 0)
                {
                    Console.WriteLine("A número era: {0}", secretNumba.numeroEscolhido);
                    string textoGameOver = "GAME OVER!!!";
                    foreach (var item in textoGameOver.ToCharArray())
                    {
                        Console.Write(item);
                        Thread.Sleep(500);
                    }

                    break;
                }

            }

        }
    }
}

