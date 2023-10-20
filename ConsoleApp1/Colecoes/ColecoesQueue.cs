using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoCsharp.Colecoes
{
    internal class ColecoesQueue
    {
        public static void Executar()
        {
            var fila = new Queue<string>();

            fila.Enqueue("Arthur");
            fila.Enqueue("Geisiane");
            fila.Enqueue("Renan");

            Console.WriteLine(fila.Peek());
            Console.WriteLine(fila.Count());

            Console.WriteLine(fila.Dequeue());
            Console.WriteLine(fila.Count());

            foreach(var pessoa in fila)
            {
                Console.WriteLine(pessoa);
            }

            var blablabla = new Queue();
            blablabla.Enqueue(3);
            blablabla.Enqueue("blablabla");
            blablabla.Enqueue(true);
            blablabla.Enqueue(8.88);

            Console.WriteLine(blablabla.Contains("blablabla"));




        }
    }
}
