using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataLayer.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity Find(Expression<Func<TEntity, bool>> criteria);

        List<TEntity> GetList(Expression<Func<TEntity, bool>> criteria = null);

        TEntity Add(TEntity entity);

        TEntity SingleOrDefault(Expression<Func<TEntity, bool>> criteria);
    }
}
