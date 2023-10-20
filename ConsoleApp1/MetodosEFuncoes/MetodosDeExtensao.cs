using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoCsharp.MetodosEFuncoes
{
    public static class ExtensoesInteiras
    {
        public static int Soma(this int num, int outroNumero)
        {
            return num + outroNumero;
        }
        public static double Subtracao(this double num, double outroNumero)
        {
            return num - outroNumero;
        }
    }

    class MetodosDeExtensao
    {
        public static void Executar()
        {
            int numero = 5;
            double numeroReal = 5.5;

            Console.WriteLine(numero.Soma(8));
            Console.WriteLine(numeroReal.Subtracao(8));

            Console.WriteLine(2.Soma(3));
            Console.WriteLine(2.9.Subtracao(28.8));
        }
    }
}
