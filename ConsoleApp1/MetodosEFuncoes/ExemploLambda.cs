using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoCsharp.MetodosEFuncoes
{
    internal class ExemploLambda
    {
        //Action = não tem retorno em variável // Func = tem retorno em variável
        public static void Executar() {
            Action algoNoConsole = () => { 
                Console.WriteLine("Lambda no C# :D");
            };
            algoNoConsole();

            //nao passa parâmetro e o tipo de retorno em int
            Func<int> jogarDado = () =>
            {
                Random random = new Random();
                return random.Next(1, 7);
            };
            Console.WriteLine(jogarDado());
            
            //passando 1 parâmetros e o tipo de retorno em string 
            Func<int, string> conversorHex = numero => numero.ToString("X");
            Console.WriteLine(conversorHex(1234));

            //passando 3 parâmetros e o tipo de retorno em string 
            Func<int, int, int, string> formatarData = (dia, mes, ano) =>
            string.Format("{0:D2}/{1:D2}/{2:D4}", dia, mes, ano);
            Console.WriteLine(formatarData(30,09,2008));
        }
    }
}
