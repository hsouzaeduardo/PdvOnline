using Dominio.Contratos;
using Dominio.Entity;
using Infra.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infra.Repositorio
{
    public class NotaRepositorio : RepositorioSQL<Nota>, INota
    {
        public NotaRepositorio(ComandasContext ctx) : base(ctx)
        {

        }

        public Guid GerarNota(decimal valor, long cpf)
        {
            var nota = new Nota() { Cpf = cpf, Valor = valor };

            Add(nota);

            return nota.Id;
        }

        public IEnumerable<Nota> GetByCpf(long cpf)
        {
            return _tabelas.Where(x => x.Cpf == cpf);
        }
    }
}
