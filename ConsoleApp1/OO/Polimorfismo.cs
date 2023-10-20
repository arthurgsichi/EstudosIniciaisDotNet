using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoCsharp.OO
{
    public class Comida
    {
        public double Peso;

        public Comida(double peso)
        {
            Peso = peso;
        }
        //public Comida()
        //{

        //}
    }
    public class Feijao : Comida
    {
    public Feijao(double peso) : base(peso)
        {

        }
    }
    public class Arroz : Comida {
        public Arroz(double peso) : base(peso)
        {

        }
    }
    public class Frangao : Comida {
        public Frangao(double peso) : base(peso)
        {

        }
    }
    public class BatataPalha : Comida {
        public BatataPalha(double peso) : base(peso)
        {

        }
    }
    public class Pessoa
    {
        public double Peso;
        
        public void Comer(Comida comida)
        {
            Peso += comida.Peso;
        }
    }

    internal class Polimorfismo
    {
        public static void Executar()
        {
            Feijao ingrediente1 = new Feijao(0.25);
            //ingrediente1.Peso = 0.25;

            Arroz ingrediente2 = new Arroz(0.25);
            //ingrediente2.Peso = 0.25;

            Frangao ingrediente3 = new Frangao(0.35);
            //ingrediente3.Peso = 0.35;

            BatataPalha ingrediente4 = new BatataPalha(0.15);
            //ingrediente4.Peso = 0.15;

            Pessoa cliente = new Pessoa();
            cliente.Peso = 95.04;
            cliente.Comer(ingrediente1);
            cliente.Comer(ingrediente2);
            cliente.Comer(ingrediente3);
            cliente.Comer(ingrediente4);

            Console.WriteLine($"Agora o peso do cliente é {cliente.Peso} kg !");
        }
    }
}
