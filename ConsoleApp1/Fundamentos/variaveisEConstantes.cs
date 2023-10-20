using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoCsharp.Fundamentos
{
    internal class VariaveisEConstantes
    {
        public static void Executar()
        {
            //área da circunferencia
            double raio = 4.5;
            const double PI = 3.14;
            raio = 5.5;
            // PI = 3.111;
            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Área é" + area + 1000);

            //tipos internos!

            int menorValorInt = int.MinValue; // mais usado dos internos!
            Console.WriteLine("Menor int" + menorValorInt);

            bool estaChovendo = true;
            Console.WriteLine("esta chovendo" + estaChovendo);

            byte idade = 45;
            Console.WriteLine("idade" + idade);
        }
    }
}

