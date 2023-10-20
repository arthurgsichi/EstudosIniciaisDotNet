using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoCsharp.EstruturasDeControle
{
    internal class EstruturaIfElseElseIf
    {
        public static void Executar()
        {
            Console.WriteLine("Nota do aluno: ");

            string entrada = Console.ReadLine();
            double.TryParse(entrada, out double nota);

            if (nota >= 9.0){
                Console.WriteLine("Lançou a braba");
            } else if(nota >= 7.0){
                Console.WriteLine("Passou, medíocre");
            } else if(nota >= 5.0){
                Console.WriteLine("Recuperação");
            } else { 
                Console.WriteLine("Reprovou kkkkkkk"); 
            }
        }
    }
}
