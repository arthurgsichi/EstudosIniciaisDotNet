using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoCsharp.TopicosAvancados
{
    internal class PropriedadesNumImPar
    {
        public List<int> listaDeNumeros = new List<int>();

        public List<int> numerosImpares = new List<int>();

        public List<int> numerosPares = new List<int>();

        public void Verificacao()
        {
            if (listaDeNumeros != null)
            { 
                numerosImpares = listaDeNumeros.Where(numeros => numeros % 2 != 0).ToList<int>();
                numerosPares = listaDeNumeros.Where(numeros => numeros % 2 == 0).ToList<int>();
            }

            Console.WriteLine($"Esses foram os números pares encontrados: {String.Join(",", numerosPares)}");
            Console.WriteLine($"E esses os ímpares encontrados: {String.Join(",", numerosImpares)}");
        }
    }

    internal class NumImparPar
    {
        public static void Executar()
        {
            PropriedadesNumImPar propImPar = new PropriedadesNumImPar();
            
            Console.WriteLine("Digite quantos números quiser e faça a separação deles por vírgula.");
            string strNumeros = Console.ReadLine();

            var listNumeros = strNumeros.Split(",");

            for (int i = 0; i < listNumeros.Length; i++)
            {
                if (int.TryParse(listNumeros[i], out int num))
                {
                    propImPar.listaDeNumeros.Add(num);
                }
            }


            //var listNumeros = strNumeros.Split(",").ToList().Select(a => int.TryParse(a, out int num) ? num : -1);
            //    .Where(a => int.TryParse(a, out int num))
            //    .Select(a => int.TryParse(a, out int num) ? num : -1);

            //propImPar.listaDeNumeros.AddRange(listNumeros);

            propImPar.Verificacao();
        }

    }
}


