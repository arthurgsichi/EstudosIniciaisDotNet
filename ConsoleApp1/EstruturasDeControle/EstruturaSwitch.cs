using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoCsharp.EstruturasDeControle
{
    internal class EstruturaSwitch
    {
        public static void Executar()
        {
            Console.WriteLine("Avalie meu atendimento com uma note de 1 até 5: ");
            int.TryParse(Console.ReadLine(), out int nota);

            switch (nota)
            {
                case 0:
                    Console.WriteLine("Péssimo");
                    break;
                case 1:
                case 2:
                    Console.WriteLine("Ruim");
                    break;
                case 3:
                    Console.WriteLine("Regular");
                    break;
                case 4:
                    Console.WriteLine("Bom");
                    break;
                case 5:
                    Console.WriteLine("Muito bom ( vulgo: show de boleta papai )");
                    break;
                default:
                    Console.WriteLine("Nota Inválida.");
                    break;
                    // break: quebra a sentença e pula pra próxima linha de código
            }
            Console.WriteLine("Obrigado por responder! ( vulgo: até a próxima aula hehe)");
        }
        }
}
