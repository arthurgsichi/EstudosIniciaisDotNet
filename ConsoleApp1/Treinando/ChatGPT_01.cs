using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoCsharp.Treinando
{
    internal class ChatGPT_01
    {
        public static void Executar()
        {
            Console.WriteLine("Digite o primeiro número: ");
            double numero1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            double numero2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o terceiro número: ");
            double numero3 = Convert.ToDouble(Console.ReadLine());

            double total = (numero1 + numero2 + numero3) / 3;

            Console.WriteLine("o resultado da média aritimética dos números é: {0} ", total.ToString());
        }
    }
}



