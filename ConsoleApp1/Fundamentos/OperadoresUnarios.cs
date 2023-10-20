using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoCsharp.Fundamentos
{
    internal class OperadoresUnarios
    {
        public static void Executar()
        {
            var valorNegativo = -5;
            var numero1 = 8;
            var numero2 = 9;
            var booleano = true;

            Console.WriteLine(-valorNegativo);
            Console.WriteLine(!booleano);

            numero1++;
            Console.WriteLine(numero1);
            // pode usar tanto o "++" "--" no começo ou no final ex: --numero1 / numero1--
            // *OBS:se você colocar antes vai gerar preferencia EX..:
            Console.WriteLine(numero1++ == --numero2);
            Console.WriteLine($"{numero1} {numero2}");
        }
    }
}
