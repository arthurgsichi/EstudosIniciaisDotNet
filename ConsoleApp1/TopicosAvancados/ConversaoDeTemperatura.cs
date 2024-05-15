using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoCsharp.TopicosAvancados
{
    internal class ConversaoDeCoisas
    {
        public static void Executar()
        {
            Console.WriteLine("Você quer fazer a conversão de Celsius ou de Altura?");
            var resposta = Console.ReadLine();
            if (resposta.Equals("Celsius", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("Me diga quantos celsius você quer fazer a conversão.");
                int.TryParse(Console.ReadLine(), out int r);
                var ra = r;
                r = (r * 9 / 5) + 32;
                Console.WriteLine($"De {ra} celsius foi pra {r} fahrenheits");
            } 
            else
            {
                Console.WriteLine("me diga quantos metros (ex.: 195) você tem para fazer a conversão para pés ");
                double.TryParse(Console.ReadLine(), out double r);
                var ra = r;
                r = r * 1 / 0.3048;
                Console.WriteLine($"De {ra} metros foi pra {r} pés");
            }
        }
    }
}
