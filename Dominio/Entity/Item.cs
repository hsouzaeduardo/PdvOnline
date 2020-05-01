using System;
using System.Collections.Generic;

namespace Dominio.Entity
{
    public class Item : BaseClass
    {
        public string Descricao { get; set; }

        public string Foto { get; set; }

        public short Disponivel { get; set; }

        public decimal Preco { get; set; }

        public virtual IList<ItemComanda> Comandas { get; set; }
    }
}