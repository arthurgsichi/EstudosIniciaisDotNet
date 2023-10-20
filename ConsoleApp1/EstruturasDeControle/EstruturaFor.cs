using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoCsharp.EstruturasDeControle
{
    internal class EstruturaFor
    {
        public static void Executar()
        {
            double somatorio = 0;
            string entrada;

            Console.WriteLine("Informe a quantida de alunos na turma: ");
            entrada = Console.ReadLine();
            int.TryParse(entrada, out int tamanhoTurma);

            for (int i = 1; i <= tamanhoTurma; i++) { 
          
                Console.WriteLine("Informe a nota do aluno {0}", i);
                entrada = Console.ReadLine();
                double.TryParse(entrada, out double notaAtual);

                somatorio += notaAtual;
            } 
            double media = tamanhoTurma > 0 ? somatorio / tamanhoTurma : 0;
            Console.WriteLine("Media da turma: {0}", media);
        }
    }
}
