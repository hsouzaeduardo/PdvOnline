using Dominio.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Contratos
{
    public interface INota : IRepositorio<Nota>
    {
        Guid GerarNota(decimal valor, Int64 cpf);

        IEnumerable<Nota> GetByCpf(Int64 cpf);

    }
}