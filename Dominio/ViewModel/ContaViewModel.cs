using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.ViewModel
{
    public class ContaViewModel
    {
        public Guid Comanda { get; set; }
        public List<ItemViewModel> Items { get; set; }
        public decimal Total { get; set; }

    }
    public class ItemViewModel
    {
        public Guid Id { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public decimal Valor { get; set; }
    }

}
