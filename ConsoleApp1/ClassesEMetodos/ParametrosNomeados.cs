using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoCsharp.ClassesEMetodos
{
    internal class ParametrosNomeados
    {
        public static void Formatar(int dia, int mes, int ano)
        {
            Console.WriteLine(" A pessoa mais linda nasceu em {0:D2}/{1:D2}/{2}", dia, mes, ano);
        }
        public static void Executar()
        {
            Formatar(ano: 1983, dia: 5, mes: 3);
        }
    }
}
