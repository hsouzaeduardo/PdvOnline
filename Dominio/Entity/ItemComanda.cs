using System;

namespace Dominio.Entity
{
    public class ItemComanda : BaseClass
    {
        public  Guid ComandaId { get; set; }

        public Comanda Comanda { get; set; }

        public Item Item { get; set; }

        public Guid ItemId { get; set; }

        public int Quantidade { get; set; }
    }
}