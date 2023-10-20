using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoCsharp.Fundamentos
{
    internal class ConversoesNumericas
    {
        public static void Executar()
        {
            //conversão de int para double
            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine(quebrado);

            //Conversão de double para int 
            double nota = 8.8;
            int notaTruncada = (int)nota;
            Console.WriteLine("Nota truncada = {0}", notaTruncada);
            //também é necessário deixar explicito a troca de double para int (oque ocasiona perda de informação)

            //forma mais "segura" de receber uma string quando era esperado um int sem dar erro
            Console.Write("Digite um Número: ");
            int.TryParse(Console.ReadLine(), out int numero);
            Console.WriteLine("Resultado: {0}", numero);




        }
    }
}
