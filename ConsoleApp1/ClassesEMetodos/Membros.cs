using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoCsharp.ClassesEMetodos
{
    class Membros
    {
        public static void Executar()
        {
            Pessoa sicrano = new Pessoa();
            sicrano.Nome = "Tutu";
            sicrano.Idade = 14;

            //Console.WriteLine($"{sicrano.Nome} tem {sicrano.Idade} anos.");
            sicrano.ApresentarNoConsole();

            var fulano = new Pessoa();
            fulano.Nome = "";
            fulano.Idade = 34;

            if (fulano.Idade == 0 || fulano.Nome == "")
            {
                Console.WriteLine("Algo de errado não está certo! ");
                sicrano.Zerar();
            }
            else { 

            var apresentacaoDoFulano = fulano.Apresentar();
            Console.WriteLine(apresentacaoDoFulano);
        }
        
        }
  
        
    }
}
