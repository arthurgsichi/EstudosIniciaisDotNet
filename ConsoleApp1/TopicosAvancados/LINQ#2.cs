using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoCsharp.TopicosAvancados
{
    internal class LINQ_2
    {
        public static void Executar()
        {
            var alunos = new List<Aluno>()
            {
                new Aluno() {Nome = "Arthur", Idade = 15, Nota = 8.4},
                new Aluno() {Nome = "Evelyn", Idade = 14, Nota = 9.4},
                new Aluno() {Nome = "JG", Idade = 14, Nota = 7.5},
                new Aluno() {Nome = "Nazário", Idade = 14, Nota = 9.2},
                new Aluno() {Nome = "Matheus", Idade = 12, Nota = 10.0},
                new Aluno() {Nome = "Arthur", Idade = 35, Nota = 6.8},
                new Aluno() {Nome = "Adriano", Idade = 14, Nota = 7.2}
            };
            //procura um unico elemento na lista e joga os atributos desse elemento na var evelyn
            var evelyn = alunos.Single(aluno => aluno.Nome.Equals("Evelyn"));
            Console.WriteLine($"{evelyn.Nome} {evelyn.Nota}");

            //procura um UNICO elemento da lista e se nao acha joga pro null
            var kathy = alunos.SingleOrDefault(a => a.Nome.Equals("Kathy"));
            if (kathy == null) { Console.WriteLine("Kathy não existe ?!?!?!"); }

            //primeiro elemento que possa ser encontrado na lista de acordo com as condições passadas
            var arthur = alunos.First(a => a.Nome.Equals("Arthur"));
            Console.WriteLine(arthur.Nota);

            //primeiro elemento que segue as condições ou valor padrao do bool é null
            var sicrano = alunos.FirstOrDefault(aluno => aluno.Nota.Equals("Sicrano"));
            if(sicrano == null) { Console.WriteLine("Aluno Inexistente!"); }

            //ultimo elemento que segue as condições ou valor padrao do bool é null
            var outroArthur = alunos.LastOrDefault(aluno => aluno.Nome.Equals("Arthur"));
            Console.WriteLine(outroArthur.Nota);

            //pula 1 e pega os proximos 4 nomes
            var exemploSkip = alunos.Skip(1).Take(4);
            foreach (var item in exemploSkip)
            {
                Console.WriteLine(item.Nome);
            }

            //todos os métodos abaixos sao obvios só ler o nome 
            var maiorNota = alunos.Max(aluno => aluno.Nota);
            Console.WriteLine(maiorNota);

            var menorNota = alunos.Min(aluno => aluno.Nota);
            Console.WriteLine(menorNota);

            var somatorioNotas = alunos.Sum(aluno => aluno.Nota);
            Console.WriteLine(somatorioNotas);

            var mediaNotas = alunos.Average(aluno => aluno.Nota);
            Console.WriteLine(mediaNotas);
        }
    }
}
