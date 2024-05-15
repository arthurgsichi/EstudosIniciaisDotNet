using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace cursoCsharp.Treinando
{
    internal class ChatGPT_02
    {
        public static void Executar()
        {
            Console.WriteLine("Verificação de possíveis palíndromos..:D");
            Console.Write("Insire uma palavra:");
            string palavra = Console.ReadLine();

            bool palindromo = palavra == InverterPalavra(palavra);

            if (palindromo == true)
            {
                Console.WriteLine("A palavra {0} é um palíndromo! :D", palavra);
            }
            else
            {
                Console.WriteLine("A palavra {0} não é um palíndromo! :C", palavra);
            }

        }
        static string InverterPalavra(string palavra)
        {
            char[] letrinhasDaArray = palavra.ToCharArray();
            Array.Reverse(letrinhasDaArray);
            return new string(letrinhasDaArray);
        }
    }
    }

