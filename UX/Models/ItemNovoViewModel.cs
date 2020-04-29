using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UX.Models
{
    public class ItemNovoViewModel
    {
        public string NumeroComanda { get; set; }
        public Guid ItemId { get; set; }
        public int Quantidade { get; set; }
        public string Observacao { get; set; }
    }
}
