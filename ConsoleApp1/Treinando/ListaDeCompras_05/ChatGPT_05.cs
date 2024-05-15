using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoCsharp.Treinando.ListaDeCompras_05.ListaDeCompras_05
{
    internal class ChatGPT_05
    {
        public static void Executar()
        {
            LogicaLista_05 listaNewLista = new LogicaLista_05();
            Console.WriteLine("Bem vindo a Check UR Buy !!");
            List<string> listaCompras = new List<string>();

            while (listaNewLista.encerrarPrograma == false)
            {
                Console.WriteLine("\nOque você deseja fazer ? ");
                Console.WriteLine("1. Adicionar algo na lista.");
                Console.WriteLine("2. Remover algo da lista.");
                Console.WriteLine("3. Fechar o programa.");
                int.TryParse(Console.ReadLine(), out int opcao);
                if (opcao == 1)
                {
                    listaNewLista.AdicionarItem(listaCompras);
                    listaNewLista.MostraAListaCompras(listaCompras);
                    continue;
                }
                if (opcao == 2)
                {
                    listaNewLista.RemoverItem(listaCompras);
                    listaNewLista.MostraAListaCompras(listaCompras);
                    continue;

                }
                if (opcao == 3)
                {
                    Console.WriteLine("Programa finalizado. ");
                    listaNewLista.MostraAListaCompras(listaCompras);
                    return; //listaNewLista.encerrarPrograma = true;
                }
                else
                {
                    Console.WriteLine("Carácter desconhecido, por favor insire um carácter aceito pelo programa");
                    continue;
                }

            }
        }
    }
}
