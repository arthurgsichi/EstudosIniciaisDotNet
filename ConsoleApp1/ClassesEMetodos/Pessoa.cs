using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoCsharp.ClassesEMetodos
{
    internal class Pessoa
    {
        //Tipo
        public string Nome;
        public int Idade;

        //Comportamento
        public string Apresentar()
        {
            return string.Format($"Olá, eu me chamo {Nome} e tenho {Idade} anos.");

        }
        //Comportamento
        public void ApresentarNoConsole()
        {
            Console.WriteLine(Apresentar());
        }
        //Possível utilização do tipo de método no qual não entra nem sai dado
        public void Zerar()
        {
            Nome = " ";
            Idade = 0;

        }
    }
}
