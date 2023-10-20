using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace cursoCsharp.Fundamentos
{
    internal class LendoDados
    {
        public static void Executar()
        {
            Console.Write("Qual seu nome?");
            string nome = Console.ReadLine();
            //Console.ReadLine literalmente read a line kkk
            Console.Write("Quantos anos tens?");
            int idade = int.Parse(Console.ReadLine());
            //o "Parse" transforma por exemplo um "15"; em 15;
            Console.Write("Quanto quer ganhar logo quando começar ?");
            double salario = double.Parse(Console.ReadLine(),
            CultureInfo.InvariantCulture);
            //o CultureInfo faz com que o "." seja universal independente da região

            Console.WriteLine($"{nome} {idade} R${salario}");
        }
    }
}
