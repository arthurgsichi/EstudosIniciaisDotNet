using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoCsharp.Treinando.BancoDeDados_06
{
    internal class ChatGPT_06
    {
        public static bool encerrarListaContato { get; set; }

        public ChatGPT_06()
        {
            encerrarListaContato = false;
        }

        public static void Executar()
        {
            
            Agenda agenda = new Agenda();
            while (encerrarListaContato == false)
            {
                Console.WriteLine("\nOque você deseja fazer ? ");
                Console.WriteLine("1. Adicionar um contato na lista.");
                Console.WriteLine("2. Excluir algum contato da lista.");
                Console.WriteLine("3. Atualizar um contato já existente.");
                Console.WriteLine("4. Visualizar a lista de contatos atual.");
                Console.WriteLine("5. Fechar o programa.");

                int.TryParse(Console.ReadLine(), out int opcao);

                if (opcao == 1)
                {
                    agenda.AdicionarContanto();
                    agenda.MostraListaContatos();
                    continue;
                }
                if (opcao == 2)
                {
                    agenda.RemoverItem();
                    agenda.MostraListaContatos();
                    continue;
                }
                if (opcao == 3)
                {
                    agenda.MostraListaContatos();
                    agenda.AlterarContatoExistente();
                    continue;
                }
                if (opcao == 4)
                {
                    agenda.MostraListaContatos();
                    continue;
                }
                if (opcao == 5)
                {
                    Console.WriteLine("Programa finalizado. ");
                    return; 
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

