using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Testing.Domain.Entities.Infrastructure
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        List<TEntity> SelectMany();
        List<TResult> SelectMany<TResult>(Expression<Func<TEntity, bool>> expression);
        TEntity Create(TEntity item);
        TEntity FindOne(Expression<Func<TEntity, bool>> expression);
        TEntity FindOne(int key);
        bool Update(TEntity entity, int keyId, params Expression<Func<TEntity, object>>[] updatedProperties);
        bool Delete(int id);
    }
}