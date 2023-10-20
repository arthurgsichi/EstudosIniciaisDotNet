using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public class FilhoReconhecido : SubCelebridades
    {
        public new void MeusAcessos()
        {
            Console.WriteLine("FilhoReconhecido...");
            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            Console.WriteLine(NumeroDoCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoDeFamília); 
            //Console.WriteLine(UsaMuitoPhotoshop);  Não posso acessar esse atributo por que ele é only private
        }
    }
}
