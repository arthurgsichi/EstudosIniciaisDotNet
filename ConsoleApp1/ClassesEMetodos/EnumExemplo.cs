using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoCsharp.ClassesEMetodos
{
    //tipo de atributo numérico utilizado quando os valores estão pré definidos
    //ex.: Como prefere ser chamado? ele/dele || ela/dela  
    public enum Genero { Homem, Muie, XMan, Transformers};
    //OBS: nesse tipo de contagem começa do 0 até infinito
    
    
    public class PessoaVivente
    {
        //atributos da classe
        public string Nome;
        public Genero GeneroDoSer;
        //nesse caso o enum está sendo usado como um tipo para o atributo
    }

    internal class EnumExemplo
    {
        public static void Executar()
        {
            //forma de transformar o valor de um atributo
            int id = (int)Genero.Homem;
            Console.WriteLine(id);

            //mudança dos valores dos atributos por meio da instancia da classe
            var SerHumano = new PessoaVivente();
            SerHumano.Nome = "Josivaldo de Pindamoiangaba";
            SerHumano.GeneroDoSer = Genero.XMan;

            //imprimindo a instancia com os novo valores no console
            Console.WriteLine("{0} é um {1}", SerHumano.Nome, SerHumano.GeneroDoSer);
        }
    }
}
