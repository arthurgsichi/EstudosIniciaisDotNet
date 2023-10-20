using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoCsharp.MetodosEFuncoes
{
    //delegate é uma assinatura na qual todos que usarem ela teram de construir as funções com a assinatura
    //da pra usar lambda com o delegate e alem disso é simples e resumida
    delegate double Operacao(double x, double y);

    internal class LambdaDelegate
    {
        public static void Executar()
        {
            Operacao sum = (x, y) => x + y;
            Operacao sub = (x, y) => x - y;
            Operacao multi = (x, y) => x * y;

            Console.WriteLine(sum(8, 8));
            Console.WriteLine(sub(9, 8));
            Console.WriteLine(multi(10, 8));
        }
    }
}
