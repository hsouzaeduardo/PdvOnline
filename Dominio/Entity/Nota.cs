using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Entity
{
    public class Nota : BaseClass
    {
        public decimal Valor { get; set; }

        public Int64 Cpf { get; set; }

        public Comanda Comanda { get; set; }
    }
}
