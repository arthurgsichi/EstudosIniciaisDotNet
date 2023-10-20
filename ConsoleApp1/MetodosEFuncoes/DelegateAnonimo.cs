using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoCsharp.MetodosEFuncoes
{
    //usando o delegate desse jeito você pode usar a assinatura dele de forma anônima em uma sentença ação de um código 
    internal class DelegateAnonimo
    {
        delegate string StringOperacao(string s);
        public static void Executar(){
            StringOperacao inverter = delegate (string s)
            {
                char[] charArray = s.ToCharArray();
                Array.Reverse(charArray);
                return new string(charArray);
            };
            Console.WriteLine(inverter("C# é maneiro mano :D"));
        }
    }
}
