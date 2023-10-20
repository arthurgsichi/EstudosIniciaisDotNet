using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoCsharp.ClassesEMetodos
{
    internal class StructVSClass
    {
        public struct SPonto
        {
            public int X;
            public int Y;
        }
        public class CPonto
        {
            public int X;
            public int Y;
        }

        public static void Executar()
        {
            SPonto ponto1 = new SPonto {X = 8, Y = 4};
            SPonto copiaPonto1 = ponto1; // Atribuição por VALOR! (mesmo alterando o valor de ponto 1, copiaPonto1 ira continuar com o mesmo valor) 
            ponto1.X = 88;

            Console.WriteLine("Cópia Ponto1 X: {0}", copiaPonto1.X);
            Console.WriteLine("Ponto1 X: {0}", ponto1.X);

            CPonto ponto2 = new CPonto { X = 16, Y = 8 };
            CPonto copiaPonto2 = ponto2; //Atribuição por REFERENCIA! (mesmo atribuindo um valor ao copiapont2 quando muda o valor do pont1 o outro muda junto) 
            ponto2.X = 88;

            Console.WriteLine("Cópia Ponto2 X: {0}", copiaPonto2.X);
            Console.WriteLine("Ponto2 X: {0}", ponto2.X);
        }
    }
}
