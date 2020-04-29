using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Nota : BaseClass
    {
        public Nota()
        {
            base.Id = Guid.NewGuid();
        }

        public decimal Valor { get; set; }

        public Int64 Cpf { get; set; }

        public Comanda Comanda { get; set; }
    }
}
