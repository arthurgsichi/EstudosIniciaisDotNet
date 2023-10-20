using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public  class SubCelebridades
    {
        // Todos
        public string InfoPublica = "Tenho um instagram";

        // Herança
        protected string CorDoOlho = "Verdes";

        // Mesmo Projeto (assembly)
        internal string NumeroDoCelular = "+55 21 98015-7110";

        //Herança  OU  Mesmo Projeto 
        protected internal string JeitoDeFalar = "Uso muitas gírias";

        //Mesma class ou herança no mesmo projeto
        private protected string SegredoDeFamília = "blabla";

        //Private padrão
        bool UsaMuitoPhotoshop = true;

        public void MeusAcessos()
        {
            Console.WriteLine("SubCelebridade...");
            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            Console.WriteLine(NumeroDoCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoDeFamília);
            Console.WriteLine(UsaMuitoPhotoshop);
        }
    }
}
