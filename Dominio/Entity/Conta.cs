using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Entity
{
    public enum FormaPagamento {
        Dinheiro = 1,
        Credito = 2,
        Debito = 3,
        VR = 4
    };

    public class Conta :BaseClass
    {
        public Guid ComandaId { get; set; }

        public decimal Valor { get; set; }

        public string Garcon { get; set; }

        public int Mesa { get; set; }

        public FormaPagamento FormaPagamento { get; set; }

        public decimal Gorgeta { get; set; }
    }
}
