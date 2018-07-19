using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulaLojaWebApp.Entidades
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public ICollection<ItemPedido> ItensPedidos { get; set; }
    }
}
