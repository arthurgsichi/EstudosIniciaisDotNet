using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoCsharp.TopicosAvancados
{
    internal class PropStr
    {

        public string texto {  get; set; }
        public void StrVerify()
        {
            var palavras = texto.Split(" ");

            for (int i = 0; i < palavras.Length; i++)
            {
               Console.WriteLine($" {String.Join(" ", palavras[i])} = {palavras[i].Length} letras");
            }
            
            Console.WriteLine($"\nE a frase final tem um total de {texto.Length} letras!");
        }

    }

    internal class StringSplit
    {
        public static void Executar()
        {
            PropStr prop = new PropStr();
            Console.WriteLine("Escreva uma frase separando cada palavra por espaço.\n");
            prop.texto = Console.ReadLine();
            Console.WriteLine("\n");
            prop.StrVerify();
        }
    }
}
//TODO:Crie uma função em C# que receba uma string representando um texto e retorne um dicionário contendo a contagem de cada palavra no texto.
//Ignore maiúsculas e minúsculas, e remova pontuações ao considerar as palavras.
