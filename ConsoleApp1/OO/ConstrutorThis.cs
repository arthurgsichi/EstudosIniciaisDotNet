using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoCsharp.OO
{
    public class Animal
    {
        public string Nome { get; set; }
        public Animal(string nome)
        {
            Nome = nome;
        }

    }
    public class Cachorro : Animal
    {
        public double Idade { get; set; }

        protected Cachorro(string nome) : base(nome)
        {
            Console.WriteLine($"Cachorro {nome} inicializado");
        }

        public Cachorro(string nome, int idade) : this(nome)
        {
            Idade = idade;
        }
        public override string ToString()
        {
            return $"{Nome} tem {Idade} anos!";
        }
    }
    internal class ConstrutorThis 
    {

        public static void Executar()
        {
            var Dolly = new Cachorro("Dolly", 8);
            var John = new Cachorro("John", 5);
            var Dalila = new Cachorro("Dalila", 2);
            var Dara = new Cachorro("Dara", 2);

            Console.WriteLine(John);
            Console.WriteLine(Dara);
            Console.WriteLine(Dalila);
            Console.WriteLine(Dolly);
        }
    }
}
