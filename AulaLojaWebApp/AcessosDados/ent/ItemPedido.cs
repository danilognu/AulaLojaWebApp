using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulaLojaWebApp.Entidades
{
    public class ItemPedido
    {
        public int Id { get; set; }
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }

    }
}
