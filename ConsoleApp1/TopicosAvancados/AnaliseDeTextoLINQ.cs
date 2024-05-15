using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoCsharp.TopicosAvancados
{
    internal class AnaliseDeTextoLINQ
    {
        public static void Executar()
        {
            Console.WriteLine("Escreva um texto, separando cada palavra por espaço !");
            var frase = Console.ReadLine();

            string[] palavras = frase.Split(new char[] { ' ', ',', '.', '!', '?', ':', ';', '-', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);


            int totalwords = palavras.Length;

            int totaletras = frase.Length;

            var quantasvezespalavraapareceu = palavras.GroupBy(palavra => palavra.ToLower())
                .Select(grupo => new { Palavra = grupo.Key, Ocorrencias = grupo.Count() })
                .OrderBy(ocorrencias => ocorrencias.Palavra);

            Console.WriteLine("\nEstatísticas do Texto:");
            Console.WriteLine($"Número total de palavras: {totalwords}");
            Console.WriteLine($"Número total de caracteres: {totaletras}");
            Console.WriteLine("Ocorrências de palavras únicas:");
            foreach (var ocorrencia in quantasvezespalavraapareceu)
            {
                Console.WriteLine($"- {ocorrencia.Palavra}: {ocorrencia.Ocorrencias}");
            }
        }
    }
}
