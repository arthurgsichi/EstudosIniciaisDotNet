using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace cursoCsharp.TopicosAvancados
{
    internal class EncontrandoNumerosPerdidosLINQ
    {
        public static void Executar()
        {
            int[] numerosOriginais = { 1, 2, 4, 6, 7, 10 };

            var menorNum = numerosOriginais.Min();
            var maiorNum = numerosOriginais.Max();

            var sequenciaCompleta = Enumerable.Range(menorNum, maiorNum - menorNum + 1);
            
            var numerosFaltando = sequenciaCompleta.Except(numerosOriginais);

            Console.WriteLine("números originais: " + string.Join(", ", numerosOriginais) + "");

            Console.WriteLine("números que estavam faltando: " + string.Join(", ", numerosFaltando) + "");
        }
    }
}
//Primeiro, encontramos o menor e o maior número na sequência original usando os métodos Min() e Max() do LINQ.
//Em seguida, geramos uma sequência completa de números de menor a maior utilizando Enumerable.Range().
//Por fim, encontramos os números ausentes na sequência original usando o método Except(), que retorna os elementos da primeira sequência que não estão presentes na segunda sequência.