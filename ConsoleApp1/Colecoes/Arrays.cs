using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoCsharp.Colecoes
{
    internal class Arrays
    {
        public static void Executar()
        {
            //arrays são sempre homogêneos, fixo e indexados
            //homogêneos: sempre o mesmo tipo de atributo / fixos: mesma quantidade de arrays / indexados: acessados por numeração a partir de 0
            string[] alunos = new string[5];
            alunos[0] = "Arthur";
            alunos[1] = "João Gabs";
            alunos[2] = "Matheus Edu";
            alunos[3] = "Nazário";
            alunos[4] = "Adriano";

            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }
            double somatorio = 0;
            double[] notas = { 6.0, 4.5, 4.5, 6.0, 5.7 };
            
            foreach (var nota in notas)
            {
                somatorio += nota;
            }
            double media = somatorio / notas.Length;
            Console.WriteLine(media);

            char[] letras = { 'A', 'R', 'R', 'A', 'Y', 'S' };
            string palavra = new string(letras);
            Console.WriteLine(palavra);
        }

    }
}
