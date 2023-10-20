using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoCsharp.Colecoes
{
    internal class ColecoesDictionary
    {
        public static void Executar()
        {
            var p = new Dictionary<int, string>();
            //nesse tipo de coleção a Key nao pode se repeting porem o Value pode
            p.Add(1988, "papai");
            p.Add(1983, "mamãe");
            p.Add(2008, "arthur");

            //valida uma informação key 
            if (p.ContainsKey(2008))
            {
                Console.WriteLine("2008: " + p[2008]);
                Console.WriteLine("2008: " + p.GetValueOrDefault(2008));

            }
            //valida uma informação value
            Console.WriteLine(p.ContainsValue("papai"));

            //forma de remover no dictionary
            Console.WriteLine($"Removeu? {p.Remove(2088)}");

            //tentando pegar o value atraves da key
            p.TryGetValue(1983, out string datanascimentomamae);
            Console.WriteLine($"Em 1983 nasceu a {datanascimentomamae}!");
            
            //Percorrendo as keys
            foreach (var chave in p.Keys)
            {
                Console.WriteLine(chave);
            }
            //Percorrendo aos values
            foreach (var valor in p.Values)
            {
                Console.WriteLine(valor);
            }

            //Percorrendo todo o dictionary ( keys e os values )
            foreach (var pessoas in p)
            {
                Console.WriteLine($"{pessoas.Value} nasceu em {pessoas.Key}");
            }
        }
    }
}
