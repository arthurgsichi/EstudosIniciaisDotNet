using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoCsharp.MetodosEFuncoes
{
    
    internal class UsandoDelegate
    {
        delegate double Soma(double a, double b);
        delegate void ImprimirSoma(double a, double b);

        static double MinhaSoma(double x, double y)
        {
            return x + y;
        }
        static void MeuImprimirSoma(double a, double b) => Console.WriteLine(a + b);
        //{
        //    Console.WriteLine(a + b);
        //}
        public static void Executar()
        {
            //é possivel pegar uma função já existente e associar a um delegate...
            //contanto que haja compatibilidade entre as assinaturas ou seja, parâmetros e saída de dados
            Soma op1 = MinhaSoma;
            Console.WriteLine(op1(2, 3));

            ImprimirSoma op2 = MeuImprimirSoma;
            op2(8.4, 4.8);

            //os 2 primeiros são os parametros da assinatura (double, double) e o terceiro é tipo da saida
            Func<double, double, double> op3 = MinhaSoma;
            Console.WriteLine(op3(10.10, 20.20));

            //como MeuImprimirSoma é void ou seja, nao retorna valor algum o certo é usar action
            Action<double, double> op4 = MeuImprimirSoma;
            op4(8.7, 26.9);
        }
    }
}
