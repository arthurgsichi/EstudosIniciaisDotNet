using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoCsharp.Fundamentos
{
    internal class interpolação
    {
        public static void Executar()
        {
            string nome = "Qiyana";
            string ea = "rainha de ichital";
            int preço = 6400;
            Console.WriteLine("A personagem" + nome + ("ela é conhecida como ") + ea + ("e o preço da mesma é ") + preço);
            Console.WriteLine("A {0} é conhecida como {1} e pode ser adiquirida por {2}", nome, ea, preço);


        }

    }
}
