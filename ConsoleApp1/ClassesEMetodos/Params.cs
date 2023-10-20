using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoCsharp.ClassesEMetodos
{
    internal class Params
        
    {
        //serve para passar uma lista em um número determinado de itens e pode adicionar uma ação para cada item
        public static void Recepcionar(params string[] pessoas)
        {
            foreach (var p in pessoas)
            {
                Console.WriteLine("Olá {0}", p);
            }
        }
        public static void Executar()
        {
            Recepcionar( "Eu", "dogos", "mamae", "Papai", "basket");
        }
    }
}
