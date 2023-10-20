using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoCsharp.EstruturasDeControle
{
    internal class EstruturaForEach
    {
        public static void Executar()
        {
            var palavra = "Bíblia";

            foreach (var letra in palavra)
            {
                Console.WriteLine(letra);

            }

            var alunos = new string[] { "Ana", "Bia", "Carlos" };

            foreach (string aluno in alunos){
                Console.WriteLine(aluno);
            }

        }
    }
    }
