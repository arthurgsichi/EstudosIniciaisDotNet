using cursoCsharp.OO;
using cursoCsharp.TopicosAvancados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoCsharp.TopicosAvancados
{
    internal class FuncSomarAlvo
    {
        public List<int> lista_numeros = [1, 2, 3, 4, 5, 6, 7, 8, 9];
        public int alvo = 10;
        public List<string> paresUnicos = new List<string>();


        public void FuncVerificacaoNumeros()
        {
            for (int i = 0; i < lista_numeros.Count; i++)
            {
                for (int j = 0; j < lista_numeros.Count; j++)
                {
                    if (lista_numeros[i] == lista_numeros[j])
                    {
                        continue;
                    }

                    if (lista_numeros[i] + lista_numeros[j] == alvo)
                    {
                        paresUnicos.Add($"{lista_numeros[i]}+{lista_numeros[j]}={alvo}");
                    }
                }
            }

            Console.WriteLine($"{String.Join("\n", paresUnicos)}");
        }
    }

    internal class SomaNumeroAlvo
    {
        public static void Executar()
        {
            FuncSomarAlvo func = new FuncSomarAlvo();
            func.FuncVerificacaoNumeros();
        }
    }

}


//Todo: Dada uma lista de números inteiros e um valor alvo
//crie uma função que encontre todos os pares únicos de números na lista que somam exatamente ao valor alvo.
// fazer um for dentro de um for, primeiro for com [i] segundo for com j
//if (lista_numeros[i] = lista_numeros[j]) continue
