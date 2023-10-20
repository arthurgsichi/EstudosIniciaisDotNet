using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoCsharp.EstruturasDeControle
{
    internal class EstruturaWhile
    {
        public static void Executar()
        {
            int palpite = 0;
            Random r = new Random();
            
            int numeroSecreto = r.Next(1, 16);
            bool numeroEncontrado = false;
            int tentativasRestantes = 5;
            int tentativas = 0;

            while (tentativasRestantes > 0 && !numeroEncontrado)
            {
                Console.WriteLine("Insira seu palpite: ");
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out palpite);

                tentativas++;
                tentativasRestantes--;

                if (palpite == numeroSecreto)
                {
                    numeroEncontrado = true;
                    var corAnterior = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("Número encontrado em {0} tentativas !", tentativas);
                    Console.BackgroundColor = corAnterior;
                } else if (palpite > numeroSecreto){
                    var corAnterior = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Menor... tente novamente!");
                    Console.WriteLine("Número De tentativas restantes: {0}", tentativasRestantes);
                    Console.BackgroundColor = corAnterior;
                } else{
                    var corAnterior = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Maior... Tente Novamente!");
                    Console.WriteLine("Número De tentativas restantes: {0}", tentativasRestantes);
                    Console.BackgroundColor = corAnterior;
                }
            }
        }
    }
}
