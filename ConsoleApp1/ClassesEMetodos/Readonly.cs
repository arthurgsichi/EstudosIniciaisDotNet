using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoCsharp.ClassesEMetodos
{

    internal class Readonly
    {
        public class Cliente
        {
            public string Nome;
            readonly DateTime Nascimento;
            //readonly = atribui um valor imutável (constante) durante a execução do código
            //nessa sentença não seria possível utilizar o "const" pois o valor ...
            //... deve ser atribuido antes da execução quando se trata do "const"
            public Cliente(String nome, DateTime nascimento)
            {
                Nome = nome;
                Nascimento = nascimento;
            }
            public string GetDataDeNascimento()
            {
                return String.Format("{0}/{1}/{2}", Nascimento.Day, Nascimento.Date, Nascimento.Year);
            }
        }
        public static void Executar()
        {
            var novoCliente = new Cliente("Ana Silva", new DateTime(1987, 5, 22));

            Console.WriteLine(novoCliente.Nome);
            Console.WriteLine(novoCliente.GetDataDeNascimento);
        }
    }
}
