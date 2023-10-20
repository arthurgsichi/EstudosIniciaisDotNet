using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace cursoCsharp.Excecoes
{
    public class NegativoException : Exception
    {
        public NegativoException() { }
        public NegativoException(string message) : base(message) { }

        public NegativoException(string message, Exception inner) : base(message, inner) { }

    }
    public class ImparException : Exception
    {
        public ImparException(string message) : base(message) { }
    }

    internal class ExcaoPersonalizada
    {
        public static int PositivoPar()
        {
            Random random = new Random();
            int valor = random.Next(-8, 8);
            Console.WriteLine(valor);
            if (valor < 0)
            {
                throw new NegativoException("Número negativo..:(");
            }
            else if (valor % 2 == 1)
            {
                throw new ImparException("Número Impar :C");
            }
            
            return valor;
        }
        
        public static void Executar()
        {
 
            try
            {
                PositivoPar();
            } catch (NegativoException ex) {
                Console.WriteLine(ex.Message);
            } catch (ImparException ex)
            {
                Console.WriteLine(ex.Message);
            }
            }
    }
}
