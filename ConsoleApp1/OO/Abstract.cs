using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoCsharp.OO
{
 //abstract é um tipo de classe que é criado para ser implementado, ele é literalmente uma ideia abistrata por isso...
 //nao pode ser instanciado, pois só se instancia oque tem vida, ele cria métodos sem parâmetros para serem implementados.
    public abstract class Celular
    {
        public abstract string Assistente();
        public abstract string Camera();

        public string Tocar()
        {
            return "TUM TUM TURURUM TUM TUM TURURUM TURURURURURURURURUM...";
        }
    }
    public class Samsung : Celular
    {
        public override string Assistente()
        {
            return "Olá! Meu nome é Bixby!";
        }
        public override string Camera ()
        {
            return "64 mega pixels";
        }
    }
    public class IPhone : Celular
    {
        public override string Assistente()
        {
            return "Olá! Meu nome é Siri!";
        }
        public override string Camera()
        {
            return "cento e caralhada mega pixels";
        }
    }

    internal class Abstract
    {
        public static void Executar()
        {
            var celulares = new List<Celular>
            {
                new IPhone(),
                new Samsung()
            };
            foreach (var celular in celulares)
            {
                Console.WriteLine(celular.Assistente());
                Console.WriteLine(celular.Camera());
            }
        }
    }
}
