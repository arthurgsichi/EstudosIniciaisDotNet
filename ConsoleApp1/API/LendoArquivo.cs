using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoCsharp.API
{
    internal class LendoArquivo
    {
        public static void Executar()
        {
            var path = @"~/lendo_arquivo.txt".ParseHome();

            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine("Produto | Preço | Qtde");
                    sw.WriteLine("-------------//--------------");
                    sw.WriteLine("Caneta Bic Preta | 3.59 | 98");
                    sw.WriteLine("Borracha Branca | 3.00 | 28");
                    sw.WriteLine("Teclado Gamer | 299.99 | 14");
                    sw.WriteLine("Air Jordan | 1999.99 | 2");
                }

            }
            try
            {
                using (StreamReader sw = new StreamReader(path))
                {
                    var texto = sw.ReadToEnd();
                    Console.WriteLine(texto);
                }
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
