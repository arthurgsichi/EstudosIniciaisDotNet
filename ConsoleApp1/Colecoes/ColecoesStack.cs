using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoCsharp.Colecoes
{
    internal class ColecoesStack
    {
        public static void Executar()
        {
            //stack é o contrário da queue, o porque disso? porque o ultimo a entrar é o primeiro a sair
            //já no queue o primeiro a entrar é o primeiro a sair
            var pilha = new Stack();

            pilha.Push(3);
            pilha.Push("AGS");
            pilha.Push(true);
            pilha.Push(3.14f);

            foreach (var item in pilha)
            {
                Console.WriteLine($"{item} ");
            }
            //pega E REMOVE o ultimo valor que está no topo da fila
            Console.WriteLine($"\nPop: {pilha.Pop()}");

            foreach (var item in pilha) {
                Console.WriteLine($"{item} "); 
                    }
            //pega o proximo valor do topo da fila POREM nao remove-o
            Console.WriteLine($"\nPeek: {pilha.Peek()}");
            Console.WriteLine(pilha.Count);
        }
    }
}
