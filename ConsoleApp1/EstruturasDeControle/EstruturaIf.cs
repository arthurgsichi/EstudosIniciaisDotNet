using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoCsharp.EstruturasDeControle
{
    internal class EstruturaIf
    {
        public static void Executar()
        {
            bool bomComportamento = false;
            string entrada;

            Console.WriteLine("Digite a nota do aluno");
            entrada = Console.ReadLine();
            double.TryParse(entrada, out double nota);

            Console.WriteLine("Possui bom comportamento? (S/N):");
            entrada = Console.ReadLine();

            bomComportamento = entrada.ToLower() == "s";

            if (nota >= 9.0 && bomComportamento)
            {
                Console.WriteLine("tu é brabao parabéns");
            }
            else
            {
                Console.WriteLine("Tu é mediucre");
            }

        }
    }
}
