using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoCsharp.Colecoes
{

    public class Produto
    {
        public string Nome { get; set; }
        public double Preço { get; set; }

        public Produto(string nome, double preço)
        {
            Nome = nome;
            Preço = preço;
        }

        public override bool Equals(object? obj)
        {
            return obj is Produto produto &&
                   Nome == produto.Nome &&
                   Preço == produto.Preço;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Nome, Preço);
        }
    }
    internal class ColecoesList
    {
        public static void Executar()
        {
            var livro = new Produto("O Deus Que Destrói Sonhos", 34.99);

            var carrinho = new List<Produto>();
            carrinho.Add(livro);

            var combo = new List<Produto>
            {
                new Produto("Os Cem Mil Reinos", 60.99),
                new Produto("Revolução Dos Bixos", 24.99),
                new Produto("Revolução Dos Bixos", 24.99),
                new Produto("Revolução Dos Bixos", 24.99),
            };

            carrinho.AddRange(combo);
            Console.WriteLine(carrinho.Count);
            //carrinho.RemoveAt(3);

            foreach (var item in carrinho)
            {
                Console.WriteLine(carrinho.IndexOf(item));
                Console.WriteLine($" {item.Nome} {item.Preço} ");
            }
            
            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro);
            Console.WriteLine(carrinho.Count);

            if (carrinho.Count >= 3)
            {
                Console.WriteLine("Você atingiu o bônus máximo e agora irá ganhar um brinde!");
            }
        }
    }
}
