using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoCsharp.Treinando.BancoDeDados_06
{
    internal class Agenda
    {
        private Contanto_06 contato; // isso da q o programa q sugeriu, eu cliquei e deu certo RSRSRS

        public List<Contanto_06> Contatos { get; set; }

        public Agenda()
        {
            Contatos = new List<Contanto_06>();
        }

        public void MostraListaContatos()
        {
            if (Contatos.Count == 0)
            {
                Console.WriteLine("A lista de contatos está vazia");
                return;
            }

            Console.WriteLine("\nLista de contatos atual:");

            int i = 0;
            foreach (var contato in Contatos)
            {
                i++;
                Console.WriteLine($"{i} - Nome: {contato.nomeContato}  |  Telefone: {contato.numeroContato}  | Email:  {contato.emailContato}");
            }

            Console.WriteLine("==============fim da lista=====================");
        }


        public void AdicionarContanto()
        {
            Console.WriteLine("==================================================");
            Contanto_06 contato = new Contanto_06();
            Console.WriteLine("Insire o nome do contato: ");
            contato.nomeContato = Console.ReadLine();

            Console.WriteLine("Agora o número: ");
            contato.numeroContato = Console.ReadLine();

            Console.WriteLine("Por fim, o email: ");
            contato.emailContato = Console.ReadLine();

            Contatos.Add(contato);
            Console.WriteLine("======contato add com sucesso=====================");

        }

        public void AlterarContatoExistente()
        {
            if (Contatos.Count == 0)
            {
                Console.WriteLine("A lista ta vazia ;/");
                return;
            }

            Console.WriteLine("Qual contato você deseja alterar?");
            string nomeDigitado = Console.ReadLine();

            if (Contatos.Any(c => c.nomeContato.Contains(nomeDigitado, StringComparison.CurrentCultureIgnoreCase)))
            {
                var contatosAlterar = Contatos.Where(c => c.nomeContato.Contains(nomeDigitado, StringComparison.CurrentCultureIgnoreCase));

                if (contatosAlterar.Count() > 1)
                {
                    int idxContato = 0;
                    Console.WriteLine("Encontrei mais de uma opção com o nome: {0}", nomeDigitado);
                    int count = 0;
                    foreach (var con in contatosAlterar)
                    {
                        count++;
                        Console.WriteLine($"{count} - {con.nomeContato} | {con.numeroContato} | {con.emailContato}");
                    }

                    Console.WriteLine("Escolha qual contato deseja alterar, digitando o número correspondente: ");

                    while (true)
                    {
                        if (int.TryParse(Console.ReadLine(), out idxContato) && idxContato > 0)
                        {
                            break;
                        }
                        Console.WriteLine("Opção inválida, digite o número correspondente: ");
                    }

                    contato = contatosAlterar.ElementAt(idxContato - 1);
                }
                else
                {
                    contato = contatosAlterar.FirstOrDefault();
                }
            }
            else
            {
                Console.WriteLine("Não encontrei nenhum contato com o nome: {0}", nomeDigitado);
                Console.WriteLine("================================================== \n");
                return;
            }

           if (contato != null)
           {
                Console.WriteLine("Oque você quer alterar do contato: {0} ?", contato.nomeContato);
                string r = Console.ReadLine();
                if (r.Equals("nome", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Qual nome você quer adicionar ao contato {0} ?", contato.nomeContato);
                    string novoNomeContato = Console.ReadLine();
                    contato.nomeContato = novoNomeContato;
                    Console.WriteLine("Pronto! agora o nome do seu contato é: {0}", contato.nomeContato);
                }
                else if (r.Equals("número", StringComparison.OrdinalIgnoreCase)) 
                {
                    Console.WriteLine("Qual número você quer adicionar ao contato {0} ?", contato.numeroContato);
                    string novoNumeroContato = Console.ReadLine();
                    contato.numeroContato = novoNumeroContato;
                    Console.WriteLine("Pronto! agora o número do seu contato é: {0}", contato.numeroContato);
                }
                else if(r.Equals("email", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Qual email você quer adicionar ao seu contato {0} ?", contato.emailContato);
                    string novoEmailContato = Console.ReadLine();
                    contato.emailContato = novoEmailContato;
                    Console.WriteLine("Pronto! agora o email do seu contato é: {0}", contato.emailContato);
                }
            }
           else
           {
               Console.WriteLine("Nenhum contato encontrado ou disponível!");
           }
        }

        public void RemoverItem(Contanto_06 contato = null)
        {

            if (Contatos.Count == 0)
            {
                Console.WriteLine("A lista ta vazia ;/");
                return;
            }

            if (contato == null)
            {
                Console.WriteLine("==================================================");
                Console.WriteLine("Digite o nome do contato que voce deseja remover:  ");
                string nomeDigitado = Console.ReadLine();

                if (Contatos.Any(c => c.nomeContato.Contains(nomeDigitado, StringComparison.CurrentCultureIgnoreCase)))
                {
                    var contatosRemover = Contatos.Where(c => c.nomeContato.Contains(nomeDigitado, StringComparison.CurrentCultureIgnoreCase));

                    if (contatosRemover.Count() > 1)
                    {
                        int idxContato = 0;
                        Console.WriteLine("Encontrei mais de uma opção com o nome: {0}", nomeDigitado);
                        int count = 0;
                        foreach (var con in contatosRemover)
                        {
                            count++;
                            Console.WriteLine($"{count} - {con.nomeContato} | {con.numeroContato} | {con.emailContato}");
                        }

                        Console.WriteLine("Escolha qual contato deseja remover, digitando o número correspondente: ");

                        while (true)
                        {                            
                            if (int.TryParse(Console.ReadLine(), out idxContato) && idxContato > 0)
                            {
                                break;
                            }
                            Console.WriteLine("Opção inválida, digite o número correspondente: ");
                        }

                        contato = contatosRemover.ElementAt(idxContato - 1);
                    }
                    else
                    {
                        contato = contatosRemover.FirstOrDefault();
                    }
                }
                else
                {
                    Console.WriteLine("Não encontrei nenhum contato com o nome: {0}", nomeDigitado);
                    Console.WriteLine("================================================== \n");
                    return;
                }
            }

            if (contato != null)
            {
                Contatos.Remove(contato);
                Console.WriteLine("O item {0} foi removido da lista!", contato.nomeContato);
            }
            else
            {
                Console.WriteLine("Nenhum contato encontrado ou disponível!");
            }

        }
    }
}
