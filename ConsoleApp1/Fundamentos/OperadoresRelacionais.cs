using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoCsharp.Fundamentos
{
    internal class OperadoresRelacionais
    {
        public static void Executar()
        {
            Console.Write("Quanto você tirou em matemática?");
            double.TryParse(Console.ReadLine(), out double nota);
            double notaDaMedia = 8.0;
            Console.WriteLine("Nota inválida? {0}", nota > 10.0);
            Console.WriteLine("Nota válida? {0}", nota < 0.0);
            Console.WriteLine("Perfeito? {0}", nota == 10.0);
            Console.WriteLine("Pode melhorar? {0}", nota != 10.0);
            Console.WriteLine("Passou da média? {0}", nota >= notaDaMedia);
            Console.WriteLine("Recuperação? {0}", nota < notaDaMedia);
            Console.WriteLine("Reprovado? {0}", nota <= 3.0);
        }
    }
}
