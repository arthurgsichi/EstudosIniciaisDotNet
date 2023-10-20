using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoCsharp.OO
{
    //a interface é como se fosse um contrato que a partir do momento que voce herda dela voce é obrigado implementar...
    //o método e seus parâmetros contidos nele (uma classe pode ter mais de uma interface e uma interface pode...
    //herdar de outras interfaces.
    interface OperacaoBinaria
    {
        int Operacao(int a, int b);
    }
    class Soma : OperacaoBinaria
    {
        public int Operacao(int a, int b)
        {
            return a + b;
        }
    }
    class Subtracao : OperacaoBinaria
    {
        public int Operacao(int a, int b)
        {
            return a - b;
        }
    }
    class Multiplicacao : OperacaoBinaria
    {
        public int Operacao(int a, int b)
        {
            return a * b;
        }
    }
    class Calculadora
    {
        List<OperacaoBinaria> operacoes = new List<OperacaoBinaria>
        {
            new Soma(),
            new Subtracao(),
            new Multiplicacao()
        };
    
    public string ExecutarOperacoes(int a, int b)
    {
        string resultado = "";

        foreach (var op in operacoes)
        {
            resultado += $"Usando {op.GetType().Name} = {op.Operacao(a, b)}\n";
        }
        return resultado;
    }
 }


    internal class Interface
    {
        public static void Executar()
        {
            var calc = new Calculadora();
            var resultado = calc.ExecutarOperacoes(88, 8);
            Console.WriteLine(resultado);
        }
    }
}
