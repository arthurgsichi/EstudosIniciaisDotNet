using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoCsharp.TopicosAvancados
{
    internal class ValidacaoDeAnagramasLINQ
    {
        public static void Executar()
        {
            Console.WriteLine("Digite a primeira palavra:");
            string palavra1 = Console.ReadLine();

            Console.WriteLine("Digite a segunda palavra:");
            string palavra2 = Console.ReadLine();

            string palavra1Clean = new string(palavra1.ToLower().Where(Char.IsLetter).ToArray());

            string palavra2Clean = new string(palavra2.ToLower().Where(Char.IsLetter).ToArray());

            bool anagramaVerify = string.Concat(palavra1Clean.OrderBy(c => c)) == string.Concat(palavra2Clean.OrderBy(c => c));

            if (anagramaVerify) 
            {
                Console.WriteLine($"As palavras {palavra1} e {palavra2} são anagramas entre si 😎");
            }
            else
            {
                Console.WriteLine($"As palavras {palavra1} e {palavra2} não são anagramas entre si 😥");
            }
        }
    }
}
