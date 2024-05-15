using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoCsharp.TopicosAvancados
{

    internal class NumerosParesComLinq
    {
        public static void Executar()
        {
            List<int> numerosTOtais = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var numerosPares = numerosTOtais.Where(num => num % 2 == 0);

            Console.WriteLine("Lista original: [" + string.Join(", ", numerosTOtais) + "]");
            Console.WriteLine("Números pares: [" + string.Join(", ", numerosPares) + "]");
        }
}
} 
