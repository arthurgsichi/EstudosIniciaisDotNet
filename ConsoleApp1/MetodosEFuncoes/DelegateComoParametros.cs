using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoCsharp.MetodosEFuncoes
{
    internal class DelegateComoParametros
    {
        public delegate int Operacao(int x, int y);

        public static int Soma(int x, int y)
        {
            return x + y;
        }

        //nesse momento o delegate é instanciado como op e usado em parametro
        public static string Calculadora(Operacao op, int x, int y)
        {
            var resultado = op(x, y);
            return "Resultado: " + resultado; 
        }
        public static void Executar()
        {
            Operacao subtracao = (int x, int y) => x - y;
            Console.WriteLine(Calculadora(subtracao, 888, 88));

            Console.WriteLine(Calculadora(Soma, 88, 888));
        }
    }
}
