using Dominio.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Contratos
{
    public interface IComanda : IRepositorio<Comanda>
    {
        void Abrir(string numeroComanda);

        void Fechar(string numeroComanda);

        void IncluirItem(Item item, string numeroComanda, int quantidade, string garcon);

        Task<Comanda> GetItensComandaAsync(string numeroComanda);

        Comanda GetComandaNumero(string numeroComanda);
    }
}
