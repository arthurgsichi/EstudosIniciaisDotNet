using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoCsharp.TopicosAvancados
{
    
    internal class ComandaPedidoRestaurante
    {
        public decimal PrecoFinal {  get; set; }
        public List<Item> Itens = new List<Item>();
    }

    internal class Item
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }
    }
}
