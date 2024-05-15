using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace cursoCsharp.TopicosAvancados
{
    internal class PropRestaurant
    {
        ComandaPedidoRestaurante comanda = new ComandaPedidoRestaurante();
        public Dictionary<string, decimal> menu = new Dictionary<string, decimal>
        {
            { "Hamburguer",15.99m},
            { "Pizza",59.99m},
            { "Esfiha",20.90m},
            { "Carne",59.99m}
        };
        public void Pedido()
        {
            Console.WriteLine("Olá cliente, este é o nosso menu de hoje com os preços");
            Console.WriteLine($" Por favor digite o número condizente ao item do menu ou se quiser sair do modo menu digite qualquer outro caracter.");

            for (int i = 0; i < menu.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {menu.ElementAt(i).Key} por R$ {menu.ElementAt(i).Value}");
            }

            while (true)
            {
                
                int.TryParse(Console.ReadLine(), out int respostapedido);

                if (respostapedido > 0 && respostapedido <= menu.Count)
                {
                    comanda.Itens.Add(new Item() { Nome = menu.ElementAt(respostapedido - 1).Key, Preco = menu.ElementAt(respostapedido - 1).Value });
                    Console.WriteLine($"Entendido, estamos preparando o seu {menu.ElementAt(respostapedido - 1).Key}\nVocê gostaria de pedir mais alguma coisa?\n");
                    continue;
                }
                else
                {
                    Console.WriteLine("Saindo do modo menu...");
                    return;
                }
            }
        }
        public void TotalPedido()
        {
            foreach (var item in comanda.Itens)
            {
                comanda.PrecoFinal += item.Preco;
            }

            Console.WriteLine($"Valor Total: R$ {comanda.PrecoFinal}");

            Console.WriteLine("Você vai dividir a conta com alguém?");
            var resposta = Console.ReadLine();
            if (resposta.Equals("sim", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("Com quantas pessoas ?");
                int.TryParse(Console.ReadLine(), out int r);
                if (r > 0)
                {
                    decimal res = comanda.PrecoFinal / r;
                    Console.WriteLine($"A conta dividida entre {r} pessoas fica R${res} para cada");
                }
                
            }
        }
    }
    internal class PedidosRestaurante
    {
        public static void Executar()
        {
            PropRestaurant prop = new PropRestaurant();
            while (true)
            {
                Console.WriteLine("Escolha o número dentre as ações q vc quer fazer: ");
                Console.WriteLine("1. Fazer pedido");
                Console.WriteLine("2. Chamar a conta");
                Console.WriteLine("3. Sair do programa");
                string resposta = Console.ReadLine();
                if (resposta == "1")
                {
                    prop.Pedido();
                    continue;
                }
                else if (resposta == "2")
                {
                    prop.TotalPedido();
                    continue;
                }
                else if (resposta == "3")
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