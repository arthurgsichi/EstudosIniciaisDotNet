using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoCsharp.Fundamentos
{
    internal class OperadoresAritimeticos
    {
        public static void Executar()
        {
            //preço com desconto
            var preço = 888.0;
            var desconto = 0.5;
            var imposto = 88;

            double total = preço + imposto;
            var totalcomdesconto = total - total * imposto;
            Console.WriteLine("E o preço final é: {0}", totalcomdesconto);

            //IMC
            Console.Write("Qual é o seu peso?");
            double.TryParse(Console.ReadLine(), out double peso);
            Console.Write("Qual é a sua altura?");
            double.TryParse(Console.ReadLine(), out double altura);
            double IMC = peso / (altura * altura);
            Console.WriteLine($"IMC é: {IMC}");

            //numero par/impar 
            int par = 88;
            int impar = 87;
            Console.WriteLine("{0}/2 tem resto {1}", par, par % 2);
            Console.WriteLine("{0}/2 tem resto {1}", impar, impar % 2);
            }


        }
    }

