using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoCsharp.OO
{
    internal class Herança
    {
        public static void Executar()
        {
            Console.WriteLine("Uno...");
            Uno uno = new Uno();
            Console.WriteLine(uno.Acelerar());
            Console.WriteLine(uno.Acelerar());
            Console.WriteLine(uno.Frear());
            Console.WriteLine(uno.Frear());
            Console.WriteLine(uno.Frear());

            Console.WriteLine("Ferrari...");
            Ferrari ferrari = new Ferrari();
            Console.WriteLine(ferrari.Acelerar());
            Console.WriteLine(ferrari.Acelerar());
            Console.WriteLine(ferrari.Frear());
            Console.WriteLine(ferrari.Frear());
            Console.WriteLine(ferrari.Frear());

            Console.WriteLine("Ferrari com tipo Carro...");
            Carro carro3 = new Ferrari(); // instanciando uma classe mais específica por uma menos específica
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());

            Console.WriteLine("Uno com tipo Carro...");
            carro3 = new Uno(); // Exemplo de polimorfismo
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());



        }
    }

    public class Carro
    {
        protected readonly int VelocidadeMaxima;
        int VelocidadeAtual;

        public Carro(int velocidadeMaxima)
        {
            VelocidadeMaxima = velocidadeMaxima;
        }

        protected int AlterarVelocidade(int delta)
        {
            int novaVelocidade = VelocidadeAtual + delta;

            if (novaVelocidade < 0)
            {
                VelocidadeAtual = 0;
            }
            else if (novaVelocidade > VelocidadeMaxima)
            {
                VelocidadeAtual = VelocidadeMaxima;
            }
            else
            {
                VelocidadeAtual = novaVelocidade;
            }
            return VelocidadeAtual;

        }
        public virtual int Acelerar()
        {
            return AlterarVelocidade(5);
        }
        public virtual int Frear()
        {
            return AlterarVelocidade(-5);
        }
    }


    public class Uno : Carro
    {
        public Uno() : base(150)
        {

        }
    }

    public class Ferrari : Carro
    {
        public Ferrari() : base(350)
        {

        }
        //sobrescrevendo o método acelerar (quando sobrescreve precisa colocar no método pai a sigla virtual)
        public override int Acelerar()
        {
            return AlterarVelocidade(15);
        }
        //forma de mudar um valor de um método da classe pai ocultanduo
        //public new int Frear()
        //{
        //    return AlterarVelocidade(-15);
        //}
        public override int Frear()
        {
            return AlterarVelocidade(-15);
        }
    }

}
