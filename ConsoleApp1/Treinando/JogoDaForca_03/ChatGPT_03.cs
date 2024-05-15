using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace cursoCsharp.Treinando.JogoDaForca_03
{
    internal class ChatGPT_03
    {


        public static void Executar()
        {
            Console.WriteLine("Bem vindo ao Jogo Da Forca!");
            Console.WriteLine("Você terá 10 tentativas para acertar a palavra secreta acompanhada de uma dica!");
            Console.WriteLine("Se a letra já foi escrita você não poderá repitir e só pode escrever 1 letra por vez!");

            //aqui instancia a classe jogoDaForca onde tem toda a parti lógica e usa o método construtor de minimo de tentativas e máximo de tentativas
            var jogoDaForca = new JogoDaForca(0, 10);
            jogoDaForca.EscolherPalavra(); // aqui usa um método da classe para a escolha randômica das palavras e da dica por meio do instanciamento da classe/método
            jogoDaForca.palavraDescoberta = new char[jogoDaForca.palavra.Length];// aqui passa a propriedade palavra descoberta criando um array de char passando a palavra sorteada

            for (int i = 0; i < jogoDaForca.palavra.Length; i++) // aqui basicamente roda todas as posições do novo char array  e para cada posição coloca um underline
            {
                jogoDaForca.palavraDescoberta[i] = '_';
            }

            while (jogoDaForca.tentativas <= jogoDaForca.chances) //aqui cria um while para definir a lógica de todo o jogo
            {
                Console.WriteLine("\n ============================================================================================ ");
                Console.WriteLine($" A palavra é: {string.Join("", jogoDaForca.palavraDescoberta)} e a dica é: {jogoDaForca.dica}"); //usa join para poder passar o array de char sem dar erro
                Console.WriteLine($" Letras utilizadas: {jogoDaForca.letrasUtilizadas}"); // escreve todas as letras já utilizadas 
                Console.Write(" Insire uma letra: ");

                string letraEscrita = Console.ReadLine();

                if (letraEscrita.Length > 1) // esse if pega oq o usuario passou e valida se é maior do q um, se nao, continua o while
                {
                    Console.WriteLine(" Você digitou mais de um caracter. ");
                    continue;
                }

                if (jogoDaForca.letrasUtilizadas != null && jogoDaForca.letrasUtilizadas.Contains(letraEscrita))
                {
                    Console.WriteLine(" Você já usou essa letra. ");
                    continue;
                }

                jogoDaForca.letrasUtilizadas += letraEscrita; // essa linha pega as letras já utilizadas e usando o "+=" adiciona a ultima letra dada pelo usuário

                if (jogoDaForca.palavra.Contains(letraEscrita)) // se jogo da forca palavra, conter a letra escrita pelo usuario está correto
                {
                    Console.WriteLine("Letra Correta !!!");

                    for (int i = 0; i < jogoDaForca.palavra.Length; i++) // esse for roda jogo da forca inteiro denovo só que agora com um porém
                    {
                        if (jogoDaForca.letrasUtilizadas.Contains(jogoDaForca.palavra[i])) //se alguma letra já utilizada for igual a alguma letra de palavra
                        {
                            jogoDaForca.palavraDescoberta[i] = jogoDaForca.palavra[i]; //então coloca essa letra igual na posição correta da palavra original Ex.: usuario colocou m ( palavra é maça ) ficaria: m___
                        }
                        else // senao
                        {
                            jogoDaForca.palavraDescoberta[i] = '_'; //continuar com underline normal 
                        }
                    }
                }
                else
                {
                    jogoDaForca.tentativas++; // aqui aumenta o número de tentativas 1 vez mais
                    Console.WriteLine("Letra Incorreta, rresto de tentativas: {0}", jogoDaForca.tentativas - jogoDaForca.chances);
                }   // e quando você erra ele diminui as 10 tentativas maximas menos a unica que você tinha

                if (string.Join("", jogoDaForca.palavraDescoberta).Equals(string.Join("", jogoDaForca.palavra), StringComparison.CurrentCultureIgnoreCase))
                {// se o array de string palavra descoberta for igual ao array de string palvra ignorando algum tipo de intervenção por conta de maiusculo ou minusculo
                    Console.WriteLine("sarneou cachorro velho, a palavra era: {0}", jogoDaForca.palavra); //Usando join para fazer a comparação entre 2 arrays sempre
                    break;
                }

                if (jogoDaForca.chances - jogoDaForca.tentativas <= 0)
                {
                    string textoGameOver = "GAME OVER!!!";
                    foreach (var item in textoGameOver.ToCharArray())
                    {
                        Console.Write(item);
                        Thread.Sleep(300);
                    }
                    break;
                }

            }

        }

    }


}

