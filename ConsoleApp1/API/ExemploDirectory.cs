﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoCsharp.API
{
    internal class ExemploDirectory
    {
        public static void Executar()
        {
            var novoDir = @"~/PastaCSharp".ParseHome();
            var novoDirDestino = @"~/PastaCSharpDestino".ParseHome();
            var dirProjeto = @"~/source/repos".ParseHome();
            
            if (Directory.Exists(novoDir))
            {
                Directory.Delete(novoDir, true);
            }

            if (Directory.Exists(novoDirDestino))
            {
                Directory.Delete(novoDirDestino, true);
            }

            Directory.CreateDirectory(novoDir);
            Console.WriteLine(Directory.GetDirectories(novoDir));

            Console.WriteLine("== Pasta ==");
            var pastas = Directory.GetDirectories(dirProjeto);
            foreach (var pasta in pastas)
            {
                Console.WriteLine(pasta);
            }

            Console.WriteLine("== Arquivo ==");
            var arquivos = Directory.GetFiles(dirProjeto);
            foreach (var arquivo in arquivos)
            {
                Console.WriteLine(arquivo);
            }
            Console.WriteLine("== Raiz ==");
            Console.WriteLine(Directory.GetDirectoryRoot(novoDir));

            Directory.Move(novoDir, novoDirDestino);
        }
    }
}
