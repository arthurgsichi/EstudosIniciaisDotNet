using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoCsharp.Fundamentos
{
    internal class NotacaoPonto
    {
        public static void Executar()
        {
            string saudacao = "Coe ".ToUpper().Insert(3, "World!").Replace("World", "Mundão!");
            Console.WriteLine(saudacao);

           
            Console.WriteLine("teste Length".Length);

            string TesteLengthComNavegacaoSegura = null;
            Console.WriteLine(TesteLengthComNavegacaoSegura?.Length);
        }
    }
}
