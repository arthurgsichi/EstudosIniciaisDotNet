using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoCsharp.ClassesEMetodos
{
    internal class Construtores

    {
        public class Carro {
            public string Modelo;
            public string Fabricante;
            public int Ano;

            public Carro()
            {
            }

            public Carro(string modelo, string fabricante, int ano)
            {
                Modelo = modelo;
                Fabricante = fabricante;
                Ano = ano;
            } 
            
        }


        public static void Executar()
        {
            //exemplo de método construtor PADRÃO ( não recebe nenhum parâmetro )
            var carro1 = new Carro();
            carro1.Ano = 2010;
            carro1.Fabricante = "Honda";
            carro1.Modelo = "Fit";
            Console.WriteLine($"{carro1.Modelo} {carro1.Fabricante} {carro1.Ano}");

            //exemplo de método q recebe um parâmetro baseado nas possibilidades dadas pela classe
            var carro2 = new Carro("Renegade", "Sla", 2023);
            Console.WriteLine($"{carro2.Modelo} {carro2.Fabricante} {carro2.Ano}");

            //outro possível exemplo de método construtor PADRÃO q já cria setando os parâmetros dentro das chaves 
            var carro3 = new Carro()
            {
                Fabricante = "Fiat",
                Modelo = "Uno",
                Ano = 1988

            };
            Console.WriteLine($"{carro3.Modelo} {carro3.Fabricante} {carro3.Ano}");







        }
    }
}
