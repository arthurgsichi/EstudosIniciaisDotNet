using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoCsharp.EstruturasDeControle
{
    internal class UsandoBreak
    {
        public static void Executar()
        {
            Random random = new Random();
            int numero = random.Next(1, 51);

            Console.WriteLine("O número que nós queremos é {0}", numero);

            for( int i = 1; i <= 50; i++)
            {
                Console.WriteLine("{0} é o número que queremos?", i);
                if(i == numero)
                {
                    Console.WriteLine("Sim!");
                    break;
                } else {
                    Console.WriteLine("Não!");                
                }
               
            }
            Console.WriteLine("fim");
        }
    }
}
