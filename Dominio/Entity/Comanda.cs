using Dominio.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Entity
{
    public enum StatusComanda
    {
        Livre = 0,
        Aberta = 1,
        Fechada = 2,
        Paga = 3
    }

    public class Comanda : BaseClass
    {
        public Comanda()
        {
         
            Itens = new List<ItemComanda>();
        }

        //BZE1000
        public string Numero { get; set; }

        public StatusComanda Status { get; set; }

        public DateTime? Aberta { get; set; }

        public DateTime? Fechamento { get; set; }

        public string Nome { get; set; }

        public virtual IList<ItemComanda> Itens { get; set; }
    }
}
