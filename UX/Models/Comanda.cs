using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UX.Models
{

    public enum StatusComanda
    {
        Livre = 0,
        Aberta = 1,
        Fechada= 2,
        Paga =3

    }
    public class Comanda
    {
        public string Numero { get; set; }

        public DateTime Abertura { get; set; }

        public DateTime? Fechamento { get; set; }

        public StatusComanda Status { get; set; }

        public string Garcon { get; set; }
    }
}
