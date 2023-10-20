using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoCsharp.ClassesEMetodos
{
    public class CalculadoraEstatica
    {
        // Pelo fato do método ser static ele nao mais pode ser instanciado e só chamado pela própria classe pois só tem uma cópia
        public static int Multiplicar(int a, int b)
        {
            return a * b;
        }
        //Já esse pode ser instanciado diversas vezes por meio do "new"
        public int Somar(int a, int b)
        {
            return a + b;
        }
    }
    internal class MetodosEstaticos
    {
    public static void Executar()
        {
            var resultado = CalculadoraEstatica.Multiplicar(2, 2);
            Console.WriteLine("Resultado: {0}", resultado);

            CalculadoraEstatica calc = new CalculadoraEstatica();
            Console.WriteLine(calc.Somar(4, 4));
            Console.WriteLine(CalculadoraEstatica.Multiplicar(3, 3));
        }
    }
}
