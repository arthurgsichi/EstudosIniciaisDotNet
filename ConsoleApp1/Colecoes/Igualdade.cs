using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoCsharp.Colecoes
{
    internal class Igualdade
    {
        public static void Executar()
        {
            var p1 = new Produto("Caneta", 1.89);
            var p2 = new Produto("Caneta", 1.89);
            //mesmo p2 tendo as mesmas carecteristicas que p1 eles estão em espaçoes diferentes da memoria
            var p3 = p2;
            // já a ultima sentença por ter uma atribuição de valor por referencia estão no mesmo espaço da memoria 
            Console.WriteLine(p1 == p2);
            Console.WriteLine(p3 == p2);

            Console.WriteLine(p1.Equals(p2));
        }



    }
}
