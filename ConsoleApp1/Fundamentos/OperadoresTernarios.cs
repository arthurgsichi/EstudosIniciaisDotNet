using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoCsharp.Fundamentos
{
    internal class OperadoresTernarios
    {
        public static void Executar()
        {

            var nota = 6.0;
            bool bomComportamento = false;
            string resultado = nota >= 7.0 && bomComportamento ? "Aprovado" : "Reprovado";
            // nesse caso o "?" funciona como um certo tipo de concatenação de consequencia a primeira resposta sendo a true e a segunda a false
            // a resposta que no caso é a "aprovado" / "reprovado" tem que estar de acordo com o tipo da variante
        }
    }
}
