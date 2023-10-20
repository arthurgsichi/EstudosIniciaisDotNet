using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoCsharp.ClassesEMetodos
{
    internal class Propriedades
    {
        public class CarroOpcional
        {
            double desconto = 0.1;

            string nome;
            public string Nome { get { return "Opcional: " + nome; } set { nome = value; } }

        
        //propriedade altoimplementada
        public double Preço { get; set; }

        //Somente leitura (não pode ter seu valor alterado)
        public double PreçoComDesconto
        {
            get => Preço - (desconto * Preço);//labda

        }
            public CarroOpcional(string nome, double preço)
            {

                Nome = nome;
                Preço = preço;
            }

            public CarroOpcional()
            {
            }
        }

        public static void Executar()
        {
            var op1 = new CarroOpcional("Ar Condicionado", 3499.9);
            Console.WriteLine(op1.PreçoComDesconto);

            var op2 = new CarroOpcional();
            op2.Nome = "Direção Elétrica";
            op2.Preço = 2349.9;

            Console.WriteLine(op1.Nome);
            Console.WriteLine(op1.Preço);


            Console.WriteLine(op2.Nome);
            Console.WriteLine(op2.Preço);
            Console.WriteLine(op2.PreçoComDesconto);
        }
    
}
}
