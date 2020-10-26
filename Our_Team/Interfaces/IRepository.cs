using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Our_Team.Interfaces
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        IQueryable<TEntity> Get<T>();

        TEntity GetById<T>(Guid? id) where T : class;

        void Insert(TEntity entity);

        void Update(TEntity item);

        void Delete<T>(Guid? id) where T : class;

        void Delete(TEntity item);

        void SaveChanges(bool withDisposing = false);
    }
}