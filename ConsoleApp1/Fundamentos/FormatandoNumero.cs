using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

 namespace cursoCsharp.Fundamentos
{
    internal class FormatandoNumero
    {
        public static void Executar()
        {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1"));
            //gera apenas uma casa decimal
            Console.WriteLine(valor.ToString("C"));
            //transforma o número dado em um valor monetario

            CultureInfo cultura = new CultureInfo("en-US");
            Console.WriteLine(valor.ToString("C", cultura));


            int inteiro = 88888888;
            Console.WriteLine(inteiro.ToString("D10"));
            //transforma esse inteiro em um numero de 10 casas decimais "0000000001"
        }
    }
}
