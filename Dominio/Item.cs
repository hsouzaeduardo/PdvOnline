using System;
using System.Collections.Generic;

namespace Dominio
{
    public class Item : BaseClass
    {
        public Item()
        {
            base.Id = Guid.NewGuid();
        }

        public string Descricao { get; set; }

        public string Foto { get; set; }

        public short Disponivel { get; set; }

        public decimal Preco { get; set; }

        public virtual IList<ItemComanda> Comandas { get; set; }
    }
}