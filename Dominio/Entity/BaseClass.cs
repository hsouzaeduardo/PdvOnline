using System;

namespace Dominio.Entity
{
    public abstract class BaseClass
    {
        public BaseClass()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }

        public DateTime DtCriacao { get; set; } = DateTime.Now;

        public DateTime? DtAlteracao { get; set; }

        public string UsuarioCriacao { get; set; }

        public string UsuarioAlteracao { get; set; }

    }
}
