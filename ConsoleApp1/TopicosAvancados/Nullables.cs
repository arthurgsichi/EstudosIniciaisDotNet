using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoCsharp.TopicosAvancados
{
    internal class Nullables
    {
        public static void Executar()
        {
            Nullable<int> num1 = null; // primeira forma de declarar um null ( tbm serve pra bool )
            int? num2 = null; //segundo forma de declarar um null

            if(num1.HasValue) //(num1 != null) 
            {
                Console.WriteLine("Valor de num1 {0}", num1);
            } else { Console.WriteLine("A variável criada era nula."); }

            int valor = num1 ?? 0;
            Console.WriteLine(valor);

            bool? booleana = null;
            bool resultado = booleana.GetValueOrDefault();
            Console.WriteLine(resultado);

            try
            {
                int x = num1.GetValueOrDefault();
                int y = num1.GetValueOrDefault();
                Console.WriteLine(x + y);
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
