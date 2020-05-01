using Dominio.Contratos;
using Dominio.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositorio
{
    public class ComandaRepositorio : Repositorio.RepositorioSQL<Comanda>, IComanda
    {
        public ComandaRepositorio(Contexto.ComandasContext ctx):base(ctx)
        {}

        public void Abrir(string numeroComanda)
        {
            var comanda = GetComandaNumero(numeroComanda);

            if(comanda != null && comanda.Status.Equals(StatusComanda.Livre))
            {
                comanda.Status = StatusComanda.Aberta;
                comanda.Aberta = DateTime.Now;
                base.Edit(comanda);
            }

        }

        public void Fechar(string numeroComanda)
        {
            var comanda = GetComandaNumero(numeroComanda);
            
            if (comanda != null && comanda.Status.Equals(StatusComanda.Aberta) && comanda.Itens.Sum(x=> x.Quantidade) > 0)
            {
                comanda.Status = StatusComanda.Livre;

                comanda.Aberta = DateTime.Now;

                base.Edit(comanda);
            }

        }

        public Comanda GetComandaNumero(string numeroComanda)
        {
            var comanda = base._tabelas.Include("Itens").FirstOrDefault(x => x.Numero.Equals(numeroComanda));

            return comanda;
        }

        public async Task<Comanda> GetItensComandaAsync(string numeroComanda)
        {
            return await base._tabelas.Include("Itens").FirstOrDefaultAsync(x => x.Numero.Equals(numeroComanda));
        }

        public void IncluirItem(Item item, string numeroComanda, int quantidade, string garcon)
        {
            var comanda = GetComandaNumero(numeroComanda);

            var itensEdit = comanda.Itens.FirstOrDefault(x => x.ItemId == item.Id);

            if(itensEdit != null)
            {
                itensEdit.Quantidade += quantidade;
            }
            else
            {
                comanda.Itens.Add(new ItemComanda()
                {
                    UsuarioCriacao = garcon,
                    Quantidade = quantidade,
                    Item = item
                });
            }

            base.Edit(comanda);
        }
    }
}
