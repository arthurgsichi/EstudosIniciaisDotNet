using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoCsharp.OO
{
    //sealed é o contrario de abstract ou seja, ele é criado para não ser herdade nem reescrito
    sealed class SemFilho
    {
        public double ValorDaFortuna()
        {
            return 1_888_888.88;
        }
    }

    //class SouFilho : SemFilho {

    //}

    class Avo
    {
        public virtual bool HonrarNomeFamilia()
        {
            return true;
        }
    }
    class Pai : Avo
    {
        public override sealed bool HonrarNomeFamilia()
        {
            return true;
        }
    }
    class FilhoCrackudo : Pai
    {
        //public override bool HonrarNomeFamilia()
        public new bool HonrarNomeFamilia()
        {
            return false;
        }
    }

    internal class Sealed
    {
        public static void Executar()
        {
            SemFilho semFilho = new SemFilho();
            Console.WriteLine(semFilho.ValorDaFortuna());

            FilhoCrackudo filho = new FilhoCrackudo();
            Console.WriteLine(filho.HonrarNomeFamilia());
        }
    }
}
