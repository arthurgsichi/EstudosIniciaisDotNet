using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoCsharp.Treinando.ListaDeCompras_05
{
    internal class LogicaLista_05
    {
        public bool encerrarPrograma { get; set; }

        public void MostraAListaCompras(List<string> lista)
        {
            Console.WriteLine("\nLista de compras atual:");
            if (lista.Count == 0)
            {
                Console.WriteLine("A lista de compras está vazia.");
            }
            else
            {
                for (int i = 0; i < lista.Count; i++)
                {
                    Console.WriteLine(lista[i]); 
                }
            }

        }

        public void AdicionarItem(List<string> lista)
        {
            Console.WriteLine("==================================================");
            Console.Write("EScreva oque você quer colocar na lista: ");
            string item = Console.ReadLine();
            lista.Add(item);
            Console.WriteLine("Item {0} adicionado à lista de compras.", item);
        }
        public void RemoverItem(List<string> lista)
        {
            if (lista.Count == 0)
            {
                Console.WriteLine("A lista ta vazia ;/");
                return;
            }
            Console.WriteLine("==================================================");
            Console.WriteLine("Digite o número na lista q voce quer remover: ");
            string ItemRemoverLista = Console.ReadLine();
            if (lista.Contains(ItemRemoverLista))
            {

                lista.Remove(ItemRemoverLista);
                Console.WriteLine("O item {0} foi removido da lista!", ItemRemoverLista);
            }
            else
            {
                Console.WriteLine("Item desconhecido, por favor adicionar um item real na lista.");
                return;
            }
        }

    }

}

