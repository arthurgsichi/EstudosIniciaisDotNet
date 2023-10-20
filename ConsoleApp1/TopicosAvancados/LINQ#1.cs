using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoCsharp.TopicosAvancados
{
    public class Aluno
    {
        public string Nome;
        public int Idade;
        public double Nota;

    }

    internal class LINQ_1
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
            Console.WriteLine("-- Aprovados --");
            var aprovados = alunos.Where(a => a.Nota >= 7).OrderBy(a => a.Nome).ToList();
            //where filtra a lista fazendo com q n precise escrever outra lista e organizando tbm
            foreach (var aluno in aprovados)
            {
                Console.WriteLine(aluno.Nome);
            }

            Console.WriteLine("-- Chamada --");
            var chamada = alunos.OrderBy(a => a.Nome).Select(a => a.Nome).ToList(); 
            //OrderBy ordena a lista com algum parâmetro em específico 
            foreach (var aluno in chamada)
            {
                Console.WriteLine(aluno); //nao preciso colocar o .Nome pois já ordei só por nome
            }

            Console.WriteLine("-- Aprovados (Por Idade) --"); //nesse exemplo irei usar uma sintaxe parecido com SQL
            var alunosAprovados =
                from aluno in alunos
                where aluno.Nota >= 7
                orderby aluno.Idade
                select aluno.Nome;
            //essa sintaxe é bem mais lógica e eu achei mais facil o entendimento 
            foreach (var aluno in alunosAprovados)
            {
                Console.WriteLine(aluno);
            }

        }
    }
}
