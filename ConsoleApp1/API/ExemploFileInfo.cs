using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoCsharp.API
{
    internal class ExemploFileInfo
    {
        //array usando params, ou seja, listando e criando uma ação que pode ser usada quando camar o método
        public static void ExcluirSeExistir(params string[] caminhos)
        {
            //pra cada caminho dentro de caminhos
            foreach (var caminho in caminhos) { 
                //taca tudo no arquivo e testa isso aq..
            FileInfo arquivo = new FileInfo(caminho);
                    //..se existem arquivos dentro de arquivo então, excluaos
                if (arquivo.Exists)
                {
                    arquivo.Delete();
                }
            }

        }
        public static void Executar()
        {
            var caminhoOriginal = @"~/arq_origem.txt".ParseHome();
            var caminhoDestino = @"~/arq_destino.txt".ParseHome();
            var caminhoCopia = @"~/arq_copia.txt".ParseHome();

            ExcluirSeExistir(caminhoOriginal, caminhoDestino, caminhoCopia);

            using (StreamWriter sw = File.CreateText(caminhoOriginal))
            {
                sw.WriteLine("papai do céu é mt bom mano :D");
            }

            FileInfo origem = new FileInfo(caminhoOriginal);
            Console.WriteLine(origem.Name); // nome do arquivo
            Console.WriteLine(origem.IsReadOnly); //se eu posso escrever nele ou n
            Console.WriteLine(origem.FullName); // onde ele esta no meu computador
            Console.WriteLine(origem.Extension); //qual extensao que ele usa ( no caso é .txt)

            origem.CopyTo(caminhoCopia);
            origem.MoveTo(caminhoDestino);
        
        }

    }
}
