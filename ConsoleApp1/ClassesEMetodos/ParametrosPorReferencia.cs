using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoCsharp.ClassesEMetodos
{
    internal class ParametrosPorReferencia
    {
        //quando voce altera um ref você retorna necessariamente uma referência e 
        public static void AlterarRef(ref int numero)
        {
            numero = numero + 1000;
        }
        //out é bem mais usado em códigos grandes e tem o objetivo de poder manipular os dados e ser uma saida de um valor
        public static void AlterarOut(out int numero1, out int numero2)
        {
            numero1 = 0;
            numero2 = 0;
            numero1 = numero1 + 8;
            numero2 = numero2 + 88;
        }
        public static void Executar()
        {
            int a = 8;
            AlterarRef(ref a);
            Console.WriteLine(a);

            AlterarOut(out int b, out int c);
            Console.WriteLine($"{b} {c}");

            //ref é como se fosse uma saída de valor em 2 direções ( por isso é passivo a erros em códigos grandes )
            //já o out é uma saída de valor em apenas uma direção 
        }

    }
}
