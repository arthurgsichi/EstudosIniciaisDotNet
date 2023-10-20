using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoCsharp.ClassesEMetodos
{
    public class Moto
    {
        private string Marca;
        private string Modelo;
        private uint Cilindradas;

        public Moto(string marca, string modelo, uint cilindradas)
        {
            Marca = marca;
            Modelo = modelo;
            Cilindradas = cilindradas;
        }
        public Moto()
        {

        }
        public string GetMarca()
        {
            return Marca;
        }
        public void SetMarca(String marca)
        {
            Marca = marca;
        }
        public string GetModelo()
        {
            return Modelo;
        }
        public void SetModelo(String modelo)
        {
            Modelo = modelo;
        }
        public uint GetCilindradas()
        {
            return Cilindradas;
        }
        public void SetCilindradas(uint cilindradas)
        {
            Cilindradas = cilindradas;
        }
    }
    internal class GettersESetters
    {
        public static void Executar()
        {
            var moto1 = new Moto("Kawasaki", "Ninja ZX-6R", 636);

            Console.WriteLine(moto1.GetMarca());
            Console.WriteLine(moto1.GetModelo());
            Console.WriteLine(moto1.GetCilindradas());

            var moto2 = new Moto();
            moto2.SetMarca("Honda");
            moto2.SetModelo("GC Titan");
            moto2.SetCilindradas(150);
            Console.WriteLine(moto2.GetMarca() + " " + moto2.GetModelo() + " " + moto2.GetCilindradas());




        }
    }
}
