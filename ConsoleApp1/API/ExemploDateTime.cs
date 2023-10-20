using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoCsharp.API
{
    internal class ExemploDateTime
    {
        public static void Executar()
        {
            var dateTime = new DateTime(day: 3, month: 3, year: 1983);

            Console.WriteLine(dateTime.Day);
            Console.WriteLine(dateTime.Month);
            Console.WriteLine(dateTime.Year);

            //sem hora
            var hoje = DateTime.Today;
            Console.WriteLine(hoje);

            //Com hora
            var agora = DateTime.Now;
            Console.WriteLine(agora);
            Console.WriteLine("Hora: " + agora.Hour,"hrs");
            Console.WriteLine("Minutos "+ agora.Minute,"mnts");

            var amanha = agora.AddDays(1);
            Console.WriteLine(amanha);

            var ontem = agora.AddDays(-1);
            Console.WriteLine(ontem.Hour);

            Console.WriteLine(agora.ToString("dd"));
            Console.WriteLine(agora.ToString("d"));
            Console.WriteLine(agora.ToString("D"));
            Console.WriteLine(agora.ToString("G"));
            Console.WriteLine(agora.ToString("F"));
            Console.WriteLine(agora.ToString("dd/MM/yyyy, HH:mm:ss"));

        }
    }
}
