using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class, IBaseEntity
    {
        public IQueryable<TEntity> Query(params Expression<Func<TEntity, object>>[] includes);
        public Task<IEnumerable<TEntity>> GetAll();
        public Task<TEntity> GetByKeyAsync<TKey>(TKey key);
        public Task DeleteAsync(TEntity entity);
        public Task UpdateAsync(TEntity entity);
        public Task<TEntity> AddAsync(TEntity entity);
        public Task<int> SaveChangeAsync();
    }
}
