using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoCsharp.TopicosAvancados
{
    internal class Dynamic
    {
        public static void Executar()
        {
            dynamic meuObjeto = "teste";
            meuObjeto = 3;

            meuObjeto++;
            Console.WriteLine(meuObjeto);

            dynamic aluno = new System.Dynamic.ExpandoObject();
            aluno.nome = "Arthur Guzzo SIchi";
            aluno.idadix = 15;
            aluno.alturex = 1.93;
            Console.WriteLine($"{aluno.nome} / {aluno.idadix} / {aluno.alturex}");
        }
    }
}
