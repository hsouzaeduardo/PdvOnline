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
    public class RepositorioSQL<T> : IRepositorio<T> where T : BaseClass
    {
        private readonly Contexto.ComandasContext _ctx;
        internal readonly DbSet<T> _tabelas;


        public RepositorioSQL(Contexto.ComandasContext ctx)
        {
            _ctx = ctx;
            _tabelas = _ctx.Set<T>();
        }

        public void Add(T entity)
        {
            _tabelas.Add(entity);
            _ctx.SaveChanges();
        }

        public void Delete(T entity)
        {
            _tabelas.Remove(entity);
            _ctx.SaveChanges();
        }

        public void Edit(T entity)
        {
            _tabelas.Update(entity);
            _ctx.SaveChanges();
        }

        public T Get(Guid id)
        {
            return _tabelas.Find(id);
        }

        public IEnumerable<T> Get()
        {
            return _tabelas.ToList();
        }

        public async Task<T> GetAynsc(Guid id)
        {
            return await _tabelas.FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetAynsc()
        {
            return await _tabelas.ToListAsync();
        }

        public int GetCount()
        {
            return _tabelas.Count();
        }
    }
}
