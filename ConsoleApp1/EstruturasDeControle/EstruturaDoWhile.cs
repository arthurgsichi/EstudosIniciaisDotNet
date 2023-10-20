using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoCsharp.EstruturasDeControle
{
    internal class EstruturaDoWhile
    {
        public static void Executar()
        {
            //o do diferente do while, ele sera executado pelo menos 1 vez no programa, podendo ser mais de uma mas sempre pelo menos 1 vez
            string entrada;
            do{
                Console.WriteLine("Qual seu nome");
                entrada = Console.ReadLine();

                Console.WriteLine("Seja bem vindo(a) {0}", entrada);
                Console.WriteLine("Deseja continuar?(S/N)");
                entrada = Console.ReadLine();

            } while (entrada.ToLower() == "s");
        }
    }
}
