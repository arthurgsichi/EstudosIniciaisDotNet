using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Encapsulamento;

namespace cursoCsharp.OO
{

    public class Encapsulamento
    {
        public static void Executar()
        {
            SubCelebridades sub = new SubCelebridades();
            sub.MeusAcessos();

            new FilhoReconhecido().MeusAcessos();
            new AmigoProximo().MeusAcessos();

            new FilhoNaoReconhecido().MeusAcessos();
            new AmigoDestante().MeusAcessos();
        }
    }

    public class AmigoDestante
    {
        public readonly SubCelebridades amiga = new SubCelebridades();
        public void MeusAcessos()
        {
            Console.WriteLine("Amiga distante...");

            Console.WriteLine(amiga.InfoPublica);
            //Console.WriteLine(amiga.CorDoOlho); 
            //Console.WriteLine(amiga.NumeroDoCelular);
            // Console.WriteLine(amiga.JeitoDeFalar); 
            //Console.WriteLine(amiga.SegredoDeFamília); 
            // Console.WriteLine(UsaMuitoPhotoshop); 
        }
    }

    public class FilhoNaoReconhecido : SubCelebridades
    {
        public new void MeusAcessos()
        {
            Console.WriteLine("FilhoNãoReconhecido...");
            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            //Console.WriteLine(NumeroDoCelular);
            Console.WriteLine(JeitoDeFalar);
            //Console.WriteLine(SegredoDeFamília);
            //Console.WriteLine(UsaMuitoPhotoshop); 
        }
    }
}
