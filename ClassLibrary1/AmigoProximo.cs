using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public class AmigoProximo
    {
        public readonly SubCelebridades amiga = new SubCelebridades();
        public void MeusAcessos()
        {
            Console.WriteLine("Amiga próxima...");

            Console.WriteLine(amiga.InfoPublica);
            //Console.WriteLine(amiga.CorDoOlho); Só pode ser pego por herança
            Console.WriteLine(amiga.NumeroDoCelular);
            Console.WriteLine(amiga.JeitoDeFalar);
            //Console.WriteLine(amiga.SegredoDeFamília); mesmo sendo do mesmo projeto nao ta herdando 
            // Console.WriteLine(UsaMuitoPhotoshop); private ent n da
        }
    }
}
