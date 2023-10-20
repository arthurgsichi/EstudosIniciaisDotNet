using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoCsharp.API
{
    internal class ExemploPath
    {
        public static void Executar()
        {
            var arquivo = @"~/exemplo_path_arquivo.txt".ParseHome();
            var pasta = @"~/exemplo_path_pasta".ParseHome();

            //Criando um arquivo
            if (!File.Exists(arquivo))
            {
                using (StreamWriter sw = new StreamWriter(arquivo))
                {
                    sw.WriteLine("um novo arquivo criado!");
                }

            }
            //Criando um arquivo
            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }
            Console.WriteLine(Path.GetExtension(arquivo));
            Console.WriteLine(Path.GetFileName(arquivo));
            Console.WriteLine(Path.GetFileNameWithoutExtension(arquivo));
            Console.WriteLine(Path.GetDirectoryName(arquivo));
            Console.WriteLine(Path.HasExtension(arquivo));

            Console.WriteLine(Path.HasExtension(pasta));
            Console.WriteLine(Path.GetFullPath(pasta));
            Console.WriteLine(Path.GetPathRoot(pasta));
        }
    }
}
