using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoCsharp.TopicosAvancados
{
    internal class PropTarefas
    {
        public List<string> tarefas = new List<string>();


        public void MostrarLista()
        {
            Console.WriteLine("Lista atual: ");
            for (int i = 0; i < tarefas.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {String.Join(" ", tarefas[i])}");
            }
            Console.WriteLine("================================================");

        }

        public void RemoverMetodo()
        {
            Console.WriteLine("Escolha o nome correspondente a tarefa da lista que voce deseja remover");
            string r = Console.ReadLine();

            if (tarefas.Contains(r))
            {
                tarefas.Remove(r);
                Console.WriteLine($"A tarefa foi devidamente removido.");
                Console.WriteLine("================================================");

            }
            else
            {
                Console.WriteLine("tarefa desconhecida, tente novamente com um nome correspondente a alguma tarefa existente");
                return;
            }

        }

        public void AddMetodo()
        {
            Console.WriteLine("Adicione quantas tarefas quiser ou escreva 'sair' para voltar ao menu");
            while (true)
            {
  
                tarefas.Add(Console.ReadLine());

                if (tarefas.Contains("sair"))
                {
                    tarefas.Remove("sair");
                    Console.WriteLine("Voltando ao menu.");
                    Console.WriteLine("================================================");

                    return;
                }
                else
                {

                    continue;
                }
                
            }
        }
        public void MarcarConcluida()
        {
            Console.WriteLine("Qual dentre as tarefas acima você já concluiu ?");
            var r = Console.ReadLine();
            if (tarefas.Contains(r))
            {
                tarefas.RemoveAll(x => x.Equals(r));
                Console.WriteLine("Parabéns pela tarefa concluída !");
                Console.WriteLine("================================================");
            } else
            {
                Console.WriteLine("Tarefa desconhecida, tente novamente mais tarde");
                return;
            }
        }

    }

    internal class GerenciamentoTarefas
    {
        public static void Executar()
        {
            PropTarefas prop = new PropTarefas();
            while (true)
            {
                Console.WriteLine("Escolha o número dentre as ações q vc quer fazer: ");
                Console.WriteLine("1. Adicionar uma Tarefa");
                Console.WriteLine("2. Remover item existende da lista");
                Console.WriteLine("3. Marcar tarefa como concluída");
                Console.WriteLine("4. Sair do programa");
                int.TryParse(Console.ReadLine(), out int resposta);
                if (resposta == 1)
                {
                    prop.AddMetodo();
                    prop.MostrarLista();
                    continue;
                }
                else if (resposta == 2)
                {
                    prop.MostrarLista();
                    prop.RemoverMetodo();
                    continue;
                }
                else if (resposta == 3)
                {
                    prop.MostrarLista();
                    prop.MarcarConcluida();
                }
                else if (resposta == 4)
                {
                    Console.WriteLine("Foi um prazer têlo aqui ");
                    return;
                }
                else
                {
                    Console.WriteLine("não entendi nao mano repete ai");
                    continue;
                }
            }
        }
    }
}
