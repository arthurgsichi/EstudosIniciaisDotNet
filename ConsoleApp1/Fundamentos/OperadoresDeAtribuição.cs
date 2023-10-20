using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoCsharp.Fundamentos
{
    internal class OperadoresDeAtribuição
    {
        public static void Executar()
        {
            //exemplos de variáveis por valor:

            int num1 = 4;
            num1 = 8; // subistitui o antigo valor de num1
            num1 += 10; // num1 = num1 + 10
            num1 -= 3; // num1 = num1 - 3
            num1 *= 5; // num1 = num1 * 5
            num1 /= 2; // num1 = num1 / 2

            Console.WriteLine(num1);

            int a = 8;
            int b = a;

            a++; // a = a + 1 
            b--; // b = b - 1

            Console.WriteLine($"{a} {b}");

            //Exemplo de variável por referência

            dynamic c = new System.Dynamic.ExpandoObject();
            c.nome = "João";

            dynamic d = c;
            d.nome = "Maria";

            Console.WriteLine(c.nome);
// mesmo o antigo valor de c.nome ser joão ele se torna maria por conta de c.nome e d.nome estarem ocupando o mesmo espaço de memória
        }
    }
}
