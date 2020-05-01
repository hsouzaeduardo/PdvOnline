using Dominio.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Contratos
{
    public interface IRepositorio<T> where T: BaseClass
    {
        void Add(T entity);

        void Edit(T entity);

        void Delete(T entity);

        T Get(Guid Id);

        Task<T> GetAynsc(Guid Id);

        IEnumerable<T> Get();

        Task<IEnumerable<T>> GetAynsc();

        int GetCount();
    }
}
