using CodePlex.LinqProjector;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Testing.Models;

namespace Testing.Domain.Entities.Infrastructure
{
    public abstract class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private ApplicationContext applicationContext;
        private DbSet<TEntity> dbSet;

        public GenericRepository()
        {
            applicationContext = new ApplicationContext();
            dbSet = applicationContext.Set<TEntity>();
        }

        //****SELECT MANY****
        public virtual List<TEntity> SelectMany()
        {
            return dbSet.ToList();
        }

        public virtual List<TResult> SelectMany<TResult>(Expression<Func<TEntity, bool>> expression)
        {
            var data = dbSet.Where(expression).Project().To<TResult>();
            return data.ToList();
        }

        //****FIND****
        public virtual TEntity FindOne (Expression<Func<TEntity, bool>> expression)
        {
            var item = dbSet.AsNoTracking().Where(expression);
            return item.FirstOrDefault();
        }

        public virtual TEntity FindOne(int key)
        {
            return dbSet.Find(key);
        }

        //****CRUD**** 
        public virtual TEntity Create(TEntity item)
        {
            var entity = dbSet.Add(item);
            applicationContext.SaveChangesAsync();
            return entity;
        }

        public virtual bool Update(TEntity entity, int keyId, params Expression<Func<TEntity, object>>[] updatedProperties)
        {
            var originalEntity = dbSet.Find(keyId);
            var dbEntityEntry = applicationContext.Entry(originalEntity);
            if (updatedProperties.Any())
            {
                foreach (var property in dbEntityEntry.CurrentValues.PropertyNames)
                {
                    var original = dbEntityEntry.CurrentValues.GetValue<object>(property);
                    var current = updatedProperties.GetType().GetProperty(property).GetValue(entity);
                    if (current != original)
                    {
                        dbEntityEntry.Property(property).CurrentValue = current;
                        dbEntityEntry.Property(property).IsModified = true;
                    }
                }
            }
            else
            {
                foreach (var property in dbEntityEntry.CurrentValues.PropertyNames)
                {
                    var original = dbEntityEntry.CurrentValues.GetValue<object>(property);
                    var current = entity.GetType().GetProperty(property).GetValue(entity);

                    if (current != null && original != current)
                    {
                        dbEntityEntry.Property(property).CurrentValue = current;
                        dbEntityEntry.Property(property).IsModified = true;
                    }
                }
            }
            applicationContext.SaveChanges();
            return true;
        }

        public bool Delete(int keyId)
        {
            var entity = dbSet.Find(keyId);
            dbSet.Remove(entity);
            applicationContext.SaveChanges();
            return true;
        }
    }
}
